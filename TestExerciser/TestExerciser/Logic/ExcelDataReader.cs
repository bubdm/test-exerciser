using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using TestExerciser.Data;

namespace TestExerciser
{
    class ExcelDataReader
    {
        public static string myExcelName = "";
        DataSet ds = new DataSet();
        public System.Data.DataTable GetDataFromExcelToDT()
        {
            bool hasTitle = true;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.Cancel) return null;
            var filePath = openFile.FileName;
            myExcelName = Path.GetFileName(filePath);
            string fileType = Path.GetExtension(filePath);
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

                MessageBox.Show("数据绑定Excel失败!失败原因：" + ex.Message, "提示信息", MessageBoxButtons.OK,

                    MessageBoxIcon.Information);

                return null;

            }
        }

        public string readCell(int rawNo, int columnNo)
        {
            this.GetDataFromExcelToDT();
            return ds.Tables[0].Rows[rawNo][columnNo].ToString();
        }

    }
}
