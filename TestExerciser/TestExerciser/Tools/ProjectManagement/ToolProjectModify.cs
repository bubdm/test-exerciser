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
    public partial class ToolProjectModify : Form
    {
        ManageDB myManageDB = new ManageDB();
        string proNO = MainProjectManager.myCurrentProNo;

        public ToolProjectModify()
        {
            InitializeComponent();
        }

        private void ToolProjectModify_Load(object sender, EventArgs e)
        {
            try
            {
                this.tProjectName.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", proNO);
                this.tShortName.Text = myManageDB.getDataFromCell("proShortName", "ProjectManager", "proNO", proNO);
                this.tProjectNO.Text = myManageDB.getDataFromCell("proNO", "ProjectManager", "proNO", proNO);
                this.cType.Text = myManageDB.getDataFromCell("proType", "ProjectManager", "proNO", proNO);
                this.cPriority.Text = myManageDB.getDataFromCell("proPriority", "ProjectManager", "proNO", proNO);
                this.tDepartment.Text = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", proNO);
                this.cbManager.Text = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", proNO);
                this.tAssistant.Text = myManageDB.getDataFromCell("proAssistant", "ProjectManager", "proNO", proNO);
                this.dtp_SetUpDate.Text = myManageDB.getDataFromCell("proSetUpDate", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.dtp_ClosedDate.Text = myManageDB.getDataFromCell("proClosedDate", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.tCustomer.Text = myManageDB.getDataFromCell("proCustomer", "ProjectManager", "proNO", proNO);
                this.tDevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "ProjectManager", "proNO", proNO);
                this.tAuthor.Text = myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", proNO);
                this.dtp_BuildDate.Text = myManageDB.getDataFromCell("proEditDate", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.tModifier.Text = myManageDB.getDataFromCell("proModifier", "ProjectManager", "proNO", proNO);
                this.dtp_ModifyDate.Text = myManageDB.getDataFromCell("proModifyDate", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.rtDescribe.Text = myManageDB.getDataFromCell("proDescribe", "ProjectManager", "proNO", proNO);
                this.dtp_ModifyDate.text = DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day;
                this.tModifier.Text = ManageDB.userName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void ToolProjectModify_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                myManageDB.UpdateDB("ProjectManager", "proName", this.tProjectName.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proShortName", this.tShortName.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proNO", this.tProjectNO.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proType", this.cType.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proPriority", this.cPriority.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDepartment", this.tDepartment.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proManager", this.cbManager.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proAssistant", this.tAssistant.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proSetUpDate", this.dtp_SetUpDate.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proClosedDate", this.dtp_ClosedDate.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proCustomer", this.tCustomer.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDevelopmentSite", this.tDevelopmentSite.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proAuthor", this.tAuthor.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proEditDate", this.dtp_BuildDate.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proModifier", this.tModifier.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proModifyDate", this.dtp_ModifyDate.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDescribe", this.rtDescribe.Text, "proNO", proNO);
     
                this.Visible = false;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbManager_DropDown(object sender, EventArgs e)
        {
            this.cbManager.Items.Clear();
            myManageDB.selectItems(this.cbManager, "UserManager");
        }
    }
}
