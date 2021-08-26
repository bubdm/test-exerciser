using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.IO;

namespace TestExerciser.Tools.AutoTestingManagement
{
    public partial class ToolAutoNewSolution : Form
    {
        public static string projectLocation = null;
        private  bool isCreateSolution = false;

        public ToolAutoNewSolution()
        {
            InitializeComponent();
        }

        private void ToolNewSolution_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult selectLocation = this.selectLocationFolderBrowser.ShowDialog();
            if (selectLocation == DialogResult.OK)
            {
                this.stbLocation.Text = this.selectLocationFolderBrowser.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.stbProName.Text != "")
            {
                RegexInfo myLoginInfo = new RegexInfo();
                if (myLoginInfo.isProjectName(this.stbProName.Text))
                {
                    if (myLoginInfo.isProjectLocation(this.stbLocation.Text))
                    {    
                        projectLocation = this.stbLocation.Text + "\\" + this.stbProName.Text;
                        if (Array.IndexOf<string>(MainAutoTesting.root_paths, projectLocation) != -1)
                        {
                            MessageBox.Show("打开工程名称冲突，请修改工程名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.IsCreateSolution = true;                            
                            createFolder(projectLocation);                            
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "创建信息：创建成功！";
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "创建信息：创建失败，请正确填写项目路径！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "创建信息：创建失败，请正确填写项目名称！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "创建信息：创建失败，项目名称不能为空！";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Close();
        }   
    
        private void createFolder(string projectLocation)
        {
            if (!Directory.Exists(projectLocation))
            {
                Directory.CreateDirectory(projectLocation);
            }
        }

        public bool IsCreateSolution
        {
            get { return isCreateSolution; }
            set { isCreateSolution = value; }
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void ToolNewSolution_KeyDown(object sender, KeyEventArgs e)
        {
            btnOK_Click(sender, e);
        }
    }
}