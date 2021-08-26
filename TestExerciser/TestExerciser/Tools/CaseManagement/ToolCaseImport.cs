using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using TestExerciser.Logic;
using System.Data.OleDb;
using System.Xml;
using TestExerciser.Tools.ProjectManagement;

namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseImport : Form
    {
        ExcelDataReader myExcelDataReader = new ExcelDataReader();
        DataGridViewCheckBoxColumn columnCBC = new DataGridViewCheckBoxColumn();

        DataTable myCaseImport = new DataTable();
        DataTable MyDs = new DataTable();
        int importFailured = 0;
        int importSucceed = 0;

        ManageDB myManageDB = new ManageDB();

        public ToolCaseImport()
        {
            InitializeComponent();          
            this.setDataGridViewColumnHeaders();
            this.addCheckBox();
        }

        private void ToolCaseImport_Load(object sender, EventArgs e)
        {
            this.linkSelectAllRegion.Visible = false;
            this.linkSelectInvertRegion.Visible = false;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            MyDs = myExcelDataReader.GetDataFromExcelToDT();
            this.tbSelectFile.Text = ExcelDataReader.myExcelName;
            this.readAllCells();
            this.linkSelectAllRegion.Visible = true;
            this.linkSelectInvertRegion.Visible = true;
            this.dgv_CaseToImprot.ClearSelection();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            importFailured= 0;
            importSucceed = 0;
            if (this.tbSelectFile.Text != "")
            {
                if (this.tbSelectProject.Text != "")
                {
                    if (this.cbSelectStruct.Text != "")
                    {
                        this.selectedRows();
                    }
                    else
                    {
                        this.labStatus.ForeColor = Color.Red;
                        this.labStatus.Text = "导入结果：导入失败，请先选择项目架构！";
                    }
                }
                else
                {
                    this.labStatus.ForeColor = Color.Red;
                    this.labStatus.Text = "导入结果：导入失败，请先选择项目！";
                }
            }
            else
            {
                this.labStatus.ForeColor = Color.Red;
                this.labStatus.Text = "导入结果：导入失败，请先选择需要导入的Excel表格！";
            }         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void setDataGridViewColumnHeaders()
        {           
            myCaseImport.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("用例编号"),
                    new DataColumn("用例名称"),
                    new DataColumn("测试套编号"),
                    new DataColumn("测试套名称"),
                    new DataColumn("需求编号"),
                    new DataColumn("用例级别"),
                    new DataColumn("预置条件"),
                    new DataColumn("用例步骤"),
                    new DataColumn("样本点"),
                    new DataColumn("预期结果"),
                    new DataColumn("是否可自动化"),
                });
            //this.dgv_CaseToImprot.ColumnCount = 6;
            for (int i = 0; i < this.dgv_CaseToImprot.ColumnCount; i++)
            {
                this.dgv_CaseToImprot.Columns[i].Name = myCaseImport.Columns[i].ColumnName;
                this.dgv_CaseToImprot.Columns[i].DataPropertyName = myCaseImport.Columns[i].ColumnName;
                this.dgv_CaseToImprot.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    this.dgv_CaseToImprot.Columns[i].Width = 120;
                else
                    this.dgv_CaseToImprot.Columns[i].Width = 150;
            }
        }

        private string readCell(int rawNo, int columnNo)
        {
            string cellValue = "";
            try
            {
                if (MyDs != null)
                {
                    cellValue = MyDs.Rows[rawNo][columnNo].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cellValue;
        }

        private void readAllCells()
        {
            int i = 0; //遍历模块
            int j = 0; //遍历测试套
            int k = 0; //遍历用例      

            if (readCell(i + j + k, 0) != "")
            {
                for (i = 0; i + j + k < this.MyDs.Rows.Count; i++)
                {
                    //this.tstbCreateScriptProgress.Maximum = this.myCaseImport.Rows.Count;
                    if (readCell(i, 0).ToString() != "")
                    {
                        //rootFather = readCell(i, 0).ToString().Replace("\n", "");//父模块
                        //rootSub = readCell(i, 1).ToString().Replace("\n", "");//子模块
                    }
                    for (j = 1; i + j + k < this.MyDs.Rows.Count - (i + 1); j++)
                    {
                        if (readCell(i + j, 3) != "")
                        {
                            //readCell(i + j, 2).ToString().Replace("\n", "");//需求编号
                            //readCell(i + j, 3).ToString().Replace("\n", "");//测试套编号
                            //readCell(i + j, 4).ToString().Replace("\n", "");//测试套名称
                            for (k = 1; i + j + k < this.MyDs.Rows.Count - (i + j + 1); k++)
                            {
                                if (readCell(i + j + k, 5) != "")
                                {
                                    DataRow row = myCaseImport.NewRow();
                                    row[0] = readCell(i + j + k, 5).ToString().Replace("\n", "");//用例编号
                                    row[1] = readCell(i + j + k, 6).ToString().Replace("\n", "");//用例名称
                                    row[2] = readCell(i + j, 3).ToString().Replace("\n", "");//测试套编号
                                    row[3] = readCell(i + j, 4).ToString().Replace("\n", "");//测试套名称
                                    //if (readCell(i, 0).ToString() == "")
                                    //{
                                    //    row[4] = rootFather;//父模块
                                    //    row[5] = rootSub;//子模块
                                    //}
                                    //else
                                    //{
                                    //    row[4] = readCell(i, 0).ToString().Replace("\n", "");//父模块
                                    //    row[5] = readCell(i, 1).ToString().Replace("\n", "");//子模块
                                    //}
                                    row[4] = readCell(i + j, 2).ToString().Replace("\n", "");//需求编号
                                    row[5] = readCell(i + j + k, 7).ToString().Replace("\n", "");//用例级别
                                    row[6] = readCell(i + j + k, 8).ToString().Replace("\n", "");//预置条件
                                    row[7] = readCell(i + j + k, 9).ToString().Replace("\n", "");//用例步骤
                                    row[8] = readCell(i + j + k, 10).ToString().Replace("\n", "");//样本点
                                    row[9] = readCell(i + j + k, 11).ToString().Replace("\n", "");//预期结果
                                    row[10] = readCell(i + j + k, 13).ToString().Replace("\n", "");//是否可自动化
                                        //row[6] = readCell(i + j, 2).ToString().Replace("\n", "");//需求编号
                                        //row[7] = readCell(i + j + k, 7).ToString().Replace("\n", "");//用例级别
                                        //row[8] = readCell(i + j + k, 8).ToString().Replace("\n", "");//预置条件
                                        //row[9] = readCell(i + j + k, 9).ToString().Replace("\n", "");//用例步骤
                                        //row[10] = readCell(i + j + k, 10).ToString().Replace("\n", "");//样本点
                                        //row[11] = readCell(i + j + k, 11).ToString().Replace("\n", "");//预期结果
                                        //row[12] = readCell(i + j + k, 12).ToString().Replace("\n", "");//实际结果
                                        //row[13] = readCell(i + j + k, 13).ToString().Replace("\n", "");//是否可自动化
                                        //row[14] = readCell(i + j + k, 14).ToString().Replace("\n", "");//测试人员
                                        //row[15] = readCell(i + j + k, 15).ToString().Replace("\n", "");//测试日期
                                        myCaseImport.Rows.Add(row);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (readCell(i + j + k, 3) == "")
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("加载完毕！");
            }           
            dgv_CaseToImprot.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CaseToImprot.DataSource = myCaseImport;
        }

        private void addCheckBox()
        {
            columnCBC.HeaderText = "选择";
            columnCBC.Name = "ccheck";
            columnCBC.TrueValue = true;
            columnCBC.FalseValue = false;
            columnCBC.Width = 50;
            this.dgv_CaseToImprot.Columns.Add(columnCBC);
        }

        private void linkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setAllRowCheckedValue(e,true);
        }

        private void linkSelectInvert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setAllRowCheckedValue(e, false);
        }

        private void setAllRowCheckedValue(LinkLabelLinkClickedEventArgs e, bool checkedValue)
        {
            int count = Convert.ToInt16(this.dgv_CaseToImprot.Rows.Count.ToString());
            if (count != 0)
            {
                foreach (DataGridViewRow row in this.dgv_CaseToImprot.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv_CaseToImprot.Rows[row.Index].Cells["ccheck"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag != checkedValue) //查找被选择的数据行
                    {
                        checkCell.Value = checkedValue;
                    }
                }
                this.labStatus.Text = "";
            }
            else
            {
                this.labStatus.ForeColor = Color.Red;
                this.labStatus.Text = "导入结果：导入失败，请先选中用例！";
            }

        }

        private void setAllRegionRowCheckedValue(LinkLabelLinkClickedEventArgs e, bool checkedValue)
        {
            int count = Convert.ToInt16(this.dgv_CaseToImprot.SelectedRows.Count.ToString());
            if (count != 0)
            {
                foreach (DataGridViewRow row in this.dgv_CaseToImprot.SelectedRows)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv_CaseToImprot.Rows[row.Index].Cells["ccheck"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag != checkedValue) //查找被选择的数据行
                    {
                        checkCell.Value = checkedValue;
                    }
                }
                this.labStatus.Text = "";
            }
            else
            {
                this.labStatus.ForeColor = Color.Red;
                this.labStatus.Text = "导入结果：导入失败，请先选中用例！";
            }
            
        }

        private void selectedRows()
        {
            int count = Convert.ToInt16(this.dgv_CaseToImprot.Rows.Count.ToString());
            if (count != 0)
            {
                int i = 0;
                for (i = 0; i < count; i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv_CaseToImprot.Rows[i].Cells["ccheck"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true) //查找被选择的数据行
                    {
                        this.saveRowsToDataBase(i);
                    }
                    continue;
                }
                if (importFailured != 0)
                {
                    this.labStatus.ForeColor = Color.Red;
                }
                else
                {
                    this.labStatus.ForeColor = Color.Green;
                }
                this.labStatus.Text = string.Format("导入结果：共选择：{0}用例，重复：{1}  成功：{2}！", importFailured + importSucceed, importFailured, importSucceed);
            }
            else
            {
                this.labStatus.ForeColor = Color.Red;
                this.labStatus.Text = "导入结果：导入失败，请先选中用例！";
            }
        }

        private void saveRowsToDataBase(int i)
        {
            DataGridViewRow myRow =new DataGridViewRow();
            myRow = this.dgv_CaseToImprot.Rows[i];
            string strCaseNO = myRow.Cells[1].Value.ToString();
            string strCaseName = myRow.Cells[2].Value.ToString();
            string strSuiteNO = myRow.Cells[3].Value.ToString();
            string strSuiteName = myRow.Cells[4].Value.ToString();
            //string strFatherModule = myRow.Cells[5].Value.ToString();
            //string strSubModule = myRow.Cells[6].Value.ToString();
            string strReqNO = myRow.Cells[5].Value.ToString();
            string strCaseLevel = myRow.Cells[6].Value.ToString();
            string strCasePrecondition = myRow.Cells[7].Value.ToString();
            string strCaseSteps = myRow.Cells[8].Value.ToString();
            string strCaseSamples = myRow.Cells[9].Value.ToString();
            string strCaseExcept = myRow.Cells[10].Value.ToString();
            //string strCaseActually = myRow.Cells[13].Value.ToString();
            string strCaceIfAuto = myRow.Cells[11].Value.ToString();
            //string strCaseTester = myRow.Cells[15].Value.ToString();
            //string strCaseTestDate = myRow.Cells[16].Value.ToString();
            string strAuthor = ManageDB.userName;
            string strEditDate = DateTime.Today.ToShortDateString().ToString();

            try
            {
                if (!myManageDB.checkItem("ceCaseNO", "CaseManager", "ceCaseNO", strCaseNO))
                {
                    myManageDB.InsertInto("insert into CaseManager(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceAuthor,ceEditDate,ceIfAuto,cePrecondition,ceSteps,ceSamples,ceExcept) values('" + this.tbSelectProject.Text + "','" + this.cbSelectStruct.Text + "','" + strSuiteNO + "','" + strSuiteName + "','" + strCaseNO + "','" + strCaseName + "','" + strReqNO + "','" + strCaseLevel + "','" + strAuthor + "','" + strEditDate + "','" + strCaceIfAuto + "','" + strCasePrecondition + "','" + strCaseSteps + "','" + strCaseSamples + "','" + strCaseExcept + "')");
                    myRow.DefaultCellStyle.BackColor = Color.LightGreen;
                    this.labStatus.ForeColor = Color.Green;
                    this.labStatus.Text = string.Format("导入结果：导入成功，用例“{0}”已成功导入！", strCaseNO);
                    importSucceed++;
                }
                else
                {
                    myRow.DefaultCellStyle.BackColor = Color.Red;
                    this.labStatus.ForeColor = Color.Red;
                    this.labStatus.Text = string.Format("导入结果：导入失败，用例“{0}”已存在，无需重复导入！", strCaseNO);
                    importFailured++;
                }                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            ToolSelectProject myToolCaseSelectProject = new ToolSelectProject();
            myToolCaseSelectProject.Show();
            myToolCaseSelectProject.SetSelectProjectName += new SetSelectProject(this.d_SetProjectName);
            myToolCaseSelectProject.SetSelectProjectStruct += new SetSelectProject(this.d_SetProjectStruct);
            myToolCaseSelectProject.SetSelectProjectVersion += new SetSelectProject(this.d_SetProjectVersion);
        }

        private void d_SetProjectName()
        {
            this.tbSelectProject.Text = ToolSelectProject.seletedProjectName;
        }

        private void d_SetProjectStruct()
        {
            string xmlContent = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", ToolSelectProject.seletedProjectNO);
            if (xmlContent != null && xmlContent != "")
            {
                StringReader myReader = new StringReader(xmlContent);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myProjectStruct = new LoadXml();
                this.cbSelectStruct.Items.Clear();
                myProjectStruct.loadXmlToComBox(xmlDoc.DocumentElement, this.cbSelectStruct);
            }
        }

        private void linkSelectAllRegion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setAllRegionRowCheckedValue(e, true);
        }

        private void linkSelectInvertRegion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setAllRegionRowCheckedValue(e, false);
        }

        private void d_SetProjectVersion()
        {
            //用例暂不含此项
        }
    }
}
