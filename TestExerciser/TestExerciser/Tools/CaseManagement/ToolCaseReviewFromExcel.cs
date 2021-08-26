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
using TestExerciser.Tools.Control;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;



namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseReviewFromExcel : Form
    {        
        string [] caseToReview = null;
        
        ManageDB myManageDB = new Logic.ManageDB();       
        string strNotice = null;

        string[] caseNameToReview = null;
        List<string> caseNameToReviewList = new List<string>();

        string[] autoReviewer = null;
        List<string> autoReviewerList = new List<string>();

        string[] ifCoverReviewer = null;
        List<string> ifCoverReviewerList = new List<string>();

        string[] selectedItem = null;
        static List<string> selectedItemList = new List<string>();

        string[] sheetNames = null;
        static List<string> sheetNamesList = new List<string>();

        string mailBody = null;
        string currentExcelPath = null;      


        int readColumnNo = 200;//读取Excel行数
        public bool addToProj = false;
        string excelFileName = null;


        Object cellTempValue = new object { };
        string markFlag;
        string excelFilePath = null;

        int yDel= 0;
        int yEidt =0;
        int yAdd =0;
        int yPass =0;
        int yUnRe = 0;

        string cmdReviewerMail = ManageDB.userEmailAddress;
        string comDel = "";
        string comAdd = "";
        string comEdit = "";
        string comPass = "";
        bool comAuto = false;
        bool comCover = false;
        

        string[] comDelArray = null;
        List<string> comDelArrayList = new List<string>();
        string[] comAddArray = null;
        List<string> comAddArrayList = new List<string>();
        string[] comEditArray = null;
        List<string> comEditArrayList = new List<string>();
        string[] comPassArray = null;
        List<string> comPassArrayList = new List<string>();

        

        

        public ToolCaseReviewFromExcel()
        {
            InitializeComponent();
        }

        private void MainCaseReview_Load(object sender, EventArgs e)
        {
            try
            {
            this.btnSelectFile.Enabled = false;
            this.cbIfAuto.Enabled = false;
            this.cbIfCover.Enabled = false;
            this.cbIfMatch.Enabled = false;
            this.cbIfOrder.Enabled = false;
            this.cbSelectExcel.Enabled = false;
            this.btnLaunch.Enabled = false;
            this.btnStart.Enabled = false;
            this.rtbCommit.Enabled = false;
            this.btnCommit.Enabled = false;

            if (myManageDB.checkCoverReviewTo() || myManageDB.checkAutoReviewTo())            
            {
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
                this.sbStep2.BaseColor = Color.Lime;
                this.sbStep2.BorderColor = Color.Lime;
                this.sbStep3.BaseColor = Color.Lime;
                this.sbStep3.BorderColor = Color.Lime;
                this.cbSelectExcel.Enabled = true;
                addExcelToDgv(this.dgvSelectFile);
            }
            else if (myManageDB.checkReviewFrom())
            {
                
            }
            else
            {
                this.btnSelectFile.Enabled = true;
            }           
            myManageDB.selectItems(cbIfAuto,"UserManager");
            myManageDB.selectItems(cbIfCover,"UserManager");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult myDialogResult = this.selectFileDialog.ShowDialog();
            if (myDialogResult == DialogResult.OK)
            {
                string strSub = null;
                caseToReview = this.selectFileDialog.FileNames;
                foreach (string str in caseToReview)
                {
                    strSub = strSub + str + ";";
                    this.tbFilePath.Text = strSub;                  
                }
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
                this.cbIfAuto.Enabled = true;
                
            }
        }

        private void MainCaseReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            myManageDB.clearList(cbIfAuto,"UserManager");
            myManageDB.clearList(cbIfCover,"UserManager");
        }

        private void cbIfAuto_Click(object sender, EventArgs e)
        {           
            this.cbIfAuto.Text = strNotice;
        }

        private void cbIfCover_Click(object sender, EventArgs e)
        {
            this.cbIfCover.Text = strNotice;
        }

        private void cbIfAuto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cbIfCover.Enabled = true;
        }

        private void myLabelIfCover_DoubleClick(object sender, EventArgs e)
        {
           DialogResult myLabel_DoubleClick = MessageBox.Show("确定要删除该评审人吗？","消息提示：", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
           if (myLabel_DoubleClick == DialogResult.OK)
           {
               var myLabel = sender as Label;
               tlpCoverFullNameList.Controls.Remove((myLabel));
               selectedItemList.Remove(myLabel.Text.Split('；')[0]);
               selectedItem = selectedItemList.ToArray();
           }
        }

        private void cbIfCover_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool flag = false;
            int addNo = 0;
            if (cbIfCover.SelectedItem != null)
            {
                if (selectedItem != null)
                {
                  for (int i = 0; i < selectedItem.Length;i++ ) 
                    {
                        if (selectedItem[i] == cbIfCover.SelectedItem.ToString())
                        {
                            flag = true;
                            break;
                        }      
                    } 
                }

                if (!flag)
                {
                    if (addNo < 25)
                    {
                        addMyLabelControl();
                        addNo++;
                    }
                    else
                    {
                        MessageBox.Show("目前仅支持最多添加25位覆盖点评审人员！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void addMyLabelControl()
        {
            Label myLabel = new Label();
            myLabel.DoubleClick += new System.EventHandler(this.myLabelIfCover_DoubleClick);           

            string mailAddressStr = null;
            try
            {
                mailAddressStr = Regex.Match(cbIfCover.SelectedItem.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            myLabel.Text = cbIfCover.SelectedItem.ToString() + "；";
            tlpCoverFullNameList.Controls.Add(myLabel);
            
            ifCoverReviewerList.Add(mailAddressStr);
            ifCoverReviewer = ifCoverReviewerList.ToArray();
            selectedItemList.Add(cbIfCover.SelectedItem.ToString());
            selectedItem = selectedItemList.ToArray();
            if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
            {
                this.sbStep2.BaseColor = Color.Lime;
                this.sbStep2.BorderColor = Color.Lime;
                this.btnLaunch.Enabled = true;
            }
        }

        private string[] getExcelSheetName(string excelName)
        {
            bool hasTitle = true;
            excelFilePath = testCasesPool() + excelName;
            excelFileName = Path.GetFileName(excelFilePath);
            string fileType = System.IO.Path.GetExtension(excelFilePath);
            if (string.IsNullOrEmpty(fileType)) return null;
            DataTable sheetsName;

            try
            {
                string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.{0}.0;" +
                                              "Extended Properties=\"Excel {1}.0;HDR={2};IMEX=1;\";" +
                                              "data source={3};",
                                              (fileType == ".xls" ? 4 : 12), (fileType == ".xls" ? 8 : 12), (hasTitle ? "Yes" : "NO"), excelFilePath);
                using (OleDbConnection myConn = new OleDbConnection(strCon))
                {
                    myConn.Open();
                    sheetsName = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                    //string firstSheetName = sheetsName.Rows[0][2].ToString(); //得到第一个sheet的名字
                }
                //得到所有的sheet的名字
                foreach (DataRow dr in sheetsName.Rows)
                {                    
                    string resultString = null;
                    try
                    {
                        resultString = Regex.Match(dr[2].ToString(), @"[\s\S]*(?=\$)").Value;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("写入Sheet名称失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sheetNamesList.Add(resultString);
                }
                sheetNames = sheetNamesList.ToArray();
                return sheetNames; 
            }
            catch (Exception ex)
            {

                MessageBox.Show("获取Excel中所有Sheet名称失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return sheetNames = null;
            }
        }

        private void myTextSelectTestCase_DoubleClick(object sender, EventArgs e)
        {
            DialogResult myText_DoubleClick = MessageBox.Show("确定要选择用例吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (myText_DoubleClick == DialogResult.OK)
            {
                if (cbSelectExcel.DataSource != null)
                {
                    cbSelectExcel.DataSource = null;
                }
                var myText = sender as TextBox;
                sheetNamesList.Clear();
                sheetNames = sheetNamesList.ToArray();
                getExcelSheetName(myText.Text);               
                myText.BackColor = Color.LightGoldenrodYellow;
                cbSelectExcel.Enabled = true;
                
                cbSelectExcel.DataSource = sheetNamesList;
                currentExcelPath = testCasesPool() + myText.Text;
                this.sbStep4.BaseColor = Color.Lime;
                this.sbStep4.BorderColor = Color.Lime;
                btnStart.Enabled = true;
            }
        }


        private void addExcelToTlpSelectTestCase(string labelText)
        {
            TextBox myText = new TextBox();
            myText.Dock = DockStyle.Fill;
            myText.ReadOnly = true;
            myText.DoubleClick += new System.EventHandler(this.myTextSelectTestCase_DoubleClick);           
            myText.Text = labelText;
            //tlpSelectTestCase.Controls.Add(myText);
        }

        private void addExcelToDgv(CCWin.SkinControl.SkinDataGridView dgvExcel)
        {
            DataTable dt = new DataTable();//建立个数据表
            dt.Columns.Add(new DataColumn("Excel文件名", typeof(string)));//在表中添加string类型的Name列
            DataRow dr;//行
            if (Directory.Exists(testCasesPool()))
            {
               string [] excelFilepool = Directory.GetFiles(testCasesPool());
               foreach (string str in excelFilepool)
               {                  
                   dr = dt.NewRow();
                   dr["Excel文件名"] = Path.GetFileName(str);
                   dt.Rows.Add(dr);//在表的对象的行里添加此行
               }
            }
            dgvExcel.DataSource = dt;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("revFullName", "CaseReview", ManageDB.userName, "revEmail", ManageDB.userEmailAddress))
            {
                MessageBox.Show("您已经发起了评审流程！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                myManageDB.InsertInto("insert into CaseReview(revFullName,revEmail) values('" + ManageDB.userName + "'," + "'" + ManageDB.userEmailAddress + "')");
                string FilesPath = this.tbFilePath.Text;
                string[] excelFilesPath = FilesPath.Split(';');
                foreach (string str in excelFilesPath)
                {
                    if (str != "")
                    {
                        try
                        {
                            if (!Directory.Exists(testCasesPool()))
                            {
                                Directory.CreateDirectory(testCasesPool());
                            }
                            File.Copy(str, testCasesPool() + Path.GetFileName(str), true);
                            caseNameToReviewList.Add(Path.GetFileName(str) + "\r\n");
                            caseNameToReview = caseNameToReviewList.ToArray();
                            mailBody = Path.GetFileName(str) + "\r\n" + mailBody;
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
                {
                    this.cbIfCover.Enabled = true;
                    string mailAddressStr = null;
                    try
                    {
                        mailAddressStr = Regex.Match(cbIfAuto.Text.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
                    }
                    catch (ArgumentException exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    autoReviewerList.Add(mailAddressStr);
                    autoReviewer = autoReviewerList.ToArray();
                }

                if (autoReviewer != null)
                {
                    sendMail("测试用例自动化评审流程", autoReviewer);
                }
                if (ifCoverReviewer != null)
                {
                    sendMail("测试用例测试点覆盖评审流程", ifCoverReviewer);
                }
                foreach (string autoReviewTo in autoReviewer)
                {
                    myManageDB.UpdateDB("UserManager", "userAutoReviewTo", "True", "userEmail", autoReviewTo);
                }
                foreach (string coverReviewTo in ifCoverReviewer)
                {
                    myManageDB.UpdateDB("UserManager", "userCoverReviewTo", "True", "userEmail", coverReviewTo);
                }
                myManageDB.UpdateDB("UserManager", "userReviewFrom", "True", "userEmail", ManageDB.userEmailAddress);
            }                       
        }

        private void sendMail(string mailSubject, string [] mailTo)
        {
            try
            {
                SendMail mail = new SendMail();
                mail.mailFrom = "TestExerciser@163.com";
                mail.mailPwd = "admin123";
                mail.mailSubject = mailSubject;
                mail.mailBody = "有以下用例需要您审批：\r\n\r\n\r\n" + mailBody + "\r\n\r\n\r\n注：该邮件由自动化测试测试工具自动发送\r\n（自动化测试工具TestExerciser）";
                mail.isbodyHtml = false;
                mail.host = "smtp.163.com";
                mail.mailToArray = mailTo;
                mail.mailCcArray = new string[] { };
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((this.cbSelectExcel.Text != null) && (this.cbSelectExcel.Text != ""))
            {
                if (dgvCommit.DataSource != null)
                {
                    //DataTable dt = (DataTable)dgvCommit.DataSource;
                    //dt.Rows.Clear();
                    dgvCommit.DataSource = null;                   
                }                
                dgvCommit.DataSource = GetDataFromExcelToDT(this.cbSelectExcel.Text,this.cbSelectExcel);
                dgvCommit.ResetBindings();
                this.sbStep5.BaseColor = Color.Lime;
                this.sbStep5.BorderColor = Color.Lime;
                this.btnStart.Enabled = true;
                this.rtbCommit.Enabled = true;
            }
            else
            {
                MessageBox.Show("请选取需要导入的Excel工作簿名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 从Excel获取数据
        /// </summary>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        
        private DataTable GetDataFromExcelToDT(string currentSheetName,CCWin.SkinControl.SkinComboBox comboBox)
        {
            DataSet ds = new DataSet();
            bool hasTitle = true;
            if (comboBox.Text != "")
            {
                excelFileName = Path.GetFileName(excelFilePath);
                string fileType = System.IO.Path.GetExtension(excelFilePath);
                if (string.IsNullOrEmpty(fileType)) return null;

                try
                {
                    string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.{0}.0;" +
                                                  "Extended Properties=\"Excel {1}.0;HDR={2};IMEX=1;\";" +
                                                  "data source={3};",
                                                  (fileType == ".xls" ? 4 : 12), (fileType == ".xls" ? 8 : 12), (hasTitle ? "Yes" : "NO"), excelFilePath);                                       
                    using (OleDbConnection myConn = new OleDbConnection(strCon))
                    {
                        myConn.Open();
                        //DataTable sheetsName = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                        //string firstSheetName = sheetsName.Rows[0][2].ToString(); //得到第一个sheet的名字
                        string strCom = string.Format(" SELECT * FROM [{0}$A3:P{1}]", (currentSheetName), readColumnNo);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                        myCommand.Fill(ds, currentSheetName);
                    }
                    if (ds == null || ds.Tables.Count <= 0) return null;
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("读取Excel数据失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;

                }
            }
            return null;
        }


        private void dgvCommit_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvCommit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!Object.Equals(cellTempValue, this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                }
                else
                {
                    this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                }
            }
        }

        private int TotalNonNullCell()
        {
            int nonNullCellNum = 0;
            int noRowsMax = this.dgvCommit.Rows.Count - 1;
            for (int noRow = 0; noRow < noRowsMax; noRow++)
            {
                for (int noCell = 0; noCell < this.dgvCommit.Rows[noRow].Cells.Count - 1; noCell++)
                {
                    //判断当前行是否全为空，如果为空，则后面的数据不需要再读取
                    bool flag = false;
                    if (this.dgvCommit.Rows[noRow].Cells[noCell].Value != DBNull.Value)
                    {
                        nonNullCellNum = nonNullCellNum + 1;
                        flag = true;
                    }
                    if (!flag)
                    {
                        noRowsMax = noRow;
                        break;
                    }
                }
            }
            return nonNullCellNum; 
        }
        
        /// <summary>
        /// 统计当前表中的测试用例个数
        /// </summary>
        /// <returns></returns>
        private int TotalCasesNo()
        {
            int nonNullCellNum = 0;
            int noRowsMax = this.dgvCommit.Rows.Count - 1;
            for (int noRow = 0; noRow < noRowsMax; noRow++)
            {
                if (this.dgvCommit.Rows[noRow].Cells[5].Value != DBNull.Value)
                {
                    nonNullCellNum = nonNullCellNum + 1;
                }
            }
            return nonNullCellNum; 
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {     
            if(rtbCommit.Text!="")
            {
                List<string> xData = new List<string>() { "增", "删", "改", "过", "空" };
                yUnRe = TotalCasesNo() - yDel - yEidt - yAdd - yPass;
                List<int> yData = new List<int>() { yAdd,yDel,yEidt,yPass,yUnRe };
                this.chartForAnalyze.ChartAreas[0].Area3DStyle.Enable3D = true;
                this.chartForAnalyze.Series[0].ChartType = SeriesChartType.Doughnut;//选择图的类型为饼图
                this.chartForAnalyze.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧

                this.chartForAnalyze.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                this.chartForAnalyze.Series[0].Points.DataBindXY(xData, yData);
                if (this.comDelArray != null)
                {
                    foreach (string str in comDelArray)
                    {
                        comDel = comDel + str + "|";
                    }
                }
                if (this.comAddArray != null)
                {
                    foreach (string str in comAddArray)
                    {
                        comAdd = comAdd + str + "|";
                    }
                }
                if (this.comEditArray != null)
                {
                    foreach (string str in comEditArray)
                    {
                        comEdit = comEdit + str + "|";
                    }
                }
                if (this.comPassArray != null)
                {
                    foreach (string str in comPassArray)
                    {
                        comPass = comPass + str + "|";
                    }
                }
                myManageDB.InsertInto("insert into CaseReviewContents(comReviewerMail,comDel,comAdd,comEdit,comPass,comAuto,comCover) values('" + cmdReviewerMail + "'," + "'" + comDel + "'," + "'" + comAdd + "'," + "'" + comEdit + "'," + "'" + comPass + "'," + "'" + comAuto + "'," + "'" + comCover + "')");
                this.sbStep6.BaseColor = Color.Lime;
                this.sbStep6.BorderColor = Color.Lime;
                if (myManageDB.checkAutoReviewTo())
                {
                    myManageDB.UpdateDB("UserManager", "userAutoReviewTo", "false", "userEmail",ManageDB.userEmailAddress);
                }
                else if (myManageDB.checkCoverReviewTo())
                {
                    myManageDB.UpdateDB("UserManager", "userCoverReviewTo", "false", "userEmail", ManageDB.userEmailAddress);
                }              
            }
            else
            {
                MessageBox.Show("评审内容不能为空！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            

             
        }

        private void rtbCommit_TextChanged(object sender, EventArgs e)
        {
            if (this.rtbCommit.Text != "")
            {
                this.btnCommit.Enabled = true;
            }
        }

        private void 标记删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markFlag = "DELETE";
            
        }

        private void 标记修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markFlag = "EDIT";
        }

        private void 标记增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markFlag = "ADD";
        }

        private void 标记通过ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markFlag = "PASS";
        }

        private void 清除标记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markFlag = "CLEAN";
        }
       
        private void dgvCommit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Color currentCellColor = this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            int rowNo;
            if(myManageDB.checkAutoReviewTo())
            {
                rowNo = 13;
                comAuto = true;
            }
            else 
            {
                rowNo = 5;
                comCover = true;
            }
            //单击用例编号单元格修改用例
             if (e.RowIndex > -1 && e.ColumnIndex == rowNo)
            {
                if (this.dgvCommit.Rows[e.RowIndex].Cells[rowNo].Value != DBNull.Value)
                {
                    int X = e.RowIndex + 1;
                    int Y = e.ColumnIndex + 1;
                    bool ifChange = ((currentCellColor != Color.Yellow) && (currentCellColor != Color.Red) && (currentCellColor != Color.DeepSkyBlue) && (currentCellColor != Color.LightGreen));
                    switch (markFlag)
                    {
                        case "DELETE":
                            if (ifChange)
                            {
                                this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                                this.dgvCommit.ColumnSelectBackColor = Color.Yellow;
                                this.rtbCommit.SelectionBackColor = Color.Yellow;
                                this.rtbCommit.AppendText("【行" + X + "列" + Y + "】" + "【删除说明】【" + ManageDB.userName + "】：\n");
                                yDel = yDel + 1;
                                comDelArrayList.Add(X.ToString());
                                comDelArray = comDelArrayList.ToArray();
                            }                        
                            break;
                        case "EDIT":
                            if (ifChange)
                            {
                                this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                                this.dgvCommit.ColumnSelectBackColor = Color.Red;
                                this.rtbCommit.SelectionBackColor = Color.Red;
                                this.rtbCommit.AppendText("【行" + X + "列" + Y + "】【修改说明】【" + ManageDB.userName + "】：\n");
                                yEidt = yEidt + 1;
                                comEditArrayList.Add(X.ToString());
                                comEditArray = comEditArrayList.ToArray();
                            }
                            break;
                        case "ADD":
                            if (ifChange)
                            {
                                this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DeepSkyBlue;
                                this.dgvCommit.ColumnSelectBackColor = Color.DeepSkyBlue;
                                this.rtbCommit.SelectionBackColor = Color.DeepSkyBlue;
                                this.rtbCommit.AppendText("【行" + X + "列" + Y + "】【添加说明】【" + ManageDB.userName + "】：\n");
                                yAdd = yAdd + 1;
                                comAddArrayList.Add(X.ToString());
                                comAddArray = comAddArrayList.ToArray();
                            }
                            break;
                        case "PASS":
                            if (ifChange)
                            {
                                this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                                this.dgvCommit.ColumnSelectBackColor = Color.LightGreen;
                                this.rtbCommit.SelectionBackColor = Color.LightGreen;
                                this.rtbCommit.AppendText("【行" + X + "列" + Y + "】【通过说明】【" + ManageDB.userName + "】：通过\n");
                                yPass = yPass + 1;
                                comPassArrayList.Add(X.ToString());
                                comPassArray = comPassArrayList.ToArray();
                            }
                            break;
                        case "CLEAN":                           
                            if (this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Yellow)
                            {
                                string str = "【行" + X + "列" + Y + "】【删除说明】【" + ManageDB.userName + "】：\n";
                                if (this.rtbCommit.Text.IndexOf(str) > -1)
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str), str.Length);
                                }
                                else
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str) + 1, str.Length);
                                }
                                yDel = yDel - 1;
                                comDelArrayList.Remove(X.ToString());
                                comDelArray = comDelArrayList.ToArray();
                            }
                            else if (this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                            {
                                string str = "【行" + X + "列" + Y + "】【修改说明】【" + ManageDB.userName + "】：\n";
                                if (this.rtbCommit.Text.IndexOf(str) > -1)
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str), str.Length);
                                }
                                else
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str) + 1, str.Length);
                                }
                                yEidt = yEidt - 1;
                                comEditArrayList.Remove(X.ToString());
                                comEditArray = comDelArrayList.ToArray();

                            }
                            else if (this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.DeepSkyBlue)
                            {
                                string str = "【行" + X + "列" + Y + "】【添加说明】【" + ManageDB.userName + "】：\n";
                                if (this.rtbCommit.Text.IndexOf(str) > -1)
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str), str.Length);
                                }
                                else
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str) + 1, str.Length);
                                }
                                yAdd = yAdd - 1;
                                comAddArrayList.Remove(X.ToString());
                                comAddArray = comDelArrayList.ToArray();
                                
                            }
                            else if (this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.LightGreen)
                            {
                                string str = "【行" + X + "列" + Y + "】【通过说明】【" + ManageDB.userName + "】：通过\n";
                                if (this.rtbCommit.Text.IndexOf(str) > -1)
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str), str.Length);
                                }
                                else
                                {
                                    this.rtbCommit.Text = this.rtbCommit.Text.Remove(this.rtbCommit.Text.IndexOf(str)+1, str.Length);
                                }
                                yPass = yPass - 1;
                                comPassArrayList.Remove(X.ToString());
                                comPassArray = comDelArrayList.ToArray();

                            }
                            this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                            this.dgvCommit.ColumnSelectBackColor = Color.White;
                            break;
                        default:
                            break;
                    }                       
                }                
            }
        }

        private string testCasesPool()
        {
            string serverTestCaseReviewExcelPool = "";
            if (Properties.Settings.Default.ServerName == "")
            {
                serverTestCaseReviewExcelPool = @"C:\DATA\TestCaseReviewExcelPool\";              
            }
            else
            {
                serverTestCaseReviewExcelPool = @"\\" + Properties.Settings.Default.ServerName + @"\DATA\TestCaseReviewExcelPool\";
            }

            try
            {
                if (!Directory.Exists(serverTestCaseReviewExcelPool))
                {
                    Directory.CreateDirectory(serverTestCaseReviewExcelPool);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("读取Excel数据失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return serverTestCaseReviewExcelPool;
        }

        private void tabControlReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlReview.SelectedIndex == 1)
            {
                addExcelToDgv(this.dgvSelectExcelFiles);
                if (this.scbSelectFile.Text == "")
                {
                    this.scbSelectFile.Enabled = false;
                    this.btnMakeSure.Enabled = false;
                }               
            }
        }

        private void dgvSelectExcelFiles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult myText_DoubleClick = MessageBox.Show("确定要选择用例吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (myText_DoubleClick == DialogResult.OK)
            {
                if (scbSelectFile.DataSource != null)
                {
                    scbSelectFile.DataSource = null; 
                }
                string excelName = this.dgvSelectExcelFiles.CurrentCell.Value.ToString();
                sheetNamesList.Clear();
                sheetNames = sheetNamesList.ToArray();
                getExcelSheetName(excelName);
                this.scbSelectFile.Enabled = true;
                this.btnMakeSure.Enabled = true;
                scbSelectFile.DataSource = sheetNamesList;
                currentExcelPath = testCasesPool() + excelName;
            }
        }

        private void btnMakeSure_Click(object sender, EventArgs e)
        {
            if ((this.scbSelectFile.Text != null) && (this.scbSelectFile.Text != ""))
            {
                if (dgvMakeSure.DataSource != null)
                {
                    dgvMakeSure.DataSource = null;
                }
                dgvMakeSure.DataSource = GetDataFromExcelToDT(this.scbSelectFile.Text,this.scbSelectFile);
                dgvMakeSure.ResetBindings();
                this.sbStep7.BaseColor = Color.Lime;
                this.sbStep7.BorderColor = Color.Lime;
            }
            else
            {
                MessageBox.Show("请选取需要确认的Excel工作簿名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOkSave_Click(object sender, EventArgs e)
        {
            this.sbStep8.BaseColor = Color.Lime;
            this.sbStep8.BorderColor = Color.Lime;
        }

        private void dgvSelectFile_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult myText_DoubleClick = MessageBox.Show("确定要选择用例吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (myText_DoubleClick == DialogResult.OK)
            {
                if (cbSelectExcel.DataSource != null)
                {
                    cbSelectExcel.DataSource = null;
                }
                string excelName = this.dgvSelectFile.CurrentCell.Value.ToString();
                sheetNamesList.Clear();
                sheetNames = sheetNamesList.ToArray();
                getExcelSheetName(excelName);
                cbSelectExcel.Enabled = true;

                cbSelectExcel.DataSource = sheetNamesList;
                currentExcelPath = testCasesPool() + excelName;
                this.sbStep4.BaseColor = Color.Lime;
                this.sbStep4.BorderColor = Color.Lime;
                btnStart.Enabled = true;
            }
        }

      

       
    }
}
