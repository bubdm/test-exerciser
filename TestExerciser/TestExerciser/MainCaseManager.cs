using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestExerciser.Tools.CaseManagement;
using TestExerciser.Logic;
using System.Text.RegularExpressions;
using TestExerciser.Tools;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TestExerciser
{ 

    public partial class MainCaseManager : Form
    {
        RegexInfo myRegexInfo = new RegexInfo();
        ManageDB myManageDB = new ManageDB();
        public static string myCaseNo;
        DataTable myDTCase = new DataTable();
        int pagePTR = 0;//设置Page标志位
        string[] myRows; //数据表中CaseNo字段
        

        public MainCaseManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.dgvCaseManager.DataSource != null)
            {
                this.dgvCaseManager.DataSource = null;
            }
            myRows = this.queryRows();
            myDTCase.Rows.Clear();
            if (myRows != null)
            {
                dgvPager_OnPageChanged(sender, e);
                this.updateAfterQuery();
                this.dataGridViewSeletedItem();
            }
        }

        private string [][,] getNotNullQueryItems()
        {
            string[][,] queryNotNullItems = null;
            List<string[,]> queryNotNullItemsList = new List<string[,]>();
            string[,] queryItems = 
                { 
                    { "ceProject", this.tbQueryProject.Text }, 
                    { "ceStruct", this.cbQueryStruct.Text }, 
                    { "ceCaseNO", this.tbQueryCaseNO.Text }, 
                    { "ceSuiteNO", this.tbQuerySuiteNO.Text }, 
                    { "ceCaseLevel", this.cbQueryCaseLevel.Text }, 
                    { "ceModifier", this.cbQueryModify.Text }, 
                    { "ceAuthor", myRegexInfo.getMatchedChineseStr(this.cbQueryCaseAuthor.Text) }, 
                    { "ceIfAuto", this.cbQueryIfAuto.Text } 
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
            return queryNotNullItems ;
        }

        private string getQuerySQLString()
        {           
            string str = "select ceCaseNO from CaseManager ";
            string[][,] queryArray = getNotNullQueryItems();
           

            if (queryArray.Length!=0)
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
                        if (i != queryArray.Length-1)
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
                    string sqlTimeValue = string.Format(" AND ceEditDate >='{0}' AND ceEditDate<='{1}'", this.dtpTimeBegin.Value.ToShortDateString(), this.dtpTimeEnd.Value.ToShortDateString());
                    str = str + sqlTimeValue;
                }
            }
            return str;
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

        private const int ROW_HEIGHT = 70;

        private void setDataGridViewColumnHeaders()
        {           
            myDTCase.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("用例"),
                    new DataColumn("作者"),
                    new DataColumn("创建日期"),
                    new DataColumn("用例名称")
                });
            dgvCaseManager.ColumnCount = myDTCase.Columns.Count;
            for (int i = 0; i < dgvCaseManager.ColumnCount; i++)
            {
                dgvCaseManager.Columns[i].Name = myDTCase.Columns[i].ColumnName;
                dgvCaseManager.Columns[i].DataPropertyName = myDTCase.Columns[i].ColumnName;
                dgvCaseManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvCaseManager.Columns[i].Width = 120;
                else
                    dgvCaseManager.Columns[i].Width = 150;
            }
        }

        private void setDataGridViewControl(int pageIndex, int pageSize)
        {
            pagePTR = pageSize *(pageIndex-1);
            if (myRows != null)
            {
                myDTCase.Rows.Clear();
                for (int i = 0; i < dgvPager.PageSize; i++)
                {   
                    string myNO = myRows[pagePTR];
                    DataRow row = myDTCase.NewRow();
                    row[0] = myNO;
                    row[1] = myManageDB.getDataFromCell("ceAuthor", "CaseManager", "ceCaseNO", myNO);
                    row[2] = myManageDB.getDataFromCell("ceEditDate", "CaseManager", "ceCaseNO", myNO).Split(' ')[0];
                    row[3] = myManageDB.getDataFromCell("ceCaseName", "CaseManager", "ceCaseNO", myNO);
                    myDTCase.Rows.Add(row);
                    pagePTR++;
                    if (pagePTR >= this.dgvPager.RecordCount)
                    {
                        break;
                    }
                }     
                
                //用户不能调整列标题高度
                dgvCaseManager.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dgvCaseManager.RowHeadersVisible = false;
                //设置行高
                dgvCaseManager.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dgvCaseManager.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvCaseManager.AllowUserToAddRows = false;
                dgvCaseManager.AllowUserToDeleteRows = false;
                dgvCaseManager.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvCaseManager.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvCaseManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCaseManager.MultiSelect = false;
                dgvCaseManager.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvCaseManager.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvCaseManager.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvCaseManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCaseManager.DataSource = myDTCase;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRender render = new DataGridViewRender(dgvCaseManager,
                    dgvCaseManager.Columns[dgvCaseManager.ColumnCount - 1]);
            }          
        }

        private void showTestCaseDetails(string tcNO)
        {
            try
            {
                this.labTCNOValue.Text = myManageDB.getDataFromCell("ceCaseNO", "CaseManager", "ceCaseNO", tcNO) + "  ";
                this.txtProject.Text = myManageDB.getDataFromCell("ceProject", "CaseManager", "ceCaseNO", tcNO);
                this.txtIfAuto.Text = myManageDB.getDataFromCell("ceIfAuto", "CaseManager", "ceCaseNO", tcNO);
                this.txtSuiteNO.Text = myManageDB.getDataFromCell("ceSuiteNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtSuiteName.Text = myManageDB.getDataFromCell("ceSuiteName", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseNO.Text = myManageDB.getDataFromCell("ceCaseNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseName.Text = myManageDB.getDataFromCell("ceCaseName", "CaseManager", "ceCaseNO", tcNO);
                this.txtReqNO.Text = myManageDB.getDataFromCell("ceReqNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseLevel.Text = myManageDB.getDataFromCell("ceCaseLevel", "CaseManager", "ceCaseNO", tcNO);          
                this.txtAuthor.Text = myManageDB.getDataFromCell("ceAuthor", "CaseManager", "ceCaseNO", tcNO);
                this.txtEditTime.Text = myManageDB.getDataFromCell("ceEditDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("ceModifier", "CaseManager", "ceCaseNO", tcNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("ceModifyDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.rtbPrecondition.Text = myManageDB.getDataFromCell("cePrecondition", "CaseManager", "ceCaseNO", tcNO);
                this.rtbSteps.Text = myManageDB.getDataFromCell("ceSteps", "CaseManager", "ceCaseNO", tcNO);
                this.rtbSamples.Text = myManageDB.getDataFromCell("ceSamples", "CaseManager", "ceCaseNO", tcNO);
                this.rtbExcept.Text = myManageDB.getDataFromCell("ceExcept", "CaseManager", "ceCaseNO", tcNO);
            }            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }   

        private void dgvCaseManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvCaseManager.Rows.Count != 0)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        DataGridViewCell cell = (DataGridViewCell)dgvCaseManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string tcNO = dgvCaseManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        showTestCaseDetails(tcNO);
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
            myCaseNo = this.txtCaseNO.Text;
            this.Visible = false;
            this.Close();
            ToolCaseModify myToolCaseModifyBase = new ToolCaseModify();
            myToolCaseModifyBase.Show();
            
        }

        private void MainCaseManager_Load(object sender, EventArgs e)
        {
            myRows = myManageDB.getDataFromCells("ceCaseNO", "CaseManager");
            this.dgvPager.PageSize = 15;//设置每页默认显示记录数
            this.tbcCaseDesign.SelectedIndex = 0;
            //激活OnPageChanged事件
            this.dgvPager.OnPageChanged += new EventHandler(dgvPager_OnPageChanged);
            dgvPager_OnPageChanged(sender, e);
            this.updateAfterQuery();
            this.dataGridViewSeletedItem();
            
        }

        private void updateAfterQuery()
        {
            this.dgvCaseManager_CellClick(this.dgvCaseManager, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridViewSeletedItem()
        {
            if (this.dgvCaseManager.Rows.Count != 0)
            {
                this.dgvCaseManager.CurrentCell = this.dgvCaseManager.Rows[0].Cells[0];
            }      
        }

        private void btnInto_Click(object sender, EventArgs e)
        {
            ToolCaseImport myToolCaseImportBase = new ToolCaseImport();
            myToolCaseImportBase.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.tbQueryProject.Text = "";
            this.cbQueryStruct.Text = "";
            this.tbQueryCaseNO.Text = "";
            this.tbQuerySuiteNO.Text = "";
            this.cbQueryModify.Text = "";
            this.cbQueryCaseAuthor.Text = "";
            this.cbQueryCaseLevel.Text = "";
            this.cbQueryIfAuto.Text = "";
            //this.dtpTimeBegin.ResetText();
            //this.dtpTimeEnd.ResetText();
            if (this.dgvCaseManager.DataSource != null)
            {
                this.dgvCaseManager.DataSource = null;
            }
            myDTCase.Rows.Clear();
            MainCaseManager_Load(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolCaseNew myToolCaseCommitBase = new ToolCaseNew();
            myToolCaseCommitBase.Show();
        }

        private void cbQueryCaseAuthor_DropDown(object sender, EventArgs e)
        {
            this.cbQueryCaseAuthor.Items.Clear();
            myManageDB.selectItems(this.cbQueryCaseAuthor, "UserManager");
        }

        private void dgvPager_OnPageChanged(object sender, EventArgs e)
        {
            this.LoadData(myRows);
        }

        /// <summary>
        /// 重新加载数据
        /// </summary>
        private void LoadData(string [] myRows)
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
            this.tbQueryProject.Text = ToolSelectProject.seletedProjectName;
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
                this.cbQueryStruct.Items.Clear();
                myLoadXml.loadXmlToComBox(xmlDoc.DocumentElement, this.cbQueryStruct);
            }
        }

        private void d_SetProjectVersion()
        {
            
        }

        private void cbQueryModify_DropDown(object sender, EventArgs e)
        {
            this.cbQueryModify.Items.Clear();
            myManageDB.selectItems(this.cbQueryModify, "UserManager");
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DesignTE.Controller.MainCtrl mainCtrl = new DesignTE.Controller.MainCtrl();
            ToolCaseDesign myToolCaseDesign = new ToolCaseDesign(mainCtrl);
            mainCtrl.InitMindMate(myToolCaseDesign);
            var ribbonHandler = new DesignTE.View.Ribbon.Ribbon(myToolCaseDesign.Ribbon, mainCtrl, myToolCaseDesign);
            myToolCaseDesign.RibbonCtrl = ribbonHandler;
            ribbonHandler.OnRibbonLoaded();
            myToolCaseDesign.Show();
        }
    }
}
