using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.IO;


namespace TestExerciser.Tools.AutoTestingManagement
{
    public partial class ToolAutoNewFolder : Form
    {
        public static string folderLocation = null;
        public static bool isCreateFolder = false;
        //private string [] folders ;
        string[] newFolderName;
        List<string> newFolderNameList = new List<string>();

        public ToolAutoNewFolder()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.stbFolderName.Text != "")
            {
                RegexInfo myLoginInfo = new RegexInfo();
                if (myLoginInfo.isProjectName(this.stbFolderName.Text))
                {
                    if (MainAutoTesting.selectedNodePath != "")
                    {                                                
                        folderLocation = MainAutoTesting.selectedNodePath + "\\" + this.stbFolderName.Text;
                        DirectoryInfo myDirInfo = new DirectoryInfo(MainAutoTesting.selectedNodePath);
                        DirectoryInfo [] chldFolders = myDirInfo.GetDirectories();
                        foreach (DirectoryInfo chldFolder in chldFolders)
                        {
                            newFolderNameList.Add(chldFolder.Name);                            
                            newFolderName = newFolderNameList.ToArray();
                        }
                        if (newFolderName != null)
                        {
                            if (Array.IndexOf<string>(newFolderName, this.stbFolderName.Text) != -1)
                            {
                                MessageBox.Show("文件夹名称冲突，请修改工程名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                this.IsCreateFolder = true;
                                createFolder(folderLocation);
                                this.txtStatus.ForeColor = Color.Green;
                                this.txtStatus.Text = "创建信息：创建成功！";
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            this.IsCreateFolder = true;
                            createFolder(folderLocation);
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "创建信息：创建成功！";
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }                       
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "创建信息：创建失败，所选项目为空！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "创建信息：创建失败，请正确填写文件夹名称！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "创建信息：创建失败，文件夹名称不能为空！";
            }
        }

        private void createFolder(string projectLocation)
        {
            if (!Directory.Exists(projectLocation))
            {
                Directory.CreateDirectory(projectLocation);
            }
        }

        public bool IsCreateFolder
        {
            get { return isCreateFolder; }
            set { isCreateFolder = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void ToolNewFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_KeyDown(sender, e);
            }
        }


        
    }
}
