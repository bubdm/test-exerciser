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
using System.Data.SqlClient;


namespace TestExerciser.Tools.AutoTestingManagement
{
    public partial class ToolAutoCodePacking : Form
    {

        Object cellTempValue = new object {};
        bool needUpdate = false;
        


        public ToolAutoCodePacking()
        {
            InitializeComponent();
        }

        private void MainPackageManager_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testExerciser.CodePacking”中。您可以根据需要移动或删除它。
            this.codePackingTableAdapter.Fill(this.testExerciser.CodePacking);
        }

        private void dgvPackageManager_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvPackageManager_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MainPackageManager_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if (needUpdate)
            {
                SqlConnection mycon = null;
                DialogResult myDialogResult = MessageBox.Show("确定修改并将修改内容保存到数据库吗？", "消息提示：", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (myDialogResult == DialogResult.Yes)
                {
                    try
                    {
                        mycon = new SqlConnection(ManageDB.strcon);
                        mycon.Open();
                        DataTable myDataTable = this.testExerciser.CodePacking;
                        SqlDataAdapter myDataAdapter = this.codePackingTableAdapter.Adapter;
                        SqlCommandBuilder myOleDbCommandBuilder = new SqlCommandBuilder(myDataAdapter);
                        myDataAdapter.Update(myDataTable);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mycon.Close();
                    }                               
                }
                else if(myDialogResult == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (myDialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private string setMethodID(object sender, DataGridViewCellEventArgs e)
        {
            return "M" + DateTime.Today.ToShortDateString().Replace("/", "") + DateTime.Now.ToLongTimeString().Replace(":","");
        }

        private void dgvPackageManager_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!Object.Equals(cellTempValue, this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                needUpdate = true;
                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //if (this.dgvPackageManager.Rows[e.RowIndex].Cells[0].Value.ToString()== "")
                    //{
                    this.dgvPackageManager.Rows[e.RowIndex].Cells[0].Value = this.setMethodID(sender, e);
                    //}
                }
                else
                {
                    this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                }
            }
        }
    }
}
