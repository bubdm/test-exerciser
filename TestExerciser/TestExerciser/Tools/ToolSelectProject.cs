using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;


namespace TestExerciser.Tools
{
    public delegate void SetSelectProject();

    public partial class ToolSelectProject : Form
    {
        DataTable myDTSelectProject = new DataTable();
        ManageDB myManageDB = new ManageDB();
        public static string seletedProjectNO = "";
        public static string seletedProjectName = "";
        int pagePTR = 0;//设置Page标志位
        string[] myRows; //数据表中CaseNo字段

        public event SetSelectProject SetSelectProjectName;
        public event SetSelectProject SetSelectProjectStruct;
        public event SetSelectProject SetSelectProjectVersion;

        public ToolSelectProject()
        {
            InitializeComponent();
            this.setSelectDataGridViewColumnHeaders();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.dgvSelectProject.DataSource != null)
            {
                this.dgvSelectProject.DataSource = null;
            }
            myDTSelectProject.Rows.Clear();
            if (this.txtProjectName.Text != "")
            {
                myRows = myManageDB.getDataFromCells("proNO", "ProjectManager", "proName", this.txtProjectName.Text);
            }
            else
            {
                myRows = myManageDB.getDataFromCells("proNO", "ProjectManager", "proNO", this.txtProjectNO.Text);
            }
            if (myRows != null)
            {
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = string.Format("查询信息：查询成功！共查询到‘{0}’条信息！", myRows.Length);
                dgvPager_OnPageChanged(sender, e);
                this.updateAfterQuery();
                this.dataGridViewSeletedItem();
            }
            else
            {
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "查询信息：查询成功！共查询到‘0’条信息！";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (seletedProjectName != "")
            {
                this.SetSelectProjectName();
                this.SetSelectProjectStruct();
                this.SetSelectProjectVersion();
                this.btnCancel_Click(sender, e);
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "选择信息：选择失败，请使用鼠标点击并选中工程！";
            }
        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            this.txtProjectName.Text = "";
            this.txtProjectNO.Text = "";
            ToolSelectProject_Load(sender,e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtProjectName.Text != "")
            {
                this.txtProjectNO.Enabled = false;
            }
            else
            {
                this.txtProjectNO.Enabled = true;
            }
        }

        private void txtProjectNO_TextChanged(object sender, EventArgs e)
        {
            if (this.txtProjectNO.Text != "")
            {
                this.txtProjectName.Enabled = false;
            }
            else
            {
                this.txtProjectName.Enabled = true;
            }
        }

        private void setSelectDataGridViewColumnHeaders()
        {
            myDTSelectProject.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("项目"),
                    new DataColumn("项目名称"),
                    new DataColumn("项目经理"),
                    new DataColumn("所属部门"),
                });
            dgvSelectProject.ColumnCount = 4;
            for (int i = 0; i < dgvSelectProject.ColumnCount; i++)
            {
                dgvSelectProject.Columns[i].Name = myDTSelectProject.Columns[i].ColumnName;
                dgvSelectProject.Columns[i].DataPropertyName = myDTSelectProject.Columns[i].ColumnName;
                dgvSelectProject.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvSelectProject.Columns[i].Width = 120;
                else
                    dgvSelectProject.Columns[i].Width = 150;
            }
        }

        private const int ROW_HEIGHT = 30;

        private void setDataGridViewControl(int pageIndex, int pageSize)
        {
            pagePTR = pageSize * (pageIndex - 1);
            if (myRows != null)
            {
                myDTSelectProject.Rows.Clear();
                for (int i = 0; i < dgvPager.PageSize; i++)
                {
                    string myNO = myRows[pagePTR];
                    DataRow row = myDTSelectProject.NewRow();
                    row[0] = myNO;
                    row[1] = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", myNO);
                    row[2] = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", myNO);
                    row[3] = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", myNO);
                    myDTSelectProject.Rows.Add(row);
                    pagePTR++;
                    if (pagePTR >= this.dgvPager.RecordCount)
                    {
                        break;
                    }
                }
                dgvSelectProject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSelectProject.DataSource = myDTSelectProject;
            }
        }

        private void dgvSelectProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSelectProject.Rows.Count != 0)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        DataGridViewCell cell = (DataGridViewCell)dgvSelectProject.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        seletedProjectNO = dgvSelectProject.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        seletedProjectName = dgvSelectProject.Rows[cell.RowIndex].Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void updateAfterQuery()
        {
            this.dgvSelectProject_CellClick(this.dgvSelectProject, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridViewSeletedItem()
        {
            if (this.dgvSelectProject.Rows.Count != 0)
            {
                this.dgvSelectProject.CurrentCell = this.dgvSelectProject.Rows[0].Cells[0];
            }
        }

        private void ToolSelectProject_Load(object sender, EventArgs e)
        {
            myRows = myManageDB.getDataFromCells("proNO", "ProjectManager");
            this.dgvPager.PageSize = 15;//设置每页默认显示记录数
            //激活OnPageChanged事件
            this.dgvPager.OnPageChanged += new EventHandler(dgvPager_OnPageChanged);
            dgvPager_OnPageChanged(sender, e);
            this.updateAfterQuery();
            this.dataGridViewSeletedItem();
        }

        private void dgvPager_OnPageChanged(object sender, EventArgs e)
        {
            this.LoadData(myRows);
        }

        /// <summary>
        /// 重新加载数据
        /// </summary>
        private void LoadData(string[] myRows)
        {
            if (myRows != null)
            {
                this.dgvPager.RecordCount = myRows.Length;
                this.dgvPager.DrawControl(dgvPager.RecordCount);
                this.setDataGridViewControl(dgvPager.PageIndex, dgvPager.PageSize);
            }
            else
            {
                this.dgvPager.RecordCount = 0;
                this.dgvPager.DrawControl(dgvPager.RecordCount);
                this.setDataGridViewControl(dgvPager.PageIndex, dgvPager.PageSize);
            }
        }
    }
}
