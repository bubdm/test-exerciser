using System;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseModify : Form
    {
        ManageDB myManageDB = new ManageDB();
        string tcNO = MainCaseManager.myCaseNo;

        public ToolCaseModify()
        {
            InitializeComponent();
        }

        private void ToolCaseModify_Load(object sender, EventArgs e)
        {
            try
            {
                this.tProject.Text = myManageDB.getDataFromCell("ceProject", "CaseManager", "ceCaseNO", tcNO);
                this.cStruct.Text = myManageDB.getDataFromCell("ceStruct", "CaseManager", "ceCaseNO", tcNO);
                this.tSuiteNO.Text = myManageDB.getDataFromCell("ceSuiteNO", "CaseManager", "ceCaseNO", tcNO);
                this.tSuiteName.Text = myManageDB.getDataFromCell("ceSuiteName", "CaseManager", "ceCaseNO", tcNO);
                this.tCaseNO.Text = myManageDB.getDataFromCell("ceCaseNO", "CaseManager", "ceCaseNO", tcNO);
                this.tCaseName.Text = myManageDB.getDataFromCell("ceCaseName", "CaseManager", "ceCaseNO", tcNO);
                this.tReqNO.Text = myManageDB.getDataFromCell("ceReqNO", "CaseManager", "ceCaseNO", tcNO);
                this.cCaseLevel.Text = myManageDB.getDataFromCell("ceCaseLevel", "CaseManager", "ceCaseNO", tcNO);
                this.tAuthor.Text = myManageDB.getDataFromCell("ceAuthor", "CaseManager", "ceCaseNO", tcNO);
                this.tEditDate.Text = myManageDB.getDataFromCell("ceEditDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];               

                this.dtpModifyDate.Text = myManageDB.getDataFromCell("ceModifyDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.rtPrecondition.Text = myManageDB.getDataFromCell("cePrecondition", "CaseManager", "ceCaseNO", tcNO);
                this.rtSteps.Text = myManageDB.getDataFromCell("ceSteps", "CaseManager", "ceCaseNO", tcNO);
                this.rtSamples.Text = myManageDB.getDataFromCell("ceSamples", "CaseManager", "ceCaseNO", tcNO);
                this.rtExcept.Text = myManageDB.getDataFromCell("ceExcept", "CaseManager", "ceCaseNO", tcNO);
                this.cIfAuto.Text = myManageDB.getDataFromCell("ceIfAuto", "CaseManager", "ceCaseNO", tcNO);
                this.dtpModifyDate.Text = DateTime.Today.ToShortDateString();
                this.tModifier.Text = ManageDB.userName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                myManageDB.UpdateDB("CaseManager", "ceProject", this.tProject.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceStruct", this.cStruct.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceSuiteNO", this.tSuiteNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceSuiteName", this.tSuiteName.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceCaseNO", this.tCaseNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceCaseName", this.tCaseName.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceReqNO", this.tReqNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceCaseLevel", this.cCaseLevel.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceAuthor", this.tAuthor.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceEditDate", this.tEditDate.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceModifier", this.tModifier.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceModifyDate", this.dtpModifyDate.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "cePrecondition", this.rtPrecondition.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceSteps", this.rtSteps.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceSamples", this.rtSamples.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceExcept", this.rtExcept.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("CaseManager", "ceIfAuto", this.cIfAuto.Text, "ceCaseNO", tcNO);
                this.Visible = false;
                this.Close();
            } 
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tCaseNO_Leave(object sender, EventArgs e)
        {
            if (this.tCaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "CaseManager", this.tCaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tCaseNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tCaseNO.Text = "";
                }
            }
        }

        private void tSuiteNO_Leave(object sender, EventArgs e)
        {
            if (this.tSuiteNO.Text != "")
            {
                if (myManageDB.checkItem("ceSuiteNO", "CaseManager", this.tSuiteNO.Text))
                {
                    MessageBox.Show("测试套编号：" + this.tSuiteNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tSuiteNO.Text = "";
                }
            }
        }

        private void ToolCaseModify_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainCaseManager myMainCaseManager = new MainCaseManager();
            myMainCaseManager.Show();
        }

       
    }
}
