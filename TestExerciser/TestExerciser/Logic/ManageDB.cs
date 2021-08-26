using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TestExerciser.User;
using System.IO;


namespace TestExerciser.Logic
{
    class ManageDB
    {
        public static string userName = null;
        public static string userEmailAddress = null;
        public static string updateDBStatus =null;
       
        SqlConnection mycon = null;
        SqlDataReader myReader = null;
      
        public static string strcon = Properties.Settings.Default.ConnectionString;
        public static List<ListItem> items = new List<ListItem>();

        public static  ListItem listItem;


        public bool checkConnection()
        {
            bool falg = false;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                if (mycon.State == ConnectionState.Open)
                {
                    falg = true;
                }
                   
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
            return falg;
        }

        /// <summary>
        /// 获取数据表中的特定值
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="valueA"></param>
        /// <param name="rowB"></param>
        /// <param name="valueB"></param>
        /// <returns></returns>
        public string getDataFromCell(string row,string table,string rowA,string valueA,string rowB,string valueB)
        {
            string mycell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'" + "AND" + "" + rowB + "=" + "'" + valueB + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        mycell = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return mycell;
        }

        /// <summary>
        /// 获取数据表中的特定值
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="valueA"></param>
        /// <returns></returns>
        public string getDataFromCell(string row, string table, string rowA, string valueA)
        {
            string mycell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        mycell = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return mycell;
        }

