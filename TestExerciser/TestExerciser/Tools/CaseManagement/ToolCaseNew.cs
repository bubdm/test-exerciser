using System;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.IO;
using System.Xml;

namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseNew : Form
    {
        public ToolCaseNew()
        {
            InitializeComponent();
        }

        ManageDB myManageDB = new ManageDB();

        private void ToolCaseCommit_Load(object sender, EventArgs e)
        {
            this.dtpEditDate.text = DateTime.Today.ToShortDateString();
            this.tAuthor.Text = ManageDB.userName;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (tCaseNO.Text != null && tCaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "CaseManager", this.tCaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tCaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tCaseNO.Text = "";
                }
                else
                {
                    myManageDB.InsertInto("insert into CaseManager(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceAuthor,ceEditDate,ceIfAuto,cePrecondition,ceSteps,ceSamples,ceExcept) values('" + this.tProject.Text + "','" + this.cStruct.Text + "','" + this.tSuiteNO.Text + "','" + this.tSuiteName.Text + "','" + this.tCaseNO.Text + "','" + this.tCaseName.Text + "','" + this.tReqNO.Text + "','" + this.cCaseLevel.Text + "','" + this.tAuthor.Text + "','" + this.dtpEditDate.Text + "','" + this.cIfAuto.Text + "','" + this.rtPrecondition.Text + "','" + this.rtSteps.Text + "','" + this.rtSamples.Text + "','" + this.rtExcept.Text + "')");


                    this.Visible = false;
                    this.Close();
                }               
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tCaseNO_Leave(object sender, EventArgs e)
        {
            if (this.tCaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "CaseManager", this.tCaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tCaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tCaseNO.Text = "";
                }
            }
        }

        private void tCaseName_Leave(object sender, EventArgs e)
        {
            if (this.tCaseName.Text != "")
            {
                if (myManageDB.checkItem("ceCaseName", "CaseManager", this.tCaseName.Text))
                {
                    MessageBox.Show("测试用例名称： '" + this.tCaseName.Text + "' 已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tCaseName.Text = "";
                }
            }
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (tCaseNO.Text != null && tCaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "CaseManager", this.tCaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tCaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tCaseNO.Text = "";
                }
                else
                {
                    myManageDB.InsertInto("insert into CaseManager(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceAuthor,ceEditDate,ceIfAuto,cePrecondition,ceSteps,ceSamples,ceExcept) values('" + this.tProject.Text + "','" + this.cStruct.Text + "','" + this.tSuiteNO.Text + "','" + this.tSuiteName.Text + "','" + this.tCaseNO.Text + "','" + this.tCaseName.Text + "','" + this.tReqNO.Text + "','" + this.cCaseLevel.Text + "','" + this.tAuthor.Text + "','" + this.dtpEditDate.Text + "','" + this.cIfAuto.Text + "','" + this.rtPrecondition.Text + "','" + this.rtSteps.Text + "','" + this.rtSamples.Text + "','" + this.rtExcept.Text + "')");
                    string[] caseNo = this.tCaseNO.Text.Split('_');

                    try
                    {
                        this.tCaseNO.Text = (Convert.ToInt32(caseNo[caseNo.Length - 1]) + 1).ToString();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.tCaseName.Text = "";
                    this.rtPrecondition.Text = "";
                    this.rtSteps.Text = "";
                    this.rtSamples.Text = "";
                }              
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                                     
        }

        private void ToolCaseCommit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainCaseManager myMainCaseManager = new MainCaseManager();
            myMainCaseManager.Show();
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            ToolSelectProject myToolSelectProject = new ToolSelectProject();
            myToolSelectProject.Show();
            myToolSelectProject.SetSelectProjectName += new SetSelectProject(this.d_SetProjectName);
            myToolSelectProject.SetSelectProjectStruct += new SetSelectProject(this.d_SetProjectStruct);
            myToolSelectProject.SetSelectProjectVersion += new SetSelectProject(this.d_SetProjectVersion);
        }

        private void d_SetProjectName()
        {
            this.tProject.Text = ToolSelectProject.seletedProjectName;
        }

        private void d_SetProjectStruct()
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myProjectStruct = new LoadXml();
                this.cStruct.Items.Clear();
                myProjectStruct.loadXmlToComBox(xmlDoc.DocumentElement, this.cStruct);
            }
        }
        private void d_SetProjectVersion()
        { 
        //用例暂不含此项
        }
    }
}
