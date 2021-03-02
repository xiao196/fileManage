namespace FileManage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_run = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nd_day = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_file = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tb_rpt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIconCtrl = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nd_day)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_run);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bt_edit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nd_day);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_ext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_file);
            this.groupBox1.Controls.Add(this.tb_path);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件设置";
            // 
            // cb_run
            // 
            this.cb_run.AutoSize = true;
            this.cb_run.Location = new System.Drawing.Point(697, 24);
            this.cb_run.Name = "cb_run";
            this.cb_run.Size = new System.Drawing.Size(48, 16);
            this.cb_run.TabIndex = 11;
            this.cb_run.Text = "禁用";
            this.cb_run.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 299);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(748, 21);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(45, 21);
            this.bt_edit.TabIndex = 9;
            this.bt_edit.Text = "添加";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "天前";
            // 
            // nd_day
            // 
            this.nd_day.Location = new System.Drawing.Point(603, 21);
            this.nd_day.Name = "nd_day";
            this.nd_day.Size = new System.Drawing.Size(52, 21);
            this.nd_day.TabIndex = 7;
            this.nd_day.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "删除";
            // 
            // tb_ext
            // 
            this.tb_ext.Location = new System.Drawing.Point(400, 20);
            this.tb_ext.Name = "tb_ext";
            this.tb_ext.Size = new System.Drawing.Size(158, 21);
            this.tb_ext.TabIndex = 5;
            this.tb_ext.Text = "jpg,png";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "后缀名";
            // 
            // bt_file
            // 
            this.bt_file.Location = new System.Drawing.Point(297, 20);
            this.bt_file.Name = "bt_file";
            this.bt_file.Size = new System.Drawing.Size(45, 21);
            this.bt_file.TabIndex = 3;
            this.bt_file.Text = "选择";
            this.bt_file.UseVisualStyleBackColor = true;
            this.bt_file.Click += new System.EventHandler(this.bt_file_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(56, 20);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(232, 21);
            this.tb_path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "统计信息";
            // 
            // tb_rpt
            // 
            this.tb_rpt.Location = new System.Drawing.Point(64, 9);
            this.tb_rpt.Multiline = true;
            this.tb_rpt.Name = "tb_rpt";
            this.tb_rpt.ReadOnly = true;
            this.tb_rpt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_rpt.Size = new System.Drawing.Size(775, 33);
            this.tb_rpt.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_rpt);
            this.panel1.Location = new System.Drawing.Point(-1, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 50);
            this.panel1.TabIndex = 12;
            // 
            // notifyIconCtrl
            // 
            this.notifyIconCtrl.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconCtrl.Icon")));
            this.notifyIconCtrl.Text = "文件设置";
            this.notifyIconCtrl.Visible = true;
            this.notifyIconCtrl.DoubleClick += new System.EventHandler(this.notifyIconCtrl_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "文件设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nd_day)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nd_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_file;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_rpt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cb_run;
        private System.Windows.Forms.NotifyIcon notifyIconCtrl;
    }
}

