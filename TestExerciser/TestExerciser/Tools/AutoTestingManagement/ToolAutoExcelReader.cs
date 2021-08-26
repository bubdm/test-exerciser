using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

using System.Text.RegularExpressions;
using TestExerciser.Data;
using TestExerciser.Logic;

namespace TestExerciser.Tools.AutoTestingManagement
{
    public partial class ToolAutoExcelReader : Form
    {
        DataSet ds = new DataSet();
        public bool addToProj = false;
        string excelFileName = null;
        bool getDataFormExcel = false;
        bool writets = true;
        bool writetc = true;
        int totalTCNO = 0;
        int successTCNO = 0;


        public ToolAutoExcelReader()
        {
            InitializeComponent();     
             //this.MaximizeBox = false;//使最大化窗口失效
             //下一句用来禁止对窗口大小进行拖拽
             this.FormBorderStyle = FormBorderStyle.FixedSingle;
             this.tstbCreateScript.Enabled = false;
             this.tstbAddToProj.Enabled = false;
        }

        /// <summary>
        /// 从Excel获取数据
        /// </summary>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        private  System.Data.DataTable GetDataFromExcelToDT()
        {
            bool hasTitle = true;
            if (openExcelFileDialog.ShowDialog() == DialogResult.OK)
            {
                getDataFormExcel = true;
                var filePath = openExcelFileDialog.FileName;
                excelFileName = Path.GetFileName(filePath);
                string fileType = System.IO.Path.GetExtension(filePath);
                if (string.IsNullOrEmpty(fileType)) return null;

                try
                {
                    string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.{0}.0;" +
                                                  "Extended Properties=\"Excel {1}.0;HDR={2};IMEX=1;\";" +
                                                  "data source={3};",
                                                  (fileType == ".xls" ? 4 : 12), (fileType == ".xls" ? 8 : 12), (hasTitle ? "Yes" : "NO"), filePath);

                    using (OleDbConnection myConn = new OleDbConnection(strCon))
                    {
                        myConn.Open();
                        System.Data.DataTable sheetsName = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                        string firstSheetName = sheetsName.Rows[1][2].ToString(); //得到第一个sheet的名字
                        string strCom = string.Format(" SELECT * FROM [{0}A3:P{1}]", (firstSheetName), Properties.Settings.Default.readColumnNo);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                        myCommand.Fill(ds, firstSheetName);
                    }
                    if (ds == null || ds.Tables.Count <= 0) return null;
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据绑定Excel失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;

                }
            }
            else
            {
                getDataFormExcel = false;
            }
            return null;
        }

        /// <summary>
        /// 将Excel数据读取到DataGridView容器按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstbCreateDB_Click(object sender, EventArgs e)
        {
            dgvReadDB.DataSource = GetDataFromExcelToDT();
            if (getDataFormExcel)
            {
                this.tstbCreateDB.Enabled = false;
                this.tstbCreateScript.Enabled = true;
                this.tstbTestCaseName.Text = excelFileName;
            }   
        }

