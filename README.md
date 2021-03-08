git init --初始化
git remote add origin https://github.com/xiao196/*.git   --自己要与origin master建立连接（下划线为远程仓库链接）
git fetch origin master -- 把远程分支拉到本地
git checkout -b dev(本地分支名称) origin/master(远程分支名称)  --在本地创建分支dev并切换到该分支
git pull origin master --把某个分支上的内容都拉取到本地
