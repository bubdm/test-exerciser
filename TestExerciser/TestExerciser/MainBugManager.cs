using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TestExerciser.Tools.BugManagement;
using TestExerciser.Logic;
using TestExerciser.Tools;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace TestExerciser
{
    public partial class MainBugManager : Form
    {
        RegexInfo myRegexInfo = new RegexInfo();
        ManageDB myManageDB = new ManageDB();
        public static string myCurrentBugNo;
        DataTable myDTBug = new DataTable();
        DataGridViewRow currentRow; //当前选中行
        string currentFileId; //当前附件Id
        string dateTimeNow = DateTime.Now.ToString();
        string userName = ManageDB.userName + "(" + ManageDB.userEmailAddress + ")";
        int pagePTR = 0;//设置Page标志位
        string[] myRows; //数据表中CaseNo字段
        int pageSize = 15; //设置每页默认显示记录数        

        string bugTitle = "";
        string bugID = "";
        string bugAttribution = "";
        string bugCategory = "";
        string bugHowFound = "";
        string bugOccurrence = "";
        string bugGravity = "";
        string bugPriority = "";
        string bugFoundVersion = "";
        string bugFoundStruct = "";
        string bugAuthor = "";
        string bugEditDate = "";
        string bugModify = "";
        string bugModifyDate = "";
        string bugReproSteps = "";
        string bugSamples = "";
        string bugExcept = "";
        string bugActually = "";
        string bugRootCause = "";
        string bugAdvice = "";
        string bugRegAdvice = "";
        string bugVerify = "";
        string bugVerifyDate = "";
        string bugPlanVersion = "";
        string bugRealVersion = "";
        string bugClosedDate = "";
        string bugNotes = "";
        string bugAudit = "";
        string bugOpinion = "";
        string bugExceptDate = "";
        string bugPlanDate = "";
        string bugRealDate = "";


        static string bugStatus_CreateReview = "创建审核";
        static string bugStatus_NonApproval = "创建审核不通过";
        static string bugStatus_Modifying = "修改中";
        static string bugStatus_Regression = "回归测试中";
        static string bugStatus_Close = "关闭";
        static string bugStatus_HungUp = "挂起";

        string[] gravityItems = {
            "致命",
            "严重",
            "一般",
            "提示"};

        string[] occurrenceItems = {
            "稳定复现",
            "概率复现"};

        string[] priorityItems ={
            "高",
            "中",
            "低"};

        string[] howFoundItems = {
            "技术评审",
            "功能测试",
            "性能测试",
            "验收测试",
            "可靠性测试",
            "单元测试",
            "集成测试",
            "代码检查",
            "客户反馈",
            "自动化测试"};

        string[] cateGoryItems = {
            "功能类",
            "接口类 ",
            "逻辑类",
            "数据类",
            "其他"};

        public MainBugManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ToolBugNew myToolBugNew = new ToolBugNew();
            myToolBugNew.FormClosed += subForm_FormClosed;
            myToolBugNew.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.dgvBugManager.DataSource != null)
            {
                this.dgvBugManager.DataSource = null;
            }
            myRows = this.queryRows();
            myDTBug.Rows.Clear();
            if (myRows != null)
            {
                dgvPager_OnPageChanged(sender, e);
                this.updateCellClick();
                this.dataGridViewSeletedItem();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.tbQueryBugID.Text = "";
            this.tbQueryBugTitle.Text = "";
            this.tbQueryAttribution.Text = "";
            this.cbQueryStruct.Text = "";
            this.cbQueryVersion.Text = "";
            this.cbQueryPriority.Text = "";
            this.cbQueryOccurrence.Text = "";
            this.cbQueryHowFound.Text = "";
            this.cbQueryGravity.Text = "";
            //this.dtpTimeBegin.ResetText();
            //this.dtpTimeEnd.ResetText();
            if (this.dgvBugManager.DataSource != null)
            {
                this.dgvBugManager.DataSource = null;
            }
            myDTBug.Rows.Clear();
            MainBugManager_Load(sender, e);
        }

        private void dgvBugManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.preLoadDataGridView();
            try
            {
                if (this.dgvBugManager.Rows.Count != 0)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        DataGridViewCell cell = (DataGridViewCell)dgvBugManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        myCurrentBugNo = dgvBugManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        currentRow = this.dgvBugManager.Rows[e.RowIndex];
                        showTestCaseDetails(myCurrentBugNo);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preLoadDataGridView()
        {
            this.tbcBugDesign.TabPages.Remove(this.tpRegressionTure);
            this.tbcBugDesign.TabPages.Remove(this.tpRegressionFalse);
            this.tbcBugDesign.TabPages.Remove(this.tpReject);
            this.tbcBugDesign.TabPages.Remove(this.tpClose);
            this.tbcBugDesign.TabPages.Remove(this.tpHangUp);
            this.tbcBugDesign.TabPages.Remove(this.tpToBeModify);
            this.tbcBugDesign.TabPages.Remove(this.tpToBeAudit);
            this.tbcBugDesign.TabPages.Remove(this.tpSubmit);
            this.tbcBugDesign.TabPages.Remove(this.tpReOpen);
            this.tbcBugDesign.TabPages.Remove(this.tpSubTest);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void MainBugManager_Load(object sender, EventArgs e)
        {           
            this.dgvPager.PageSize = pageSize;
            //激活OnPageChanged事件
            this.dgvPager.OnPageChanged += new EventHandler(dgvPager_OnPageChanged);
            dgvPager_OnPageChanged(sender, e);
            this.updateCellClick();
            this.dataGridViewSeletedItem();
            this.lvBugAttachment_SizeChanged(sender, e);
        }

        private void setDataGridViewColumnHeaders()
        {
            myDTBug.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("产品缺陷"),
                    new DataColumn("缺陷状态"),
                    new DataColumn("[责任人]"),
                    new DataColumn("最近更新时间"),
                    new DataColumn("缺陷编号")
                });
            dgvBugManager.ColumnCount = myDTBug.Columns.Count;
            for (int i = 0; i < dgvBugManager.ColumnCount; i++)
            {
                dgvBugManager.Columns[i].Name = myDTBug.Columns[i].ColumnName;
                dgvBugManager.Columns[i].DataPropertyName = myDTBug.Columns[i].ColumnName;
                dgvBugManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvBugManager.Columns[i].Width = 120;
                else
                    dgvBugManager.Columns[i].Width = 150;
            }
        }

        private string[][,] getNotNullQueryItems()
        {
            string[][,] queryNotNullItems = null;
            List<string[,]> queryNotNullItemsList = new List<string[,]>();
            string[,] queryItems =
                {
                    { "bugID", this.tbQueryBugID.Text },
                    { "bugTitle", this.tbQueryBugTitle.Text },
                    { "bugAttribution", this.tbQueryAttribution.Text },
                    { "bugFoundStruct", this.cbQueryStruct.Text },
                    { "bugFoundVersion", this.cbQueryVersion.Text },
                    { "bugGravity", this.cbQueryGravity.Text },
                    { "bugOccurrence", this.cbQueryOccurrence.Text },
                    { "bugHowFound", this.cbQueryHowFound.Text },
                    { "bugPriority", this.cbQueryPriority.Text },
                    { "bugAuthor", myRegexInfo.getMatchedChineseStr(this.cbQueryBugAuthor.Text) },
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

        private string getQuerySQLString()
        {
            string str = "select bugID from BugManager ";
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
                    string sqlTimeValue = string.Format(" AND bugEditDate >='{0}' AND bugEditDate<='{1}'", this.dtpTimeBegin.Value.ToShortDateString(), this.dtpTimeEnd.Value.ToShortDateString());
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

        private void setDataGridViewControl(int pageIndex, int pageSize)
        {
            pagePTR = pageSize * (pageIndex - 1);
            if (myRows != null)
            {
                myDTBug.Rows.Clear();
                for (int i = 0; i < dgvPager.PageSize; i++)
                {
                    string myNO = myRows[pagePTR];
                    DataRow row = myDTBug.NewRow();
                    row[0] = myNO;
                    row[1] = myManageDB.getDataFromCell("bugStatus", "BugManager", "bugID", myNO);
                    row[2] = myManageDB.getDataFromCell("bugAuditor", "BugManager", "bugID", myNO);
                    row[3] = myManageDB.getDataFromCell("bugUpdateDate", "BugManager", "bugID", myNO).Split(' ')[0];
                    row[4] = myManageDB.getDataFromCell("bugAuthor", "BugManager", "bugID", myNO) + "      " + myManageDB.getDataFromCell("bugEditDate", "BugManager", "bugID", myNO).Split(' ')[0];
                    myDTBug.Rows.Add(row);
                    pagePTR++;
                    if (pagePTR >= this.dgvPager.RecordCount)
                    {
                        break;
                    }
                }

                //用户不能调整列标题高度
                dgvBugManager.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dgvBugManager.RowHeadersVisible = false;
                //设置行高
                dgvBugManager.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dgvBugManager.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvBugManager.AllowUserToAddRows = false;
                dgvBugManager.AllowUserToDeleteRows = false;
                dgvBugManager.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvBugManager.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvBugManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBugManager.MultiSelect = false;
                dgvBugManager.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvBugManager.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvBugManager.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvBugManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBugManager.DataSource = myDTBug;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRender render = new DataGridViewRender(dgvBugManager,
                    dgvBugManager.Columns[dgvBugManager.ColumnCount - 1]);
            }
        }

        private void showTestCaseDetails(string bugNO)
        {
            try
            {
                string bugAuthor = myManageDB.getDataFromCell("bugAuthor", "BugManager", "bugID", myCurrentBugNo);
                if (userName != bugAuthor)
                {
                    this.bugBaseInfoToolStripWhenUserNotMatch();
                }
                else
                {
                    switch (myManageDB.getDataFromCell("bugStatus", "BugManager", "bugID", bugNO))
                    {
                        case "初始化":
                            this.bugBaseInfoToolStripWhenStatusInit();
                            break;
                        case "创建审核":
                            this.bugBaseInfoToolStripWhenStatusToBeAudit();
                            break;
                        case "创建审核不通过":
                            this.bugBaseInfoToolStripWhenStatusAuditFlase();
                            break;
                        case "修改中":
                            this.bugBaseInfoToolStripWhenStatusModify();
                            break;
                        case "回归测试中":
                            this.bugBaseInfoToolStripWhenStatusRegeression();
                            break;
                        case "关闭":
                            this.bugBaseInfoToolStripWhenStatusClosed();
                            break;
                        case "挂起":
                            this.bugBaseInfoToolStripWhenStatusHangUp();
                            break;
                    }
                }
                bugTitle = myManageDB.getDataFromCell("bugTitle", "BugManager", "bugID", bugNO) + "  ";
                bugID = myManageDB.getDataFromCell("bugID", "BugManager", "bugID", bugNO);
                bugAttribution = myManageDB.getDataFromCell("bugAttribution", "BugManager", "bugID", bugNO);
                bugCategory = myManageDB.getDataFromCell("bugCategory", "BugManager", "bugID", bugNO);
                bugHowFound = myManageDB.getDataFromCell("bugHowFound", "BugManager", "bugID", bugNO);
                bugOccurrence = myManageDB.getDataFromCell("bugOccurrence", "BugManager", "bugID", bugNO);
                bugGravity = myManageDB.getDataFromCell("bugGravity", "BugManager", "bugID", bugNO);
                bugPriority = myManageDB.getDataFromCell("bugPriority", "BugManager", "bugID", bugNO);
                bugFoundVersion = myManageDB.getDataFromCell("bugFoundVersion", "BugManager", "bugID", bugNO);
                bugFoundStruct = myManageDB.getDataFromCell("bugFoundStruct", "BugManager", "bugID", bugNO);
                bugExceptDate = myManageDB.getDataFromCell("bugExceptDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugRealDate = myManageDB.getDataFromCell("bugRealDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugPlanDate = myManageDB.getDataFromCell("bugPlanDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugAuthor = myManageDB.getDataFromCell("bugAuthor", "BugManager", "bugID", bugNO);
                bugEditDate = myManageDB.getDataFromCell("bugEditDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugModify = myManageDB.getDataFromCell("bugModify", "BugManager", "bugID", bugNO);
                bugModifyDate = myManageDB.getDataFromCell("bugModifyDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugReproSteps = myManageDB.getDataFromCell("bugReproSteps", "BugManager", "bugID", bugNO);
                bugSamples = myManageDB.getDataFromCell("bugSamples", "BugManager", "bugID", bugNO);
                bugExcept = myManageDB.getDataFromCell("bugExcept", "BugManager", "bugID", bugNO);
                bugActually = myManageDB.getDataFromCell("bugActually", "BugManager", "bugID", bugNO);
                bugRootCause = myManageDB.getDataFromCell("bugRootCause", "BugManager", "bugID", bugNO);
                bugAdvice = myManageDB.getDataFromCell("bugAdvice", "BugManager", "bugID", bugNO);
                bugVerify = myManageDB.getDataFromCell("bugVerify", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugVerifyDate = myManageDB.getDataFromCell("bugVerifyDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugPlanVersion = myManageDB.getDataFromCell("bugPlanVersion", "BugManager", "bugID", bugNO);
                bugRealVersion = myManageDB.getDataFromCell("bugRealVersion", "BugManager", "bugID", bugNO);
                bugClosedDate = myManageDB.getDataFromCell("bugClosedDate", "BugManager", "bugID", bugNO).Split(' ')[0];
                bugAudit = myManageDB.getDataFromCell("bugAuditor", "BugManager", "bugID", bugNO);
                bugOpinion = myManageDB.getDataFromCell("bugOpinion", "BugManager", "bugID", bugNO);



                this.labBugNameValue.Text = bugTitle;
                this.txtBugID.Text = bugID;
                this.txtAttribution.Text = bugAttribution;
                this.txtCategory.Text = bugCategory;
                this.txtHowFound.Text = bugHowFound;
                this.txtOccurrence.Text = bugOccurrence;
                this.txtGravity.Text = bugGravity;
                this.txtPriority.Text = bugPriority;
                this.txtFoundVersion.Text = bugFoundVersion;
                this.txtFonudStruct.Text = bugFoundStruct;
                this.txtExceptDate.Text = bugExceptDate;
                this.txtAuthor.Text = bugAuthor;
                this.txtEditTime.Text = bugEditDate;
                this.rtbReproSteps.Text = bugReproSteps;
                this.rtbSamples.Text = bugSamples;
                this.rtbExcept.Text = bugExcept;
                this.rtbActually.Text = bugActually;
                this.rtbRootCause.Text = bugRootCause;
                this.rtbAdvice.Text = bugAdvice;

                this.txtAdInfoVerify.Text = bugVerify;
                this.txtAdInfoVerifyDate.Text = bugVerifyDate;
                this.txtAdInfoClosedDate.Text = bugClosedDate;
                this.txtAdInfoAuthor.Text = bugAuthor;
                this.txtAdInfoEditorDate.Text = bugEditDate;
                this.txtAdInfoHowFound.Text = bugHowFound;
                this.txtAdInfoSolve.Text = bugAudit;
                this.txtAdInfoModify.Text = bugModify;
                this.txtAdInfoModifyDate.Text = bugModifyDate;

                this.txtAdInfoPlanVersion.Text = bugPlanVersion;
                this.txtAdInfoRealVersion.Text = bugRealVersion;
                this.txtAdInfoVersion.Text = bugFoundVersion;

                this.txtAdInfoSolveExpDate.Text = bugExceptDate;
                this.txtAdInfoSolvePlanDate.Text = bugPlanDate;
                this.txtAdInfoSolveRealDate.Text = bugRealDate;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCellClick()
        {
            this.dgvBugManager_CellClick(this.dgvBugManager, new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridViewSeletedItem()
        {
            if (this.dgvBugManager.Rows.Count != 0)
            {
                this.dgvBugManager.CurrentCell = this.dgvBugManager.Rows[0].Cells[0];
            }
        }

        private void cbQueryBugAuthor_DropDown(object sender, EventArgs e)
        {
            this.cbQueryBugAuthor.Items.Clear();
            myManageDB.selectItems(this.cbQueryBugAuthor, "UserManager");
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
            this.tbQueryAttribution.Text = ToolSelectProject.seletedProjectName;
        }

        private void d_SetProjectStruct()
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            this.loadXmlContent(this.cbQueryStruct, xmlContent);
        }

        private void d_SetProjectVersion()
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            this.loadXmlContent(this.cbQueryVersion, xmlContent);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该缺陷吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (currentRow != null)
                {
                    try
                    {
                        this.dgvBugManager.Rows.Remove(currentRow);
                        myManageDB.DeleteDB("BugManager", "bugID", bugID);
                        this.updateCellClick();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPager_OnPageChanged(object sender, EventArgs e)
        {           
            this.LoadData();
        }

        /// <summary>
        /// 重新加载数据
        /// </summary>
        private void LoadData()
        {
            myRows = myManageDB.getDataFromCells("bugID", "BugManager");
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

        private void bugBaseInfoToolStripWhenUserNotMatch()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }
        private void bugBaseInfoToolStripWhenStatusInit()
        {
            this.tsbBaseEditor.Visible = true;
            this.tsbBaseSubmit.Visible = true;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }

        private void bugBaseInfoToolStripWhenStatusToBeAudit()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = true;
            this.tsbBaseClose.Visible = true;
            this.tsbBaseHangUp.Visible = true;
            this.tsbBaseToBeModify.Visible = true;
            this.tsbBaseTurnAudit.Visible = true;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }
        private void bugBaseInfoToolStripWhenStatusAuditFlase()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = true;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }
        private void bugBaseInfoToolStripWhenStatusModify()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = true;
            this.tsbBaseRecover.Visible = false;
        }
        private void bugBaseInfoToolStripWhenStatusRegeression()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = true;
            this.tsbBaseRegressionTrue.Visible = true;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }

        private void bugBaseInfoToolStripWhenStatusClosed()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = true;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
        }

        private void bugBaseInfoToolStripWhenStatusHangUp()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = true;
        }

        private void bugBaseInfoToolStripNotAboutMe()
        {
            this.tsbBaseEditor.Visible = false;
            this.tsbBaseSubmit.Visible = false;
            this.tsbBaseRegressionFlase.Visible = false;
            this.tsbBaseRegressionTrue.Visible = false;
            this.tsbBaseReOpen.Visible = false;
            this.tsbBaseReject.Visible = false;
            this.tsbBaseClose.Visible = false;
            this.tsbBaseHangUp.Visible = false;
            this.tsbBaseToBeModify.Visible = false;
            this.tsbBaseTurnAudit.Visible = false;
            this.tsbBaseSubTest.Visible = false;
            this.tsbBaseRecover.Visible = false;
            this.tsbBaseSubTest.Visible = false;
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 转发ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbBaseSubmit_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpSubmit);
            this.tbcBugDesign.SelectedIndex = 0;

            this.cbSubmitAuthor.Text = bugAuthor;
            this.txtSubmitBugID.Text = bugID;
            this.cbSubmitCategory.Text = bugCategory;
            this.dtpSubmitEditDate.Text = bugEditDate;
            this.dtpSubmitExpDate.Text = bugExceptDate;
            this.cbSubmitGravity.Text = bugGravity;
            this.cbSubmitHowFound.Text = bugHowFound;
            this.cbSubmitOccurrence.Text = bugOccurrence;

            this.cbSubmitPriority.Text = bugPriority;
            this.txtSubmitAttribution.Text = bugAttribution;
            this.txtSubmitAdvice.Text = bugAdvice;
            this.cbSubmitStruct.Text = bugFoundStruct;
            this.cbSubmitVersion.Text = bugFoundVersion;
        }

        private void tsbBaseReject_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpReject);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtRejectAudit.Text = ManageDB.userName;
            this.txtRejectAuditDate.Text = dateTimeNow;
            this.txtRejectAuthor.Text = bugAuthor;
            this.txtRejectBugID.Text = bugID;
            this.txtRejectCategory.Text = bugCategory;
            this.txtRejectEditDate.Text = bugEditDate;
            this.txtRejectExpDate.Text = bugExceptDate;
            this.txtRejectGravity.Text = bugGravity;
            this.txtRejectHowFound.Text = bugHowFound;
            this.txtRejectOpinion.Text = bugNotes;
            this.txtRejectOccurrence.Text = bugOccurrence;
            this.txtRejectPriority.Text = bugPriority;
            this.txtRejectAttribution.Text = bugAttribution;
            this.txtRejectAdvice.Text = bugAdvice;
            this.txtRejectStruct.Text = bugFoundStruct;
            this.txtRejectVersion.Text = bugFoundVersion;
        }

        private void tsbBaseClose_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpClose);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtClosedDate.Text = dateTimeNow;
            this.txtCloseAuthor.Text = bugAuthor;
            this.txtCloseBugID.Text = bugID;
            this.txtCloseEditDate.Text = bugEditDate;
            this.txtCloseExpDate.Text = bugExceptDate;
            this.txtCloseNote.Text = bugNotes;
            this.txtCloseProName.Text = bugAttribution;
            this.txtCloseAdvice.Text = bugRootCause;
            this.cbCloseCategory.Text = bugCategory;
            this.cbCloseGravity.Text = bugGravity;
            this.cbCloseHowFound.Text = bugHowFound;
            this.cbCloseOccurrence.Text = bugOccurrence;
            this.cbClosePriority.Text = bugPriority;
            this.cbCloseStruct.Text = bugFoundStruct;
            this.cbCloseVersion.Text = bugFoundVersion;
        }

        private void tsbBaseHangUp_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpHangUp);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtHugAuthor.Text = bugAuthor;
            this.txtHugBugID.Text = bugID;
            this.txtHugCategory.Text = bugCategory;
            this.txtHugEditDate.Text = bugEditDate;
            this.txtHugExpDate.Text = bugExceptDate;
            this.txtHugGravity.Text = bugGravity;
            this.txtHugHowFound.Text = bugHowFound;
            this.txtHugNote.Text = bugNotes;
            this.txtHugOccurrence.Text = bugOccurrence;
            this.txtHugPriority.Text = bugPriority;
            this.txtHugAttribution.Text = bugAttribution;
            this.txtHugAdvice.Text = bugRootCause;
            this.txtHugStruct.Text = bugFoundStruct;
            this.txtHugVersion.Text = bugFoundVersion;

        }

        private void tsbBaseToBeModify_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpToBeModify);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtModifyAuthor.Text = bugAuthor;
            this.txtModifyBugID.Text = bugID;
            this.cbModifyCategory.Text = bugCategory;
            this.txtModifyEditDate.Text = bugEditDate;
            this.dtpModifyExpDate.Text = bugExceptDate;
            this.cbModifyGravity.Text = bugGravity;
            this.cbModifyHowFound.Text = bugHowFound;
            this.txtModifyNote.Text = bugNotes;
            this.cbModifyOccurrence.Text = bugOccurrence;
            this.cbModifyPriority.Text = bugPriority;
            this.txtModifyProName.Text = bugAttribution;
            this.txtModifyAdvice.Text = bugAdvice;
            this.cbModifyStruct.Text = bugFoundStruct;
            this.cbModifyVersion.Text = bugFoundVersion;
        }

        private void tsbBaseTurnAudit_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpToBeAudit);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtAuditAuthor.Text = bugAuthor;
            this.txtAuditBugID.Text = bugID;
            this.txtAuditCategory.Text = bugCategory;
            this.txtAuditEditDate.Text = bugEditDate;
            this.txtAuditExpDate.Text = bugExceptDate;
            this.txtAuditGravity.Text = bugGravity;
            this.txtAuditHowFound.Text = bugHowFound;
            this.txtAuditNote.Text = bugNotes;
            this.txtAuditOccurrence.Text = bugOccurrence;
            this.txtAuditPriority.Text = bugPriority;
            this.txtAuditAttribution.Text = bugAttribution;
            this.txtAuditAdvice.Text = bugRootCause;
            this.txtAuditStruct.Text = bugFoundStruct;
            this.txtAuditVersion.Text = bugFoundVersion;
        }

        private void tsbBaseSubTest_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpSubTest);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtSubTestAuthor.Text = bugAuthor;
            this.txtSubTestBugID.Text = bugID;
            this.txtSubTestCategory.Text = bugCategory;
            this.txtSubTestEditDate.Text = bugEditDate;
            this.txtSubTestExpDate.Text = bugExceptDate;
            this.txtSubTestGravity.Text = bugGravity;
            this.txtSubTestHowFound.Text = bugHowFound;
            this.txtSubTestOccurrence.Text = bugOccurrence;
            this.txtSubTestPriority.Text = bugPriority;
            this.txtSubTestAttribution.Text = bugAttribution;
            this.txtSubTestAdvice.Text = bugAdvice;
            this.txtSubTestStruct.Text = bugFoundStruct;
            this.txtSubTestVersion.Text = bugFoundVersion;
            this.dtpSubTestActualDate.Text = dateTimeNow;

            this.txtSubTestPlanDate.Text = bugPlanDate;
            this.txtSubTestPlanVersion.Text = bugPlanVersion;
        }

        private void tsbBaseRecover_Click(object sender, EventArgs e)
        {
            myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_CreateReview, "bugID", myCurrentBugNo);
            if (this.dgvBugManager.DataSource != null)
            {
                this.dgvBugManager.DataSource = null;
            }
            myDTBug.Rows.Clear();
            MainBugManager_Load(sender, e);
        }

        private void tsbBaseEditor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ToolBugModify myToolBugModify = new ToolBugModify();
            myToolBugModify.FormClosed += subForm_FormClosed;
            myToolBugModify.Show();
        }

        private void tsbBaseRegressionTrue_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpRegressionTure);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtRegTrueAuthor.Text = bugAuthor;
            this.txtRegTrueBugID.Text = bugID;
            this.txtRegTrueCategory.Text = bugCategory;
            this.txtRegTrueEditDate.Text = bugEditDate;
            this.txtRegTrueExpDate.Text = bugExceptDate;
            this.txtRegTrueGravity.Text = bugGravity;
            this.txtRegTrueHowFound.Text = bugHowFound;
            this.txtRegTrueOccurrence.Text = bugOccurrence;
            this.txtRegTruePriority.Text = bugPriority;
            this.txtRegTrueAttribution.Text = bugAttribution;
            this.txtRegTrueAdvice.Text = bugAdvice;
            this.txtRegTrueStruct.Text = bugFoundStruct;
            this.txtRegTrueVersion.Text = bugFoundVersion;

            this.txtRegTrueAdvice.Text = bugAdvice;
            this.txtRegTrueRootCause.Text = bugRootCause;
            this.txtRegTrueRegAdvice.Text = bugRegAdvice;

            this.txtRegTrueClosedDate.Text = dateTimeNow;
            this.txtRegTrueVerifyDate.Text = dateTimeNow;
            this.txtRegTrueAudit.Text = userName;
        }

        private void tsbBaseRegressionFlase_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpRegressionFalse);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtRegFalseAuthor.Text = bugAuthor;
            this.txtRegFalseBugID.Text = bugID;
            this.txtRegFalseCategory.Text = bugCategory;
            this.txtRegFalseEditDate.Text = bugEditDate;
            this.txtRegFalseExpDate.Text = bugExceptDate;
            this.txtRegFalseGravity.Text = bugGravity;
            this.txtRegFalseHowFound.Text = bugHowFound;
            this.txtRegFalseOccurrence.Text = bugOccurrence;
            this.txtRegFalsePriority.Text = bugPriority;
            this.txtRegFalseAttribution.Text = bugAttribution;
            this.txtRegFalseAdvice.Text = bugAdvice;
            this.txtRegFalseStruct.Text = bugFoundStruct;
            this.txtRegFalseVersion.Text = bugFoundVersion;
            this.txtRegFalseNote.Text = bugNotes;

        }

        private void tsbBaseReOpen_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Insert(0, this.tpReOpen);
            this.tbcBugDesign.SelectedIndex = 0;

            this.txtReOpenBugTitle.Text = bugTitle;
            this.txtReOpenAttribution.Text = bugAttribution;
            this.txtReOpenAdvice.Text = bugAdvice;
            this.txtReOpenBugID.Text = bugID;
            this.cbReOpenAudit.Text = bugAudit;
            this.cbReOpenAuthor.Text = bugAuthor;
            this.cbReOpenCategory.Text = bugCategory;
            this.cbReOpenGravity.Text = bugGravity;
            this.cbReOpenHowFound.Text = bugHowFound;
            this.cbReOpenOccurrence.Text = bugOccurrence;
            this.cbReOpenPriority.Text = bugPriority;
            this.cbReOpenStruct.Text = bugFoundStruct;
            this.cbReOpenVersion.Text = bugFoundVersion;


            //myManageDB.UpdateDB("BugManager", "bugStatus", "创建审核", "bugID", myCurrentBugNo);
            //if (this.dgvBugManager.DataSource != null)
            //{
            //    this.dgvBugManager.DataSource = null;
            //}
            //myDTBug.Rows.Clear();
            //MainBugManager_Load(sender, e);
        }

        private void tsbSubmitCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpSubmit);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbRegTrueCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpRegressionTure);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbRejectCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpReject);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbCloseCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpClose);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbHugCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpHangUp);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbModifyCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpToBeModify);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbAuditCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpToBeAudit);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbRegrFalseCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpRegressionFalse);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbReOpenCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpReOpen);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbSubmitOK_Click(object sender, EventArgs e)
        {
            if (this.cbSubmitAudit.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugAttribution", txtSubmitAttribution.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugCategory", cbSubmitCategory.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugHowFound", cbSubmitHowFound.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugOccurrence", cbSubmitOccurrence.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugGravity", cbSubmitGravity.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPriority", cbSubmitPriority.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundVersion", cbSubmitVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundStruct", cbSubmitStruct.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugExceptDate", dtpSubmitExpDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuthor", cbSubmitAuthor.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugEditDate", dtpSubmitEditDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuditor", cbSubmitAudit.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_CreateReview, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbRejectOK_Click(object sender, EventArgs e)
        {
            if (this.txtRejectOpinion.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugOpinion", this.txtRejectOpinion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_NonApproval, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbCloseOK_Click(object sender, EventArgs e)
        {
            if (this.txtCloseNote.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugCategory", cbCloseCategory.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugHowFound", cbCloseHowFound.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugOccurrence", cbCloseOccurrence.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugGravity", cbCloseGravity.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPriority", cbClosePriority.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundVersion", cbCloseVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundStruct", cbCloseStruct.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtCloseAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugIsClosed", "True", "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugNotes", txtCloseNote.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_Close, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugClosedDate", txtClosedDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbReOpenOK_Click(object sender, EventArgs e)
        {
            if (this.txtReOpenBugTitle.Text == "" || this.cbReOpenAudit.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugTitle", txtReOpenBugTitle.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAttribution", txtReOpenAttribution.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugCategory", cbReOpenCategory.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugHowFound", cbReOpenHowFound.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugOccurrence", cbReOpenOccurrence.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugGravity", cbReOpenGravity.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPriority", cbReOpenPriority.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundVersion", cbReOpenVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundStruct", cbReOpenStruct.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugExceptDate", dtpReOpenExpectDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuthor", cbReOpenAuthor.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugEditDate", dtpReOpenEditDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtReOpenAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuditor", cbReOpenAudit.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_CreateReview, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void cbSubmitAudit_DropDown(object sender, EventArgs e)
        {
            this.cbSubmitAudit.Items.Clear();
            myManageDB.selectItems(this.cbSubmitAudit, "UserManager");
        }

        private void setComBoxItems(ComboBox comBox, string[] items)
        {
            comBox.Items.Clear();
            comBox.Items.AddRange(items);
        }

        private void setSkinComBoxItems(CCWin.SkinControl.SkinComboBox skinComBox, string[] items)
        {
            skinComBox.Items.Clear();
            skinComBox.Items.AddRange(items);
        }

        private void cbQueryGravity_DropDown(object sender, EventArgs e)
        {
            this.setSkinComBoxItems(this.cbQueryGravity, gravityItems);
        }

        private void cbQueryOccurrence_DropDown(object sender, EventArgs e)
        {
            this.setSkinComBoxItems(this.cbQueryOccurrence, occurrenceItems);
        }

        private void cbQueryHowFound_DropDown(object sender, EventArgs e)
        {
            this.setSkinComBoxItems(this.cbQueryHowFound, howFoundItems);
        }

        private void cbQueryPriority_DropDown(object sender, EventArgs e)
        {
            this.setSkinComBoxItems(this.cbQueryPriority, priorityItems);
        }

        private void cbSubmitAuthor_DropDown(object sender, EventArgs e)
        {
            this.cbSubmitAuthor.Items.Clear();
            myManageDB.selectItems(this.cbSubmitAuthor, "UserManager");
        }

        private void cbSubmitPriority_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbSubmitPriority, priorityItems);
        }

        private void cbSubmitGravity_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbSubmitGravity, gravityItems);
        }

        private void cbSubmitOccurrence_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbSubmitOccurrence, occurrenceItems);
        }

        private void cbSubmitHowFound_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbSubmitHowFound, howFoundItems);
        }

        private void cbCloseCategory_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbCloseCategory, cateGoryItems);
        }

        private void cbCloseHowFound_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbCloseHowFound, howFoundItems);
        }

        private void cbCloseOccurrence_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbCloseOccurrence, occurrenceItems);
        }

        private void cbCloseGravity_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbCloseGravity, gravityItems);
        }

        private void cbClosePriority_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbClosePriority, priorityItems);
        }

        private void cbSubmitCategory_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbSubmitCategory, cateGoryItems);
        }

        private void cbReOpenCategory_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbReOpenCategory, cateGoryItems);
        }

        private void cbReOpenAudit_DropDown(object sender, EventArgs e)
        {
            this.cbReOpenAudit.Items.Clear();
            myManageDB.selectItems(this.cbReOpenAudit, "UserManager");
        }

        private void cbReOpenGravity_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbReOpenGravity, gravityItems);
        }

        private void cbReOpenHowFound_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbReOpenHowFound, howFoundItems);
        }

        private void cbReOpenOccurrence_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbReOpenOccurrence, occurrenceItems);
        }

        private void cbReOpenPriority_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbReOpenPriority, priorityItems);
        }

        private void cbReOpenAuthor_DropDown(object sender, EventArgs e)
        {
            this.cbReOpenAuthor.Items.Clear();
            myManageDB.selectItems(this.cbReOpenAuthor, "UserManager");
        }

        private void cbModifyCC_DropDown(object sender, EventArgs e)
        {
            this.cbModifyCC.Items.Clear();
            myManageDB.selectItems(this.cbModifyCC, "UserManager");
        }

        private void cbModifyPlanVersion_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proName", txtModifyProName.Text);
            this.loadXmlContent(this.cbModifyPlanVersion, xmlContent);
        }

        private void loadXmlContent(ComboBox comBox, string xmlContent)
        {
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                comBox.Items.Clear();
                myLoadXml.loadXmlToComBox(xmlDoc.DocumentElement, comBox);
            }
        }

        private void cbModifyResoved_DropDown(object sender, EventArgs e)
        {
            this.cbModifyResoved.Items.Clear();
            myManageDB.selectItems(this.cbModifyResoved, "UserManager");
        }
        private void cbModifyPriority_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbModifyPriority, priorityItems);
        }

        private void cbModifyOccurrence_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbModifyOccurrence, occurrenceItems);
        }

        private void cbModifyCategory_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbModifyCategory, cateGoryItems);
        }

        private void cbModifyHowFound_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbModifyHowFound, howFoundItems);
        }

        private void cbModifyGravity_DropDown(object sender, EventArgs e)
        {
            this.setComBoxItems(this.cbModifyGravity, gravityItems);
        }

        private void cbModifyVersion_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proName", txtModifyProName.Text);
            this.loadXmlContent(this.cbModifyVersion, xmlContent);
        }

        private void cbModifyStruct_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proName", txtModifyProName.Text);
            this.loadXmlContent(this.cbModifyStruct, xmlContent);
        }

        private void cbCloseVersion_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proName", txtCloseProName.Text);
            this.loadXmlContent(this.cbCloseVersion, xmlContent);
        }

        private void cbCloseStruct_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proName", txtCloseProName.Text);
            this.loadXmlContent(this.cbCloseStruct, xmlContent);
        }

        private void cbAuditAudit_DropDown(object sender, EventArgs e)
        {
            this.cbAuditAudit.Items.Clear();
            myManageDB.selectItems(this.cbAuditAudit, "UserManager");
        }

        private void tsbAuditOK_Click(object sender, EventArgs e)
        {
            if (this.cbAuditAudit.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtAuditAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuditor", cbAuditAudit.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_CreateReview, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbModifyOK_Click(object sender, EventArgs e)
        {
            if (this.dtpModifyPlanDate.Text == "" || this.cbModifyResoved.Text == "" || this.cbModifyPlanVersion.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugCategory", cbModifyCategory.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugHowFound", cbModifyHowFound.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugOccurrence", cbModifyOccurrence.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugGravity", cbModifyGravity.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPriority", cbModifyPriority.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundVersion", cbModifyVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugFoundStruct", cbModifyStruct.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugExceptDate", dtpModifyExpDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtModifyAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAuditor", cbModifyResoved.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPlanVersion", cbModifyPlanVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPlanDate", dtpModifyPlanDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_Modifying, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbHugOK_Click(object sender, EventArgs e)
        {
            if (this.txtHugNote.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtModifyAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_HungUp, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void tsbSubTestCancel_Click(object sender, EventArgs e)
        {
            this.tbcBugDesign.TabPages.Remove(this.tpSubTest);
            this.tbcBugDesign.SelectedIndex = 0;
        }

        private void tsbSubTestOK_Click(object sender, EventArgs e)
        {
            if (this.cbSubTestVerifier.Text == "" || this.txtSubTestRootCase.Text == "" || this.txtSubTestRegAdvice.Text == "" || this.cbSubTestActualVersion.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugPlanDate", this.txtSubTestPlanDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugPlanVersion", this.txtSubTestPlanVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugRealVersion", this.cbSubTestActualVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugRealDate", this.dtpSubTestActualDate.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAdvice", this.txtModifyAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_Regression, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void cbSubTestVerifier_DropDown(object sender, EventArgs e)
        {
            this.cbSubTestVerifier.Items.Clear();
            myManageDB.selectItems(this.cbSubTestVerifier, "UserManager");
        }

        private void tsbRegTrueOK_Click(object sender, EventArgs e)
        {
            if (this.txtRegTrueNote.Text == "")
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "请将必填项填写完整!";
                tb.Show();
            }
            else
            {
                myManageDB.UpdateDB("BugManager", "bugRealVersion", cbRegTrueResovedVersion.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugVerify", txtRegTrueAudit.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugVerifyDate", dateTimeNow, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugClosedDate", dateTimeNow, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugAdvice", txtModifyAdvice.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugNotes", txtRegTrueNote.Text, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugStatus", bugStatus_Close, "bugID", myCurrentBugNo);
                myManageDB.UpdateDB("BugManager", "bugUpdateDate", dateTimeNow, "bugID", bugID);
                MainBugManager_Load(sender, e);
            }
        }

        private void cbRegFalseAudit_DropDown(object sender, EventArgs e)
        {
            this.cbSubTestVerifier.Items.Clear();
            myManageDB.selectItems(this.cbSubTestVerifier, "UserManager");
        }

        private void cbSubTestActualVersion_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proName", txtSubTestAttribution.Text);
            this.loadXmlContent(this.cbSubTestActualVersion, xmlContent);
        }

        private void cbRegTrueResovedVersion_DropDown(object sender, EventArgs e)
        {
            string xmlContent = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proName", txtRegTrueAttribution.Text);
            this.loadXmlContent(this.cbRegTrueResovedVersion, xmlContent);
        }

        private void tsbBugComment_Click(object sender, EventArgs e)
        {
            ToolBugComment myToolBugComment = new ToolBugComment();
            myToolBugComment.Show();
            myToolBugComment.AddBugComment += new SetBugComment(this.d_BugAddComment);

        }

        private void addBugComments(string header, string text)
        {
            ListViewGroup myListViewGroup = new ListViewGroup();
            myListViewGroup.Header = header;
            myListViewGroup.HeaderAlignment = HorizontalAlignment.Left;
            this.lvBugComment.Groups.Add(myListViewGroup);

            ListViewItem myListViewItem = new ListViewItem(text);
            myListViewItem.ToolTipText = text;
            this.lvBugComment.Items.Add(myListViewItem);
            myListViewItem.Group = myListViewGroup;
        }


        private void d_BugAddComment()
        {
            string header = ManageDB.userName + "(" + ManageDB.userEmailAddress + ")" + "   " + "【" + dateTimeNow + "】";
            string text = ToolBugComment.retext;
            this.addBugComments(header, text);
            this.addBugCommentToDB(header, text);
        }

        private void addBugCommentToDB(string header, string text)
        {
            string xmlContent = myManageDB.getDataFromCell("bugComment", "BugManager", "bugID", myCurrentBugNo);
            XDocument xml = null;

            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XDocument xdoc = XDocument.Load(myReader);
                XElement root = xdoc.Element("Tree");
                XElement e = CreateElement(header, text);
                root.Add(e);
                xml = xdoc;
            }
            else
            {
                XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
                XDocument xdoc = new XDocument(dec);
                XElement root = new XElement("Tree");
                XElement e = CreateElement(header, text);
                root.Add(e);
                xdoc.Add(root);
                xml = xdoc;
            }
            string sql = "declare @xmlDoc xml;set @xmlDoc ='" + xml + "'update BugManager set bugComment = @xmlDoc where bugID ='" + myCurrentBugNo + "'";
            myManageDB.saveXML(sql);
        }

        private XElement CreateElement(string header, string text)
        {
            return new XElement("Node",
                new XAttribute("Name", header),
                new XAttribute("Text", text)
                );
        }


        private void loadBugComment()
        {
            string xmlContent = myManageDB.getDataFromCell("bugComment", "BugManager", "bugID", myCurrentBugNo);
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    string header = node.Attributes["Name"].Value;
                    string text = node.Attributes["Text"].Value;
                    addBugComments(header, text);
                }
            }
        }

        private void tbcBugDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tbcBugDesign.SelectedTab.Name == "tpCommentInfo")
            {
                this.lvBugComment.Clear();
                this.loadBugComment();
            }
            else if (this.tbcBugDesign.SelectedTab.Name == "tpAttachment")
            {
                this.lvBugAttachment.Items.Clear();
                this.loadBugAttachment();
            }
        }

        private void tsbBugAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.Title = "添加附件";
            myOpenFileDialog.Multiselect = true;
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = myOpenFileDialog.FileNames;
                this.lvBugAttachment.Items.AddRange(this.addListViewItems(filePaths));
                myManageDB.StoreFiles(filePaths, myCurrentBugNo);
            }
        }

        private ListViewItem[] addListViewItems(string[] filePaths)
        {
            ListViewItem[] myListViewItems = null;
            List<ListViewItem> myListViewItemsList = new List<ListViewItem>();
            for (int i = 0; i < filePaths.Length; i++)
            {
                string fileName = Path.GetFileName(filePaths[i]);
                string fileType = Path.GetExtension(filePaths[i]);
                ListViewItem myListViewItem = new ListViewItem(GUID.getGUID("File"));
                myListViewItem.ToolTipText = fileName;
                ListViewItem.ListViewSubItem myListViewSubItemType = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem myListViewSubItemName = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem myListViewSubItemAddBy = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem myListViewSubItemAddTime = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem[] mySubItem = { myListViewSubItemType, myListViewSubItemName, myListViewSubItemAddBy, myListViewSubItemAddTime };
                myListViewSubItemType.Text = fileType;
                myListViewSubItemName.Text = fileName;
                myListViewSubItemAddBy.Text = userName;
                myListViewSubItemAddTime.Text = dateTimeNow;
                myListViewItem.SubItems.AddRange(mySubItem);
                myListViewItemsList.Add(myListViewItem);
                myListViewItems = myListViewItemsList.ToArray();
            }
            return myListViewItems;
        }

        private void showListViewItems(string filePath, string fileId)
        {
            string fileName = Path.GetFileName(filePath);
            string fileType = Path.GetExtension(filePath);
            ListViewItem myListViewItem = new ListViewItem(fileId);
            myListViewItem.ToolTipText = fileName;
            ListViewItem.ListViewSubItem myListViewSubItemType = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem myListViewSubItemName = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem myListViewSubItemAddBy = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem myListViewSubItemAddTime = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem[] mySubItem = { myListViewSubItemType, myListViewSubItemName, myListViewSubItemAddBy, myListViewSubItemAddTime };
            myListViewSubItemType.Text = fileType;
            myListViewSubItemName.Text = fileName;
            myListViewSubItemAddBy.Text = userName;
            myListViewSubItemAddTime.Text = dateTimeNow;
            myListViewItem.SubItems.AddRange(mySubItem);
            this.lvBugAttachment.Items.Add(myListViewItem);
        }

        private void lvBugAttachment_SizeChanged(object sender, EventArgs e)
        {
            this.attColName.Width = this.lvBugAttachment.Width - (this.attColNO.Width + this.attColType.Width + this.attColAddBy.Width + this.attColAddTime.Width);
        }

        private void loadBugAttachment()
        {
            string[] fileIds = myManageDB.getDataFromCells("fileID", "FileAttachment", "bugID", myCurrentBugNo);
            string[] loadFilePaths = null;
            List<string> loadFilePathsList = new List<string>();
            if (fileIds != null)
            {
                foreach (string fileId in fileIds)
                {
                    string filePath = myManageDB.getDataFromCell("filePath", "FileAttachment", "fileID", fileId);
                    loadFilePathsList.Add(filePath);
                    loadFilePaths = loadFilePathsList.ToArray();
                    this.showListViewItems(filePath, fileId);
                }

            }
        }

        private void tsBugAttachDownLoad_Click(object sender, EventArgs e)
        {
            string destFilePath = "";
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.Title = "下载文件保存到...";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                destFilePath = mySaveFileDialog.FileName;
            }
            if (destFilePath != "")
            {
                myManageDB.WriteFromDBtoFile(myCurrentBugNo, currentFileId, destFilePath);
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "保存成功!";
                tb.Show();
            }
            else
            {
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "文件下载已取消!";
                tb.Show();
            }
        }

        private void lvBugAttachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvBugAttachment.SelectedItems.Count != 0)
            {
                this.lvBugAttachment.ContextMenuStrip = this.cmsBugAttachment;
                currentFileId = this.lvBugAttachment.FocusedItem.Text;
            }
            else
            {
                this.lvBugAttachment.ContextMenuStrip = null;
            }
        }

        public void d_SetMainBugManagerWindowActive()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }


        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        void subForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            d_SetMainBugManagerWindowActive();
            LoadData();
        }
    }
}