        /// <summary>
        /// 生成脚本按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstbCreateScript_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count != 0)
            {
                if (selectWorkspace())
                {
                    createdScript();
                    this.tstbCreateScript.Enabled = false;
                }             
            }
            else
            {
                this.tstbCreateScript.Enabled = false;
            }
        }


        /// <summary>
        /// 选择工作区
        /// </summary>
        private bool selectWorkspace()
        {
            bool flag = false;
            if (selectWorkspaceBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 读取单元格
        /// </summary>
        /// <param name="rawNo"></param>
        /// <param name="columnNo"></param>
        /// <returns></returns>
        private string readCell(int rawNo,int columnNo)
        {
          return  ds.Tables[0].Rows[rawNo][columnNo].ToString();
        }

        string testSuiteNO = null;
        string testSuiteFilePath = null;

        string[] testCaseFilePath;
        List<string> testCaseFilePathList = new List<string>();

        string[] testCaseNO;
        List<string> testCaseNOList = new List<string>(); 

        string[] testCaseName;
        List<string> testCaseNameList = new List<string>(); 

        string[] testCaseLevel;
        List<string> testCaseLevelList = new List<string>();

        string[] testCasepreConditions;
        List<string> testCasepreConditionsList = new List<string>(); 

        string[] testCaseSteps;
        List<string> testCaseStepsList = new List<string>(); 

        string[] testCaseSamp;
        List<string> testCaseSampList = new List<string>();

        string[] testCaseExpect;
        List<string> testCaseExpectList = new List<string>(); 

        string[] testCaseResults;
        List<string> testCaseResultsList = new List<string>(); 

        string[] testCaseIfAuto;
        List<string> testCaseIfAutoList = new List<string>(); 

        string[] testCaseDef;
        List<string> testCaseDefList = new List<string>();


        /// <summary>
        /// 开始写脚本
        /// </summary>
        private void createdScript()
        {
            int i_suite = 3;
            int i_caseNO = 5;
            int i_caseName = 6;
            int i_caseLevel = 7;
            int i_casePreCondition = 8;
            int i_caseSteps = 9;
            int i_caseSamp = 10;
            int i_caseExpect = 11;
            int i_caseResult = 12;
            int i_caseIfAuto = 13;
            
            for (int i = 0; i < this.ds.Tables[0].Rows.Count; i++)
            {
                this.tstbCreateScriptProgress.Maximum = this.ds.Tables[0].Rows.Count;
                string fmFolder = null;
                string slaMFolder = null;
                string workSpace = selectWorkspaceBrowserDialog.SelectedPath;

                if (readCell(i, 0) != null && readCell(i, 0)!="")
                {
                    fmFolder = workSpace + "\\" + readCell(i, 0).ToString().Replace("\n", "");
                    createFolder(fmFolder);
                    if (readCell(i, 1) != null && readCell(i, 1) != "")
                    {
                        slaMFolder = fmFolder + "\\" + readCell(i, 1).ToString().Replace("\n", "");
                        createFolder(slaMFolder);
                    }
                    else
                    {
                        MessageBox.Show("请填写子模块名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                    }

                    for (int j = 1; j < this.ds.Tables[0].Rows.Count - (i + 1); j++)
                    {
                        if (readCell(i + j, i_suite) != null && readCell(i + j, i_suite) != "")
                        {
                            string tsFolder = slaMFolder + "\\" + readCell(i + j, i_suite).ToString().Replace("\n", "");
                            createFolder(tsFolder);
                            createFile(tsFolder + "\\" + readCell(i + j, i_suite).ToString().Replace("\n", "") + ".ts");
                            testSuiteNO = readCell(i + j, i_suite).ToString().Replace("\n", "");
                            testSuiteFilePath = tsFolder + "\\" + readCell(i + j, i_suite).ToString().Replace("\n", "") + ".ts";

                            for (int k = j + 1; k < this.ds.Tables[0].Rows.Count - (i + j + 1); k++)
                            {
                                if (readCell(i + k, i_caseNO) != null && readCell(i + k, i_caseNO) != "")
                                {
                                    totalTCNO++;
                                    createFile(tsFolder + "\\" + readCell(i + k, i_caseNO).ToString().Replace("\n", "") + ".tc");

                                    testCaseFilePathList.Add(tsFolder + "\\" + readCell(i + k, i_caseNO).ToString().Replace("\n", "") + ".tc");
                                    testCaseFilePath = testCaseFilePathList.ToArray();


                                    testCaseNOList.Add(readCell(i + k, i_caseNO).ToString().Replace("\n", ""));
                                    testCaseNO = testCaseNOList.ToArray();


                                    testCaseNameList.Add(readCell(i + k, i_caseName).ToString().Replace("\n", ""));
                                    testCaseName = testCaseNameList.ToArray();


                                    testCaseLevelList.Add(readCell(i + k, i_caseLevel).ToString().Replace("\n", ""));
                                    testCaseLevel = testCaseLevelList.ToArray();


                                    testCasepreConditionsList.Add(readCell(i + k, i_casePreCondition).ToString().Replace("\n", ""));
                                    testCasepreConditions = testCasepreConditionsList.ToArray();


                                    testCaseStepsList.Add(readCell(i + k, i_caseSteps).ToString().Replace("\n", ""));
                                    testCaseSteps = testCaseStepsList.ToArray();


                                    testCaseSampList.Add(readCell(i + k, i_caseSamp).ToString().Replace("\n", ""));
                                    testCaseSamp = testCaseSampList.ToArray();


                                    testCaseExpectList.Add(readCell(i + k, i_caseExpect).ToString().Replace("\n", ""));
                                    testCaseExpect = testCaseExpectList.ToArray();


                                    testCaseResultsList.Add(readCell(i + k, i_caseResult).ToString().Replace("\n", ""));
                                    testCaseResults = testCaseResultsList.ToArray();


                                    testCaseIfAutoList.Add(readCell(i + k, i_caseIfAuto).ToString().Replace("\n", ""));
                                    testCaseIfAuto = testCaseIfAutoList.ToArray();


                                    testCaseDefList.Add(Regex.Match(readCell(i + k, i_caseNO).ToString().Replace("\n", ""), "[]^[0-9]{3}$").Value);
                                    testCaseDef = testCaseDefList.ToArray();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //自动编写脚本
                            writeTSFile(testSuiteFilePath);
                            if (testCaseNO != null)
                            {
                                writeTCFile(testCaseFilePath);

                                testCaseFilePathList.Clear();
                                testCaseFilePath = testCaseFilePathList.ToArray();

                                testCaseNOList.Clear();
                                testCaseNO = testCaseNOList.ToArray();

                                testCaseNameList.Clear();
                                testCaseName = testCaseName.ToArray();

                                testCaseLevelList.Clear();
                                testCaseLevel = testCaseLevelList.ToArray();

                                testCasepreConditionsList.Clear();
                                testCasepreConditions = testCasepreConditionsList.ToArray();

                                testCaseStepsList.Clear();
                                testCaseSteps = testCaseName.ToArray();

                                testCaseSampList.Clear();
                                testCaseSamp = testCaseSampList.ToArray();

                                testCaseExpectList.Clear();
                                testCaseExpect = testCaseExpectList.ToArray();

                                testCaseNameList.Clear();
                                testCaseName = testCaseName.ToArray();

                                testCaseResultsList.Clear();
                                testCaseResults = testCaseResultsList.ToArray();

                                testCaseIfAutoList.Clear();
                                testCaseIfAuto = testCaseIfAutoList.ToArray();

                                testCaseDefList.Clear();
                                testCaseDef = testCaseDefList.ToArray();
                            }
                            else
                            {
                                writetc = false;
                            }
                        }
                        else
                        {
                            //break;
                        }
                    }
                }

                if (this.tstbCreateScriptProgress.Value < this.tstbCreateScriptProgress.Maximum)
                {
                    this.tstbCreateScriptProgress.Value++;
                }              
            }
            if (writetc && writets)
            {
                this.tstbScriptStatus.Image = TestExerciser.Properties.Resources.progress_done;
                this.tstbAddToProj.Enabled = true;
                string msg = string.Format("脚本生成结果： 共{0}个脚本，成功{1}个，失败{2}个。项目路径为：{3}", totalTCNO,successTCNO,totalTCNO-successTCNO, selectWorkspaceBrowserDialog.SelectedPath);
                MessageBox.Show(msg,"消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path"></param>
        private void createFolder(string path)
        {
            DirectoryInfo ds = Directory.CreateDirectory(path);
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="path"></param>
        private void createFile(string path)
        {
            FileStream fs = File.Create(path);
            fs.Dispose();
        }

        /// <summary>
        /// 写ts文件
        /// </summary>
        /// <param name="tsFilePath"></param>
        private void writeTSFile(string tsFilePath)
        {
            if (testSuiteNO != null && testCaseName !=null)
            {
                if (File.Exists(tsFilePath))
                {
                    FileStream fsts = new FileStream(tsFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter swts = new StreamWriter(fsts);
                    swts.WriteLine("'''"); ;
                    swts.WriteLine("测试集编号：");
                    swts.WriteLine("                    {0}", testSuiteNO);
                    swts.WriteLine("测试用例编号：");

                    for (int i = 0; i < testCaseName.Length; i++)
                    {
                        swts.WriteLine("                    测试用例{0}：{1}；+ {2}", i + 1, testCaseNO[i],testCaseName[i]);
                    }
                    swts.WriteLine("作 者：");
                    swts.WriteLine("                    {0}", ManageDB.userName);
                    swts.WriteLine("编写日期：");
                    swts.WriteLine("                    {0}", DateTime.Now);
                    swts.WriteLine("修改日期：");
                    swts.WriteLine("");
                    swts.WriteLine("'''");
                    swts.WriteLine("");
                    swts.WriteLine("");
                    swts.WriteLine("import unittest,ssas.product.bs");
                    swts.WriteLine("from unittest.case import TestCase;");
                    swts.WriteLine("from ssas.logic import DataEncap, operate, expect;");
                    swts.WriteLine("import time");
                    swts.WriteLine("");
                    swts.WriteLine("");
                    swts.WriteLine("class MyTestSuite(unittest.TestCase):");
                    swts.WriteLine("    data_center = {");
                    for (int i = 0; i < testCaseName.Length; i++)
                    {
                        swts.WriteLine("            'case{0}':",i+1);
                        swts.WriteLine("            {");
                        swts.WriteLine("                'name': '{0}',", testCaseNO[i]);
                        swts.WriteLine("                'title': '{0}',", testCaseName[i]);
                        swts.WriteLine("                'level': '{0}',", testCaseLevel[i]);
                        swts.WriteLine("                'result': {},");
                        swts.WriteLine("                'input':");
                        swts.WriteLine("                    {");
                        swts.WriteLine("                        'step1': '',");
                        swts.WriteLine("                        'step2': '',");
                        swts.WriteLine("                    },");
                        swts.WriteLine("                'expect':");
                        swts.WriteLine("                    {");
                        swts.WriteLine("                        'step1': '',");
                        swts.WriteLine("                        'step2': '',");
                        swts.WriteLine("                    }");
                        swts.WriteLine("            },");
                        swts.WriteLine("        # 测试用例{0}：{1}；{2}", i, testCaseNO[i], testCaseName[i]);
                    }
                    swts.WriteLine("    }");
                    swts.WriteLine("    def setUp(self):");
                    swts.WriteLine("        operate('<预置条件><1.0>预置条件1')");
                    swts.WriteLine("        rs = ssas.xx.xx.xx(self)");
                    swts.WriteLine("        expect('<预置条件><1.1>预置条件1预期结果>')");
                    swts.WriteLine("        TestCase.assertEqual(self, rs, True)");
                    swts.WriteLine("");
                    for (int i = 0; i < testCaseName.Length; i++)
                    {
                        swts.WriteLine("    def test{0}(self):", testCaseDef[i]);
                        swts.WriteLine("        operate('<1.0>操作步骤1')");
                        swts.WriteLine("        rs = ssas.xx.xx.xx(self, (DataEncap(self.data_center[{0}]).input.step1))");
                        swts.WriteLine("        expect('<1.1操作步骤1预期结果>')");
                        swts.WriteLine("        TestCase.assertEqual(self, rs, DataEncap(self.data_center[{0}]).expect.step1)");
                        swts.WriteLine("");
                        swts.WriteLine("");
                    }

                    swts.WriteLine("    def tearDown(self):");
                    swts.WriteLine("        operate('恢复')");
                    swts.WriteLine("        ssas.bs.ProjectManager.kill_product(self)");
                    swts.WriteLine("");
                    swts.WriteLine("");
                    swts.WriteLine("if __name__ == '__main__':");
                    swts.WriteLine("    unittest.main()");
                    swts.Close();
                    
                }
                else
                {
                    writets = false;
                    MessageBox.Show("向TS文件中写脚本时出现异常！请重新尝试！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 写tc文件
        /// </summary>
        /// <param name="tcFilePath"></param>
        private void writeTCFile(string [] tcFilePaths)
        {
            if (testSuiteNO != null && testCaseNO != null)
            {
                for (int i=0;i<tcFilePaths.Length;i++)
                {
                    if (File.Exists(tcFilePaths[i]))
                    {
                        FileStream fstc = new FileStream(tcFilePaths[i], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        StreamWriter swtc = new StreamWriter(fstc);
                        swtc.WriteLine("'''"); ;
                        swtc.WriteLine("测试集编号：");
                        swtc.WriteLine("                    {0}", testSuiteNO);
                        swtc.WriteLine("测试用例编号：");
                        swtc.WriteLine("                    {0}", testCaseNO[i]);
                        swtc.WriteLine("作 者：");
                        swtc.WriteLine("                    {0}", ManageDB.userName);
                        swtc.WriteLine("编写日期：");
                        swtc.WriteLine("                    {0}", DateTime.Now);
                        swtc.WriteLine("修改日期：");
                        swtc.WriteLine("");
                        swtc.WriteLine("'''");
                        swtc.WriteLine("");
                        swtc.WriteLine("");
                        swtc.WriteLine("if __name__ == '__main__':");
                        swtc.WriteLine("    unittest.main()");
                        swtc.Close();
                        successTCNO++;
                    }
                    else
                    {
                        writetc = false;
                        MessageBox.Show("向TC文件中写脚本时出现异常！请重新尝试！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            else
            {
                writetc = false;
            }    
        }

        public string selectedWorkspacePath()
        {
            return this.selectWorkspaceBrowserDialog.SelectedPath;
        }

        private void tstbAddToProj_Click(object sender, EventArgs e)
        {
            DialogResult makeSureMsg = MessageBox.Show("确定要导入工程吗！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (makeSureMsg == DialogResult.OK)
            {
                addToProj = true;
                this.tstbAddToProj.Enabled = false;
                DialogResult successMsg = MessageBox.Show("已成功添加到我的工程，请点击“确定”按钮，关闭ExcelReader！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (successMsg == DialogResult.OK)
                {
                    this.dgvReadDB.Dispose();
                    this.Close();
                }
            }   
        }

        private void tstbDownLoadExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wkb = app.Workbooks.Add(@"\\" + Properties.Settings.Default.ServerName + @"\DATA\用例模板.xlsx");
            app.Visible = true;
        }
    }
}
