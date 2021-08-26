using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace TestExerciser.Tools.AutoTestingManagement
{
    public partial class ToolAutoCleanScripts : Form
    {
        public int maxProgressNum = 0;

        public ToolAutoCleanScripts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 在资源管理器中选择相应文件夹事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult mySelectLocalPath = selectLocalPath.ShowDialog();
            if (mySelectLocalPath == DialogResult.OK)
            {
                this.tbLocalPath.Text = selectLocalPath.SelectedPath;
            }
        }

        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        /// <summary>
        /// 确定删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbLocalPath.Text == "")
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "'本地路径' 不能为空！";
            }
            else
            {
                if (Directory.Exists(this.tbLocalPath.Text))
                {
                    getProgressMaxNum(this.tbLocalPath.Text);
                    if (maxProgressNum != 0)
                    {
                        this.progClean.Maximum = maxProgressNum;
                    }
                    else
                    {
                        this.progClean.Value = 100;
                    }
                    deleteFiles(this.tbLocalPath.Text);
                    txtCleanDetail.AppendText("(*--All useless files have been deleted successfully！--*)" + "\n");
    
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "无效的文件路径！请确认路径是否填写正确！";
                }
            }           
        }

        /// <summary>
        /// 定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myTimer_Tick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 递归删除文件夹下所有内容
        /// </summary>
        /// <param name="filePath"></param>
        private void deleteFiles(string filePath)
        {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(filePath);
                FileInfo[] chldFiles = folder.GetFiles("*.*");
                foreach (FileInfo chlFile in chldFiles)
                {
                    if (chlFile.Name.StartsWith(".") || chlFile.Name == "workspace" || chlFile.Name == "__pycache__" || chlFile.Name.StartsWith("__runner")||chlFile.Name.EndsWith("py"))
                    {
                        File.Delete(chlFile.FullName);
                        txtCleanDetail.AppendText("deleted file ：" + chlFile.FullName + "\n");
                        if (this.progClean.Value < this.progClean.Maximum)
                        {
                            progClean.Value++;
                        }
                    }
                }

                DirectoryInfo[] chldFolders = folder.GetDirectories();
                foreach (DirectoryInfo chldFolder in chldFolders)
                {
                    if (chldFolder.Name.StartsWith(".") || chldFolder.Name == "workspace" || chldFolder.Name == "__pycache__")
                    {
                        delectDir(chldFolder.FullName);
                        Directory.Delete(chldFolder.FullName);
                        txtCleanDetail.AppendText("deleted folder ：" + chldFolder.FullName + "\n");
                        if (this.progClean.Value < this.progClean.Maximum)
                        {
                            progClean.Value++;
                        }
                    }
                    else
                    {
                        deleteFiles(chldFolder.FullName);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 删除文件夹下所有内容
        /// </summary>
        /// <param name="filePath"></param>
        private void delectDir(string filePath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(filePath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                        txtCleanDetail.AppendText("deleted folder ：" + i.FullName + "\n");
                        if (this.progClean.Value < this.progClean.Maximum)
                        {
                            progClean.Value++;
                        }
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                        txtCleanDetail.AppendText("deleted file ：" + i.FullName + "\n");
                        if (this.progClean.Value < this.progClean.Maximum)
                        {
                            progClean.Value++;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 执行获取文件数任务
        /// </summary>
        /// <param name="filePath"></param>
        private void getProgressMaxNum(string filePath)
        {
            deleteFilesNum(filePath);                
        }
        
        /// <summary>
        /// 递归获取将要删除文件夹下所有文件数
        /// </summary>
        /// <param name="filePath"></param>
        private void deleteFilesNum(string filePath)
        {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(filePath);
                FileInfo[] chldFiles = folder.GetFiles("*.*");
                foreach (FileInfo chlFile in chldFiles)
                {
                    if (chlFile.Name.StartsWith(".") || chlFile.Name == "workspace" || chlFile.Name == "__pycache__" || chlFile.Name.StartsWith("__runner"))
                    {
                        maxProgressNum++;
                    }
                }

                DirectoryInfo[] chldFolders = folder.GetDirectories();
                foreach (DirectoryInfo chldFolder in chldFolders)
                {
                    if (chldFolder.Name.StartsWith(".") || chldFolder.Name == "workspace" || chldFolder.Name == "__pycache__")
                    {
                        delectDirNum(chldFolder.FullName);
                        maxProgressNum++;
                    }
                    else
                    {
                        deleteFiles(chldFolder.FullName);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 获取删除文件夹下所有文件数
        /// </summary>
        /// <param name="filePath"></param>
        private void delectDirNum(string filePath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(filePath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    maxProgressNum++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolClean_KeyDown(object sender, KeyEventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void ToolAutoCleanScripts_Load(object sender, EventArgs e)
        {
           
        }
    }
}
