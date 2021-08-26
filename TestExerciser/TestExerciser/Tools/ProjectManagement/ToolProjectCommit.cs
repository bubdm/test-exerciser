using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser.Tools.ProjectManagement
{
    public partial class ToolProjectCommit : Form
    {
        ManageDB myManageDB = new ManageDB();
        int defaultCycle = 1; //默认项目的启动至停止日期为1年，从当前开始计算

        public ToolProjectCommit()
        {
            InitializeComponent();
        }

        private void insertInToDataBase()
        {
            myManageDB.InsertInto("insert into ProjectManager(proName,proShortName,proNO,proType,proPriority,proDepartment,proManager,proAssistant,proSetUpDate,proClosedDate,proCustomer,proDevelopmentSite,proAuthor,proEditDate,proDescribe) values('" + this.tProjectName.Text + "','" + this.tShortName.Text + "','" + this.tProjectNO.Text + "','" + this.cType.Text + "','" + this.cPriority.Text + "','" + this.tDepartment.Text + "','" + this.cbManager.Text + "','" + this.tAssistant.Text + "','" + this.dtp_SetUpDate.Text + "','" + this.dtp_ClosedDate.Text + "','" + this.tCustomer.Text + "','" + this.tDevelopmentSite.Text + "','" + this.tAuthor.Text + "','" + this.dtp_EditDate.Text + "','" + this.rtDescribe.Text + "')");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.tProjectNO.Text != null && this.tProjectNO.Text != "")
            {
                if (myManageDB.checkItem("proNO", "ProjectManager", this.tProjectNO.Text))
                {
                    MessageBox.Show("项目编号重复，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tProjectNO.Text = "";
                }
                else
                {
                    this.insertInToDataBase();
                    this.Visible = false;
                    this.Close();
                }            
            } 
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (this.tProjectNO.Text != null && this.tProjectNO.Text != "")
            {
                if (myManageDB.checkItem("proNO", "ProjectManager", this.tProjectNO.Text))
                {
                    MessageBox.Show("项目编号：" + this.tProjectNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tProjectNO.Text = "";
                }
                else
                {
                    this.insertInToDataBase();
                    this.tProjectName.Text = "";
                    this.tShortName.Text = "";
                    this.cbManager.Text = "";
                    this.tCustomer.Text = "";
                    this.tDepartment.Text = "";
                    this.tDevelopmentSite.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void ToolProjectCommit_Load(object sender, EventArgs e)
        {            
            this.dtp_SetUpDate.Text = DateTime.Today.Year + "/" + DateTime.Today.Month + "/"+ DateTime.Today.Day;
            this.dtp_ClosedDate.Text = DateTime.Today.Year + defaultCycle + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day;
            this.tAuthor.Text = ManageDB.userName;
            this.dtp_EditDate.text = DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day; ;
            this.dtp_EditDate.Enabled = false;
            this.cType.Text = "软件研发瀑布模型";
            this.cPriority.Text = "中";
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void ToolProjectCommit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tProjectNO_Leave(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("proNO", "ProjectManager", this.tProjectNO.Text))
            {
                MessageBox.Show("项目编号：" + this.tProjectNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tProjectNO.Text = "";
            }
        }

        private void cbManager_DropDown(object sender, EventArgs e)
        {
            this.cbManager.Items.Clear();
            myManageDB.selectItems(this.cbManager, "UserManager");
        }
    }
}
