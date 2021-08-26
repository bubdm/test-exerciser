using System;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.IO;
using System.Xml;

namespace TestExerciser.Tools.BugManagement
{
    public partial class ToolBugModify : Form
    {
        ManageDB myManageDB = new ManageDB();
        string bugID = MainBugManager.myCurrentBugNo;
        string userName = ManageDB.userName + "(" + ManageDB.userEmailAddress + ")";

        public ToolBugModify()
        {
            InitializeComponent();
        }

        private void updateDataToDataBase()
        {
            myManageDB.UpdateDB("BugManager", "bugAttribution", this.tbProject.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugFoundStruct", this.cbStruct.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugFoundVersion", this.cbVersion.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugTitle", this.tbBugTitle.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugHowFound", this.cbHowFound.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugCategory", this.cbCategory.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugGravity", this.cbGravity.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugOccurrence", this.cbOccurrence.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugPriority", this.cbPriority.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugExceptDate", this.dtpExceptDate.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugAuthor", this.tbAuthor.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugEditDate", this.dtpEditDate.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugReproSteps", this.rtbReproSteps.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugExcept", this.rtbExcept.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugActually", this.rtbActually.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugSamples", this.rtbSamples.Text, "bugID", bugID);          
            myManageDB.UpdateDB("BugManager", "bugModify", this.tbModify.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugModifyDate", this.dtpModifyDate.Text, "bugID", bugID);
            myManageDB.UpdateDB("BugManager", "bugUpdateDate", DateTime.Today.ToShortDateString(), "bugID", bugID);
        }

        private void ToolBugModify_Load(object sender, EventArgs e)
        {
            this.initFormControl();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.tbProject.Text != "" && this.cbStruct.Text != "" && this.cbVersion.Text != "" && this.tbBugTitle.Text != "")
            {
                this.updateDataToDataBase();
                this.Visible = false;
                this.Close();
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "保存成功";
                tb.Show();
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.cbAuditor.Text != "")
            {
                if (this.tbProject.Text != "" && this.cbStruct.Text != "" && this.cbVersion.Text != "" && this.tbBugTitle.Text != "")
                {
                    this.updateDataToDataBase();
                    myManageDB.UpdateDB("BugManager", "bugAuditor", this.cbAuditor.Text, "bugID", bugID);
                    myManageDB.UpdateDB("BugManager", "bugStatus", "创建审核", "bugID", bugID);
                    this.Visible = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            ToolUpLoad myToolUpLoad = new ToolUpLoad();
            myToolUpLoad.Show();
        }

        private void initFormControl()
        {

            try
            {
                this.tbProject.Text = myManageDB.getDataFromCell("bugAttribution", "BugManager", "bugID", bugID);
                this.cbStruct.Text = myManageDB.getDataFromCell("bugFoundStruct", "BugManager", "bugID", bugID);
                this.cbVersion.Text = myManageDB.getDataFromCell("bugFoundVersion", "BugManager", "bugID", bugID);
                this.tbBugTitle.Text = myManageDB.getDataFromCell("bugTitle", "BugManager", "bugID", bugID);
                this.cbHowFound.Text = myManageDB.getDataFromCell("bugHowFound", "BugManager", "bugID", bugID);
                this.cbCategory.Text = myManageDB.getDataFromCell("bugCategory", "BugManager", "bugID", bugID);
                this.cbGravity.Text = myManageDB.getDataFromCell("bugGravity", "BugManager", "bugID", bugID);
                this.cbOccurrence.Text = myManageDB.getDataFromCell("bugOccurrence", "BugManager", "bugID", bugID);
                this.cbPriority.Text = myManageDB.getDataFromCell("bugPriority", "BugManager", "bugID", bugID);
                this.dtpExceptDate.Text = myManageDB.getDataFromCell("bugExceptDate", "BugManager", "bugID", bugID).Split(' ')[0];

                this.tbAuthor.Text = myManageDB.getDataFromCell("bugAuthor", "BugManager", "bugID", bugID).Split(' ')[0];
                this.dtpEditDate.Text = myManageDB.getDataFromCell("bugEditDate", "BugManager", "bugID", bugID);
                this.rtbReproSteps.Text = myManageDB.getDataFromCell("bugReproSteps", "BugManager", "bugID", bugID);
                this.rtbSamples.Text = myManageDB.getDataFromCell("bugSamples", "BugManager", "bugID", bugID);
                this.rtbExcept.Text = myManageDB.getDataFromCell("bugExcept", "BugManager", "bugID", bugID);
                this.rtbActually.Text = myManageDB.getDataFromCell("bugActually", "BugManager", "bugID", bugID);
                this.cbAuditor.Text = myManageDB.getDataFromCell("bugAuditor", "BugManager", "bugID", bugID);
                this.dtpModifyDate.Text = DateTime.Today.ToShortDateString();
                this.tbModify.Text = userName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void d_SetProjectName()
        {
            this.tbProject.Text = ToolSelectProject.seletedProjectName;
        }

        private void d_SetProjectStruct()
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                this.cbStruct.Items.Clear();
                myLoadXml.loadXmlToComBox(xmlDoc.DocumentElement, this.cbStruct);
            }
        }

        private void d_SetProjectVersion()
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                this.cbVersion.Items.Clear();
                myLoadXml.loadXmlToComBox(xmlDoc.DocumentElement, this.cbVersion);
            }
        }

        private void cbAuditor_DropDown(object sender, EventArgs e)
        {
            this.cbAuditor.Items.Clear();
            myManageDB.selectItems(this.cbAuditor, "UserManager");
        }
    }
}
