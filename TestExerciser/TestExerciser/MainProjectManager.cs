using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;
using TestExerciser.Tools.ProjectManagement;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace TestExerciser
{
    public partial class MainProjectManager : Form
    {
        RegexInfo myRegexInfo = new RegexInfo();
        ManageDB myManageDB = new ManageDB();
        public static string myCurrentProNo;
        public static string myCurrentProName;
        DataGridViewRow currentRow;
        public static bool isModify = false;
        int pagePTR = 0;//设置Page标志位
        string[] myRows; //数据表中CaseNo字段

        DataTable myDTProject = new DataTable();
        
        public MainProjectManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectCommit myToolProjectCommit = new ToolProjectCommit();
            myToolProjectCommit.Show();
        }

        private void btnNewStruct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectStruct myToolProjectStruct = new ToolProjectStruct();
            myToolProjectStruct.Show();
        }

        private void btnNewVersion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectVersion myToolProjectVersion = new ToolProjectVersion();
            myToolProjectVersion.Show();
        }

        
        private void setDataGridViewColumnHeaders()
        {
            myDTProject.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("项目"),
                    new DataColumn("所属部门"),
                    new DataColumn("项目经理"),
                    new DataColumn("创建人"),
                    new DataColumn("创建时间"),
                    new DataColumn("项目名称")
                });
            dgvProjectManager.ColumnCount = 5;
            for (int i = 0; i < dgvProjectManager.ColumnCount; i++)
            {
                dgvProjectManager.Columns[i].Name = myDTProject.Columns[i].ColumnName;
                dgvProjectManager.Columns[i].DataPropertyName = myDTProject.Columns[i].ColumnName;
                dgvProjectManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvProjectManager.Columns[i].Width = 120;
                else
                    dgvProjectManager.Columns[i].Width = 150;
            }           
        }

        private const int ROW_HEIGHT = 70;
        private void setDataGridViewControl(int pageIndex, int pageSize)
        {
            pagePTR = pageSize * (pageIndex - 1);
            if (myRows != null)
            {
                myDTProject.Rows.Clear();
                for (int i = 0; i < dgvPager.PageSize; i++)
                {
                    string myNO = myRows[pagePTR];
                    DataRow row = myDTProject.NewRow();
                    row[0] = myNO;
                    row[1] = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", myNO);
                    row[2] = myRegexInfo.getMatchedChineseStr(myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", myNO));
                    row[3] = myRegexInfo.getMatchedChineseStr(myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", myNO));
                    row[4] = myManageDB.getDataFromCell("proEditDate", "ProjectManager", "proNO", myNO).Split(' ')[0];
                    row[5] = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", myNO);
                    myDTProject.Rows.Add(row);
                    pagePTR++;
                    if (pagePTR >= this.dgvPager.RecordCount)
                    {
                        break;
                    }
                }

                //用户不能调整列标题高度
                dgvProjectManager.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dgvProjectManager.RowHeadersVisible = false;
                //设置行高
                dgvProjectManager.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dgvProjectManager.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvProjectManager.AllowUserToAddRows = false;
                dgvProjectManager.AllowUserToDeleteRows = false;
                dgvProjectManager.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvProjectManager.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvProjectManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProjectManager.MultiSelect = false;
                dgvProjectManager.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvProjectManager.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvProjectManager.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvProjectManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProjectManager.DataSource = myDTProject;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRender render = new DataGridViewRender(dgvProjectManager,
                    dgvProjectManager.Columns[dgvProjectManager.ColumnCount - 1]);
            }
        }

        private void showProjectDetails(string prNO)
        {
            try
            {
                this.labProNameValue.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", prNO) + "  ";
                this.txtProjectName.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", prNO);
                this.txtShortName.Text = myManageDB.getDataFromCell("proShortName", "ProjectManager", "proNO", prNO);
                this.txtProNO.Text = myManageDB.getDataFromCell("proNO", "ProjectManager", "proNO", prNO);
                this.txtType.Text = myManageDB.getDataFromCell("proType", "ProjectManager", "proNO", prNO);
                this.txtPriority.Text = myManageDB.getDataFromCell("proPriority", "ProjectManager", "proNO", prNO);
                this.txtDepartment.Text = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", prNO);
                this.txtManager.Text = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", prNO);
                this.txtAssistant.Text = myManageDB.getDataFromCell("proAssistant", "ProjectManager", "proNO", prNO);
                this.txtSetUpTime.Text = myManageDB.getDataFromCell("proSetUpDate", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtClosedTime.Text = myManageDB.getDataFromCell("proClosedDate", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtCustomer.Text = myManageDB.getDataFromCell("proCustomer", "ProjectManager", "proNO", prNO);
                this.txtDevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "ProjectManager", "proNO", prNO);
                this.txtAuthor.Text = myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", prNO);
                this.txtBuildTime.Text = myManageDB.getDataFromCell("proEditDate", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("proModifier", "ProjectManager", "proNO", prNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("proModifyDate", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.rtbDescribe.Text = myManageDB.getDataFromCell("proDescribe", "ProjectManager", "proNO", prNO);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void dgvProjectManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvProjectManager.Rows.Count != 0)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        DataGridViewCell cell = (DataGridViewCell)dgvProjectManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        myCurrentProNo = dgvProjectManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        myCurrentProName = dgvProjectManager.Rows[cell.RowIndex].Cells[5].Value.ToString();
                        currentRow = this.dgvProjectManager.Rows[e.RowIndex];
                        showProjectDetails(myCurrentProNo);
                        
                        //设置架构
                        this.btnSetStruct.Enabled = true;
                        this.tv_Struct.Nodes.Clear();
                        loadXMLToTreeViewControlStruct();
                        this.tv_Struct.ExpandAll();

                        //设置版本
                        this.btnSetVersion.Enabled = true;
                        this.tv_Version.Nodes.Clear();
                        loadXMLToTreeViewControlVersion();
                        this.tv_Version.ExpandAll();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void linkModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void MainProjectManager_Load(object sender, EventArgs e)
        {
            this.btnSetStruct.Enabled = false;
            this.btnSetVersion.Enabled = false;
            this.tbProjectDesign.SelectedIndex = 0;
            myRows = myManageDB.getDataFromCells("proNO", "ProjectManager");
            this.dgvPager.PageSize = 15;//设置每页默认显示记录数
            //激活OnPageChanged事件
            this.dgvPager.OnPageChanged += new EventHandler(dgvPager_OnPageChanged);
            dgvPager_OnPageChanged(sender, e);
            this.updateCellClick();
            this.dataGridViewSeletedItem();
        }

        private void loadXMLToTreeViewControlStruct()
        {
            string str = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", myCurrentProNo);
            if (str != null && str != "")
            {
                isModify = true;
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                myLoadXml.loadXmlToTree(xmlDoc.DocumentElement, this.tv_Struct.Nodes);
            }
            else
            {
                isModify = false;
            }
        }

        private void loadXMLToTreeViewControlVersion()
        {
            string str = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proNO", myCurrentProNo);
            if (str != null && str != "")
            {
                isModify = true;
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                myLoadXml.loadXmlToTree(xmlDoc.DocumentElement,this.tv_Version.Nodes);
            }
            else
            {
                isModify = false;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.tbQueryProject.Text = "";
            this.tbQueryNO.Text = "";
            this.tbQueryAssistant.Text = "";
            this.cbQueryCaseAuthor.Text = "";
            //this.dtpTimeBegin.ResetText();
            //this.dtpTimeEnd.ResetText();
            if (this.dgvProjectManager.DataSource != null)
            {
                this.dgvProjectManager.DataSource = null;
            }
            dgvProjectManager.Rows.Clear();
            MainProjectManager_Load(sender, e);
        }

        private void cbQueryCaseAuthor_DropDown(object sender, EventArgs e)
        {
            this.cbQueryCaseAuthor.Items.Clear();
            myManageDB.selectItems(this.cbQueryCaseAuthor, "UserManager");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.dgvProjectManager.DataSource != null)
            {
                this.dgvProjectManager.DataSource = null;
            }
            myRows = this.queryRows();
            myDTProject.Rows.Clear();
            if (myRows != null)
            {
                dgvPager_OnPageChanged(sender, e);
                this.updateCellClick();
                this.dataGridViewSeletedItem();
            }
        }

        private string[] queryRows()
        {
            string[] myRows = null;
            try
            {
                myRows = myManageDB.getDataFromCells(this.getQuerySQLString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return myRows;
        }

        private string getQuerySQLString()
        {
            string str = "select proNO from ProjectManager ";
            string[][,] queryArray = getNotNullQueryItems();


            if (queryArray.Length != 0)
            {
                string strAddstr = "";
                string strWhere = "where";
                if (queryArray.Length == 1)
                {
                    strAddstr = queryArray[0][0, 0] + "='" + queryArray[0][0, 1] + "'";
                    str = str + strWhere + " " + strAddstr;
                }
                else
                {
                    for (int i = 0; i < queryArray.Length; i++)
                    {
                        if (i != queryArray.Length - 1)
                        {
                            if (i == 0)
                            {
                                strAddstr = queryArray[i][0, 0] + "='" + queryArray[i][0, 1] + "'" + "AND ";
                                str = str + strWhere + " " + strAddstr;
                            }
                            else
                            {
                                strAddstr = queryArray[i][0, 0] + "='" + queryArray[i][0, 1] + "'" + "AND ";
                                str = str + strAddstr;
                            }
                        }
                        else
                        {
                            strAddstr = queryArray[i][0, 0] + "='" + queryArray[i][0, 1] + "'";
                            str = str + strAddstr;
                        }
                    }
                }
                if (this.dtpTimeEnd.Value > this.dtpTimeBegin.Value)
                {
                    string sqlTimeValue = string.Format(" AND proEditDate >='{0}' AND proEditDate<='{1}'", this.dtpTimeBegin.Value.ToShortDateString(), this.dtpTimeEnd.Value.ToShortDateString());
                    str = str + sqlTimeValue;
                }
            }
            return str;
        }

        private string[][,] getNotNullQueryItems()
        {
            string[][,] queryNotNullItems = null;
            List<string[,]> queryNotNullItemsList = new List<string[,]>();
            string[,] queryItems = 
                { 
                    { "proName", this.tbQueryProject.Text }, 
                    { "proNO", this.tbQueryNO.Text }, 
                    { "proManager", this.tbQueryPM.Text }, 
                    { "proAssistant", this.tbQueryAssistant.Text }, 
                    { "proAuthor", myRegexInfo.getMatchedChineseStr(this.cbQueryCaseAuthor.Text) }, 
                };
            int myLength = queryItems.Length / queryItems.Rank;
            for (int i = 0; i < myLength; i++)
            {
                if (queryItems[i, 1] != "")
                {
                    string[,] myQuery = { { queryItems[i, 0], queryItems[i, 1] } };
                    queryNotNullItemsList.Add(myQuery);
                }
            }
            queryNotNullItems = queryNotNullItemsList.ToArray();
            return queryNotNullItems;
        }

       private void updateCellClick()
        {
            this.dgvProjectManager_CellClick(this.dgvProjectManager, new DataGridViewCellEventArgs(0, 0));
        }

       private void dataGridViewSeletedItem()
        {
            if (this.dgvProjectManager.Rows.Count != 0)
            {
                this.dgvProjectManager.CurrentCell = this.dgvProjectManager.Rows[0].Cells[0];
            }
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

        private void btnProjectModify_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectModify myToolProjectModify = new ToolProjectModify();
            myToolProjectModify.Show();
        }

        private void btnProjectsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该项目吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (currentRow != null)
                {
                    try
                    {
                        this.dgvProjectManager.Rows.Remove(currentRow);
                        myManageDB.DeleteDB("ProjectManager", "proNO", myCurrentProNo);
                        this.updateCellClick();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