        public string[] getDataFromCells(string sql)
        {
            string[] myCells = null;
            List<string> myCellsList = new List<string>();
            string myCell = "";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(sql, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        myCell = Convert.ToString(myReader[0]);
                        myCellsList.Add(myCell);
                        myCells = myCellsList.ToArray();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return myCells;
        }

        public string[] getDataFromCells(string row, string table)
        {
            string [] myCells = null;
            List<string> myCellsList = new List<string>(); 
            string myCell = "";
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        myCell = Convert.ToString(myReader[0]);
                        myCellsList.Add(myCell);
                        myCells = myCellsList.ToArray();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return myCells;
        }

        public string[] getDataFromCells(string row, string table, string rowA, string valueA)
        {
            string[] myCells = null;
            List<string> myCellsList = new List<string>();
            string myCell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        myCell = Convert.ToString(myReader[0]);
                        myCellsList.Add(myCell);
                        myCells = myCellsList.ToArray();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return myCells;
        }

        public bool checkCoverReviewTo()
        {
            bool falg = false;
            string mySQL = "select userEmail from UserManager where userCoverReviewTo='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (userEmailAddress == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool checkReviewFrom()
        {
            bool falg = false;
            string mySQL = "select userEmail from UserManager where userReviewFrom='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (userEmailAddress == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }                                               
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool queryUserName(string userAccount,string passwd)
        {
            bool falg = false;
            string mySQL = "select userName from UserManager where userAccount=" + "'" + userAccount + "'" + "AND" + "[userPassWord]=" + "'" + passwd + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                    while (myReader.Read())
                    {
                        userName = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool queryEmailAddress(string userAccount, string passwd)
        {
            bool falg = false;
            string mySQL = "select userEmail from UserManager where userAccount=" + "'" + userAccount + "'" + "AND" + "[userPassWord]=" + "'" + passwd + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                    while (myReader.Read())
                    {
                        userEmailAddress = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool checkUserAccountDuplicate(string userAccount)
        {
            bool falg = false;
            string mySQL = "select ID from UserManager where userAccount=" + "'" + userAccount + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool checkAutoReviewTo()
        {
            bool falg = false;
            string mySQL = "select userEmail from UserManager where userAutoReviewTo='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (userEmailAddress == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql"></param>
        public void UpdateDB(string sql)
        {
            mycon = new SqlConnection(strcon);
            mycon.Open();
            SqlCommand mycomm = new SqlCommand(sql, mycon);
            mycomm.Connection = mycon;
            mycomm.CommandText = sql;
            if (mycomm.ExecuteNonQuery() > 0)
            {
                updateDBStatus = "数据更新成功！";
            }
            else
            {
                updateDBStatus = "数据更新失败！";
            }
            mycomm.Dispose();
            mycon.Close();
            mycon.Dispose();
        }


        /// <summary>  
        /// 把文件存入数据库  
        /// </summary>  
        /// <param name="filePaths">文件路径（含文件名）</param>  
        /// <returns>存入是否成功</returns>  
        public bool StoreFiles(string[] filePaths,string bugId)
        {
            try
            {
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string filePath = filePaths[i];
                    string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    mycon = new SqlConnection(strcon);
                    mycon.Open();
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, (int)fs.Length);
                    string strSql = "insert into FileAttachment(fileID,fileName,filePath,fileData,bugID) values(@FileID,@FileName,@FilePath,@FileData,@BugId)";
                    using (SqlCommand cmd = new SqlCommand(strSql, mycon))
                    {
                        cmd.Parameters.Add("@FileID", SqlDbType.Text);
                        cmd.Parameters.Add("@FileName", SqlDbType.Text);
                        cmd.Parameters.Add("@FilePath", SqlDbType.Text);
                        cmd.Parameters.Add("@FileData", SqlDbType.Binary);
                        cmd.Parameters.Add("@BugId", SqlDbType.Text);
                        cmd.Parameters["@FileID"].Value = GUID.getGUID("File");
                        cmd.Parameters["@FileName"].Value = fileName;
                        cmd.Parameters["@FilePath"].Value = filePath;
                        cmd.Parameters["@FileData"].Value = bytes;
                        cmd.Parameters["@BugId"].Value = bugId;
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>  
        /// 将数据库中数据写入文件  
        /// </summary>  
        /// <param name="fileName">用于查找数据的文件名</param>  
        /// <param name="destFilePath">目标文件路径（含文件名）</param>  
        /// <returns>写入是否成功</returns>  
        public bool WriteFromDBtoFile(string bugId, string fileId, string destFilePath)
        {
            FileStream fs = null;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                string strSql = String.Format("select fileData from FileAttachment where fileID = '{0}'and bugID = '{1}'", fileId, bugId);
                SqlCommand cmd = new SqlCommand(strSql, mycon);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                byte[] bytes = (byte[])dr[0];
                fs = new FileStream(destFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Write(bytes, 0, bytes.Length);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }


        /// <summary>
        /// 更新1个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="txtChangeTo"></param>
        public void UpdateDB(string table, string row, Control txtChangeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + txtChangeTo.Text + "'" + " where userAccount='" + UserLogin.pubUserName + "'");
        }

        /// <summary>
        /// 更新1个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="changeTo"></param>
        public void UpdateDB(string table, string row, string changeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + changeTo + "'");
        }

        /// <summary>
        /// 更新2个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="changeTo"></param>
        /// <param name="otherRow"></param>
        /// <param name="otherChangeTo"></param>
        public void UpdateDB(string table, string row, string changeTo,string otherRow,string otherChangeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + changeTo + "'" + " where " + otherRow + "='" + otherChangeTo + "'");
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sql"></param>
        public void DeleteDB(string sql)
        {
            mycon = new SqlConnection(strcon);
            mycon.Open();
            SqlCommand mycomm = new SqlCommand(sql, mycon);
            mycomm.Connection = mycon;
            mycomm.CommandText = sql;
            if (mycomm.ExecuteNonQuery() > 0)
            {
                updateDBStatus = "数据删除成功！";
            }
            else
            {
                updateDBStatus = "数据删除失败！";
            }
            mycomm.Dispose();
            mycon.Close();
            mycon.Dispose();
        }

        /// <summary>
        /// 删除一行数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="txtChangeTo"></param>
        public void DeleteDB(string table, string row, string txtChangeTo)
        {
            UpdateDB("delete from " + table + " where " + row + "='" + txtChangeTo + "'");
        }

        /// <summary>
        /// 用户判断值是否存在
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public bool checkItem(string row, string table, string dataItem)
        {
            bool falg = false;
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (dataItem == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        /// <summary>
        /// 用以判断值是否存在
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public string checkItems(string row, string table, string rowA, string dataItem)
        {
            string item = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + dataItem + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        item = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return item;
        }

        public bool checkItem(string row, string table, string rowA, string dataItem)
        {
            bool flag = false;
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + dataItem + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    flag = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return flag;
        }

        public bool checkItem(string row, string table, string valueA, string rowB, string valueB)
        {
            bool falg = false;
            string mySQL = "select " + row + " from " + table + " where " + rowB + "=" + "'" + valueB + "'";

            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (valueA == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myReader != null)
                {
                    myReader.Close();
                    mycon.Close();
                }
            }
            return falg;
        }

        public bool selectItems(ComboBox comBox, string table)
        {
            bool falg = false;
            string mySQL = "select * from UserManager";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    listItem = new ListItem(row["userEmail"].ToString(), row["userName"].ToString() + "(" + row["userEmail"].ToString() + ")");
                    comBox.Items.Add(listItem);
                }
                comBox.DisplayMember = "Text";
                comBox.ValueMember = "Value";
                listItem = (ListItem)comBox.SelectedItem;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return falg;
        }

        public int countNum(string row, string table)
        {
            int count = 0;
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow r in mydt.Rows)
                {
                    count = count + 1;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return count;
        }



        /// <summary>
        /// 检查用户名称是否存在
        /// </summary>
        /// <param name="userAccount"></param>
        /// <returns></returns>
        public bool checkUserAccount(string userAccount)
        {
            bool falg = false;
            string mySQL = "select ID from UserManager where userAccount=" + "'" + userAccount +"'";
   
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myReader != null)
                {
                    myReader.Close();
                    mycon.Close();
                }                
            }
            return falg;
        }

        public bool userMailToResetPassword(string userAccount, string userEmail)
        {
            bool falg = false;
            string mySQL = "select ID from UserManager where userAccount=" + "'" + userAccount + "'" + "AND" + "[userEmail]=" + "'" + userEmail + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }
        
        public bool showTeamMembersFullName()
        {
            bool falg = false;
            string mySQL = "select userName from UserManager";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();
            }
            return falg;
        }   

        public bool clearList(ComboBox comBox,string table)
        {
            bool falg = false;
            string mySQL = "select * from UserManager";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    comBox.Items.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return falg;
        }

        public void InsertInto(string sql)
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycomm = new SqlCommand(sql, mycon);
                mycomm.Connection = mycon;
                mycomm.CommandText = sql;
                if (mycomm.ExecuteNonQuery() > 0)
                {
                    updateDBStatus = "数据添加成功！";
                }
                else
                {
                    updateDBStatus = "数据添加失败！";
                }
                mycomm.Dispose();
                mycon.Close();
                mycon.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet getDataSet(string sql)
        {
            DataSet myDataSet = new DataSet();
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                myda.Fill(myDataSet);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return myDataSet;
        }

        public SqlDataReader getDataReader(string sql)
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(sql, mycon);
                myReader = mycom.ExecuteReader();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();
            }
            return myReader;
        }


        public void saveXML(string sql)
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(sql, mycon);
                myReader = mycom.ExecuteReader();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();
            }
        }

    }
}
