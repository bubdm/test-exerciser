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
using System.Xml;

namespace TestExerciser.Tools.BugManagement
{
    public partial class ToolBugNew : Form
    {

        ManageDB myManageDB = new ManageDB();
        string bugID = null;
        string userName = ManageDB.userName + "(" + ManageDB.userEmailAddress + ")";

        public ToolBugNew()
        {
            InitializeComponent();
        }

        private void insertDataToDataBase()
        {
            myManageDB.InsertInto("insert into BugManager(bugID,bugAttribution,bugFoundStruct,bugFoundVersion,bugTitle,bugHowFound,bugCategory,bugOccurrence,bugPriority,bugExceptDate,bugAuthor,bugEditDate,bugReproSteps,bugExcept,bugActually,bugGravity,bugSamples,bugStatus) values('" + bugID + "','" + this.tbProject.Text + "','" + this.cbStruct.Text + "','" + this.cbVersion.Text + "','" + this.tbBugTitle.Text + "','" + this.cbHowFound.Text + "','" + this.cbCategory.Text + "','" + this.cbOccurrence.Text + "','" + this.cbPriority.Text + "','" + this.stpExceptDate.Text + "','" + this.tbAuthor.Text + "','" + this.dtpEditDate.Text + "','" + this.rtbReproSteps.Text + "','" + this.rtbExcept.Text + "','" + this.rtbActually.Text + "','" + this.cbGravity.Text + "','" + this.rtbSamples.Text + "','" + "初始化" + "')");
            myManageDB.UpdateDB("BugManager", "bugUpdateDate", DateTime.Today.ToShortDateString(), "bugID", bugID);
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            ToolUpLoad myToolUpLoad = new ToolUpLoad();
            myToolUpLoad.Show();
        }

        private string setBugID()
        {
            return GUID.getGUID("BUG");
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.tbProject.Text != "" && this.cbStruct.Text != "" && this.cbVersion.Text != "" && this.tbBugTitle.Text != "")
            {
                if (myManageDB.checkItem("bugID", "BugManager", bugID))
                {
                    MessageBox.Show("缺陷编号：" + bugID + "已存在！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.insertDataToDataBase();
                    this.Visible = false;
                    this.Close();
                    ToolBalloon tb = new ToolBalloon();
                    tb.BalloonText = "保存成功";
                    tb.Show();
                }
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (this.tbProject.Text != "" && this.cbStruct.Text != "" && this.cbVersion.Text != "" && this.tbBugTitle.Text != "")
            {
                
                if (myManageDB.checkItem("bugID", "BugManager", bugID))
                {
                    MessageBox.Show("缺陷编号：" + bugID + "已存在！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                 
                    this.insertDataToDataBase();
                    bugID = this.setBugID();
                    this.tbBugTitle.Text = "";
                    this.rtbSamples.Text = "";
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

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            ToolSelectProject myToolSelectProject = new ToolSelectProject();
            myToolSelectProject.Show();
            myToolSelectProject.SetSelectProjectName += new SetSelectProject(this.d_SetProjectName);
            myToolSelectProject.SetSelectProjectStruct += new SetSelectProject(this.d_SetProjectStruct);
            myToolSelectProject.SetSelectProjectVersion += new SetSelectProject(this.d_SetProjectVersion);
        }

        private void ToolBugCommit_Load(object sender, EventArgs e)
        {
            this.initFormControl();
            bugID = setBugID();
        }

        private void initFormControl()
        {
            this.stpExceptDate.Text = DateTime.Today.AddDays(5).ToShortDateString();
            this.tbAuthor.Text = userName;
            this.dtpEditDate.Text = DateTime.Today.ToShortDateString();
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

        private void tsbSaveAndSubmit_Click(object sender, EventArgs e)
        {
            if (this.cbAuditor.Text != "")
            {
                if (this.tbProject.Text != "" && this.cbStruct.Text != "" && this.cbVersion.Text != "" && this.tbBugTitle.Text != "")
                {
                    if (myManageDB.checkItem("bugID", "BugManager", bugID))
                    {
                        MessageBox.Show("缺陷编号：" + bugID + "已存在！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.insertDataToDataBase();
                        myManageDB.UpdateDB("BugManager", "bugAuditor", this.cbAuditor.Text, "bugID", bugID);
                        myManageDB.UpdateDB("BugManager", "bugStatus", "创建审核", "bugID", bugID);
                        this.Visible = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            else
            {
                MessageBox.Show("请选择审核人！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
