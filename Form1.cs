using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManage
{
    public partial class Form1 : Form
    {
        const string _cols = "目录，后缀名，删除N天前，是否禁用", _sysName = "/set.csv";
        string sdate = "";
        long num = 0;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            sdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var ts = _cols.Split('，');
            foreach (var t in ts)
            {
                dt.Columns.Add(t);
            }
            dataGridView1.DataSource = dt;
            loadSet();
            //icon
            this.showDlgMenu.Click += new EventHandler(showDlgMenu_Click);
            this.exitMenu.Click += new EventHandler(exitMenu_Click);

            this.notifyIconCtrl.ContextMenu = new System.Windows.Forms.ContextMenu();
            this.notifyIconCtrl.ContextMenu.MenuItems.Add(this.showDlgMenu);
            this.notifyIconCtrl.ContextMenu.MenuItems.Add(this.exitMenu);
            setAutoRun();
            delFiles();
        }
        #region icon
        /*
        private void Form1_Leave(object sender, EventArgs e)
        {
            MinToIcon();
            //System.Environment.Exit(0);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MinToIcon();
        }*/
        private void notifyIconCtrl_DoubleClick(object sender, EventArgs e)
        {
            ShowDlg();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            {
                e.Cancel = true;
                MinToIcon();
            }

        }
        private MenuItem showDlgMenu = new MenuItem("显示窗体");
        private MenuItem exitMenu = new MenuItem("退出");
        private void MinToIcon()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            this.notifyIconCtrl.Visible = true;
        }

        private void ShowDlg()
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.notifyIconCtrl.Visible = false;
        }      
        
        private void btnMinToIcon_Click(object sender, EventArgs e)
        {
            MinToIcon();
        }

        void showDlgMenu_Click(object sender, EventArgs e)
        {
            ShowDlg();
        }
        void exitMenu_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            Application.ExitThread();
        }
        void setAutoRun(bool auto = true)
        {
            string run = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string name = "fileMan";
            try
            {
                if (auto) //设置开机自启动  
                {
                    //获取程序路径
                    string execPath = Application.ExecutablePath;
                    RegistryKey RKey = Registry.LocalMachine.OpenSubKey(run,true);
                    RKey = RKey.CreateSubKey(name);
                    var key = RKey.OpenSubKey(name, true);
                    //string[] ar = RKey.GetValueNames();
                    key.SetValue(name, execPath, RegistryValueKind.String);
                }
                else //取消开机自启动  
                {
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.OpenSubKey(run);
                    rk2.DeleteValue(name, false);
                    rk2.Close();
                    rk.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ex:" + ex.Message);
            }
        }
        #endregion
        void loadSet()
        {
            if (File.Exists(Application.StartupPath + _sysName))
            {
                var fs = File.ReadAllLines(Application.StartupPath + _sysName);
                if (fs.Length > 0)
                {
                    int first = 0;
                    if (fs[0].IndexOf(",name,") >= 0) first = 1;
                    var ns = _cols.Split('，');
                    string km = "";
                    for (int j = first; j < fs.Length; j++)
                    {
                        var vs = fs[j].Split(',');
                        string k = vs[0] + ",";
                        if (km.IndexOf(k) >= 0) continue; else km += k;
                        var dr = dt.NewRow();
                        for (int t = 0; t < ns.Length && t < vs.Length; t++)
                        {
                            string v = vs[t];
                            dr[ns[t]] = v;
                            dataGridView1.Columns[t].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        dt.Rows.Add(dr);
                    }
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void bt_file_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                tb_path.Text = dialog.SelectedPath;
            }
        }
        int crow = -1;
        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_path.Text))
            {
                MessageBox.Show(this, "目录不能为空", "提示");
                return;
            }
            var dr = crow >= 0 ? dt.Rows[crow] : dt.NewRow();
            dr[0] = tb_path.Text;
            dr[1] = tb_ext.Text.Replace(",", "，");
            dr[2] = nd_day.Value.ToString();
            dr[3] = cb_run.Checked ? "是" : "否";
            if (bt_edit.Text == "添加") dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            saveFile();
            tb_path.Text = "";
            bt_edit.Text = "添加";
            cb_run.Checked = false;
            crow = -1;
        }
        void saveFile()
        {
            StringBuilder rows = new StringBuilder();
            string km = "", row = "";
            var ns = _cols.Split('，');
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                row = "";
                string k = r[ns[0]].ToString() + ",";
                k = k.Replace(" ", "_");
                i++;
                if (km.IndexOf(k) >= 0) continue; else km += k;
                foreach (var n in ns)
                {
                    row += r[n].ToString() + ",";// +r[1].ToString() + "," + r[2].ToString() + "," + r[3].ToString();
                    //File.WriteAllText(Application.StartupPath +"\\"+ i  + ".log", row);
                }
                row = row.TrimEnd(',') + "\n";
                rows.Append(row);
            }
            File.WriteAllText(Application.StartupPath + _sysName, rows.ToString());
        }
        private void cb_run_CheckedChanged(object sender, EventArgs e)
        {

        }
        bool isRun = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isRun) delFiles();
            else tb_rpt.Text = string.Format("启动时间：{0},删除文件数：{1},操作目录：{2}", sdate, num, DateTime.Now.ToString());
        }
        void delFiles()
        {
            isRun = true;
            string path = "";
            var ns = _cols.Split('，');
            foreach (DataRow r in dt.Rows)
            {
                try
                {
                    path = r[0].ToString();
                    var ext = r[1].ToString().ToLower();//.Split('，');
                    int day = int.Parse(r[2].ToString());
                    if (r[3].ToString() == "是") continue;
                    delPath(path, ext, day);
                }
                catch { }
            }
            isRun = false;
        }
        void delPath(string path, string ext, int day)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            tb_rpt.Text = string.Format("启动时间：{0},删除文件数：{1},操作目录：{2},{3}", sdate, num, path + "(" + dir.GetFiles().Length + ")", DateTime.Now.ToString());
            foreach (var fi in dir.GetFiles())
            {
                try
                {
                    if (ext.IndexOf(fi.Extension.ToLower().Replace(".", "")) >= 0 && (DateTime.Now - fi.CreationTime).TotalDays > day)
                    {
                        File.Delete(fi.FullName);
                        num++;
                        tb_rpt.Text = string.Format("启动时间：{0},删除文件数：{1},操作目录：{2},{3}", sdate, num, path, DateTime.Now.ToString());
                    }
                }
                catch { }
            }
            var ds = dir.GetDirectories();
            foreach (var d in ds)
            {
                delPath(d.FullName, ext, day);
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dt.Rows.Count)
            {
                bt_edit.Text = "添加"; crow = -1;
                return;
            }
            var dr = dataGridView1.Rows[e.RowIndex];
            if (dr.Cells.Count > 2)
            {
                crow = e.RowIndex;
                tb_path.Text = dr.Cells[0].Value.ToString();
                tb_ext.Text = dr.Cells[1].Value.ToString();
                nd_day.Value = int.Parse(dr.Cells[2].Value.ToString());
                cb_run.Checked = dr.Cells[3].Value.ToString() == "是";
                bt_edit.Text = "修改";
            }
        }

       

        

        

    }
}
