using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser
{
    public partial class MainUserManager : Form
    {
        DataTable myDTCase = new DataTable();
        ManageDB myManageDB =new ManageDB();

        public MainUserManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }

        private void setDataGridViewColumnHeaders()
        {
            myDTCase.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("姓名"),
                    new DataColumn("账号"),
                    new DataColumn("邮箱"),
                    new DataColumn("角色"),
                });
            this.dgv_ShowUsers.ColumnCount = 4;
            for (int i = 0; i < this.dgv_ShowUsers.ColumnCount; i++)
            {
                this.dgv_ShowUsers.Columns[i].Name = myDTCase.Columns[i].ColumnName;
                this.dgv_ShowUsers.Columns[i].DataPropertyName = myDTCase.Columns[i].ColumnName;
                this.dgv_ShowUsers.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    this.dgv_ShowUsers.Columns[i].Width = 120;
                else
                    this.dgv_ShowUsers.Columns[i].Width = 150;
            }
        }

        private void setDataGridViewControl(string[] myRows)
        {
            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = myDTCase.NewRow();
                    row[0] = myManageDB.getDataFromCell("userName", "UserManager", "userEmail", myRow); ;
                    row[1] = myManageDB.getDataFromCell("userAccount", "UserManager", "userEmail", myRow);
                    row[2] = myRow;
                    row[3] = myManageDB.getDataFromCell("userCurrentRole", "UserManager", "userEmail", myRow);
                    myDTCase.Rows.Add(row);
                }
                this.dgv_ShowUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgv_ShowUsers.DataSource = myDTCase;
            }
        }

        private void MainUserManager_Load(object sender, EventArgs e)
        {
            this.btnUserQuery.Visible = false;
            string[] myRows = myManageDB.getDataFromCells("userEmail", "UserManager");
            this.setDataGridViewControl(myRows);
        }

        private void btnUserQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnRoleEditor_Click(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (this.tbUserName.Text != "")
            {
                this.searchUsers("",this.tbUserName);
                this.tbUserAccount.Enabled = false;
                this.tbUserEmail.Enabled = false;
                this.tbUserRole.Enabled = false;
            }
            else
            {
                this.tbUserAccount.Enabled = true;
                this.tbUserEmail.Enabled = true;
                this.tbUserRole.Enabled = true;
            }
        }

        private void tbUserAccount_TextChanged(object sender, EventArgs e)
        {
            if (this.tbUserAccount.Text != "")
            {
                this.searchUsers("", this.tbUserAccount);
                this.tbUserName.Enabled = false;
                this.tbUserEmail.Enabled = false;
                this.tbUserRole.Enabled = false;
            }
            else
            {
                this.tbUserName.Enabled = true;
                this.tbUserEmail.Enabled = true;
                this.tbUserRole.Enabled = true;
            }
        }

        private void tbUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.tbUserEmail.Text != "")
            {
                this.searchUsers("", this.tbUserEmail);
                this.tbUserAccount.Enabled = false;
                this.tbUserName.Enabled = false;
                this.tbUserRole.Enabled = false;
            }
            else
            {
                this.tbUserAccount.Enabled = true;
                this.tbUserName.Enabled = true;
                this.tbUserRole.Enabled = true;
            }
        }

        private void tbUserRole_TextChanged(object sender, EventArgs e)
        {
            if (this.tbUserRole.Text != "")
            {
                this.searchUsers("", this.tbUserRole);
                this.tbUserAccount.Enabled = false;
                this.tbUserEmail.Enabled = false;
                this.tbUserName.Enabled = false;
            }
            else
            {
                this.tbUserAccount.Enabled = true;
                this.tbUserEmail.Enabled = true;
                this.tbUserName.Enabled = true;
            }
        }

        private void searchUsers(string sqlColumn,TextBox tb)
        {
            myManageDB.getDataFromCells("userEmail", "UserManager", sqlColumn, tb.Text);
        }
    }
}
