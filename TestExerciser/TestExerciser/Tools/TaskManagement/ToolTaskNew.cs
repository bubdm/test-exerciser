using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace TestExerciser.Tools.TaskManagement
{
    public partial class ToolTaskNew : Form
    {
        ManageDB myManageDB = new ManageDB();
        string taskID = null;
        TreeNode myCasesNode = new TreeNode();

        public ToolTaskNew()
        {
            InitializeComponent();
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            if (this.tbProjectName.Text != "" && this.cbProjectStruct.Text != "" && this.cbProjectVersion.Text != "" && this.tbTaskName.Text != "")
            {
                if (myManageDB.checkItem("bugID", "BugManager", taskID))
                {
                    MessageBox.Show("缺陷编号：" + taskID + "已存在！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.insertDataToDataBase();
                    this.Visible = false;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private string setTaskID()
        {
            Guid guid = Guid.NewGuid();
            return "TASK" + guid.ToString().Replace("-", "").ToUpper() + DateTime.Today.ToShortDateString().Replace("/", "");
        }

        private void insertDataToDataBase()
        {
            myManageDB.InsertInto("insert into TaskManager(taskID,taskName,taskProject,taskStruct,taskVersion,taskPriority,taskAssignedTo,taskSetUpDate,taskClosedDate,taskAuthor,taskEditDate,taskDescription) values('" + taskID + "','" + this.tbTaskName.Text + "','" + this.tbProjectName.Text + "','" + this.cbProjectStruct.Text + "','" + this.cbProjectVersion.Text + "','" + this.cbTaskPriority.Text + "','" + this.cbAssignTO.Text + "','" + this.dtp_SetUpDate.Text + "','" + this.dtp_ClosedDate.Text + "','" + this.tbAuthor.Text + "','" + this.dtp_EditDate.Text + "','" + this.rtDescribe.Text + "')");
        }

        private void ToolTaskNew_Load(object sender, EventArgs e)
        {
            taskID = this.setTaskID();
        }

        private void btnSelectCases_Click(object sender, EventArgs e)
        {
            ToolTaskSelectCases myToolTaskSelectCases = new ToolTaskSelectCases();
            myToolTaskSelectCases.Show();
        }
    }
}
