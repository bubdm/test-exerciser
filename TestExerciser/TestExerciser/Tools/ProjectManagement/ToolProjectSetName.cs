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
    public partial class ToolProjectSetName : Form
    {
        RegexInfo myRegexInfo = new RegexInfo();

        public ToolProjectSetName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtStruct.Text != "")
            {
                if (myRegexInfo.isStringName(this.txtStruct.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.labStatus.ForeColor = Color.Green;
                    this.labStatus.Text = "创建结果：创建成功！";
                }
                else
                {
                    this.labStatus.ForeColor = Color.Red;
                    this.labStatus.Text = "创建结果：创建失败，请按正确格式填写项目架构名称！";
                }              
            }
            else
            {
                this.labStatus.ForeColor = Color.Red;
                this.labStatus.Text = "创建结果：创建失败，请先填写项目架构名称！";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
