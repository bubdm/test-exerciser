using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace TestExerciser.User
{
    public partial class UserSelectDB : Form
    {

        public static string strDataSource = "Data Source=";
        public static string sqlExpress = "SQLEXPRESS";
        public static string strconLocal = @".\SQLEXPRESS";
        public static string strcon = null;

        public UserSelectDB()
        {
            InitializeComponent();
            this.rdbServer.Checked = true;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            mySelectFunc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void UserSelectDB_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void mySelectFunc()
        {
            if (this.rdbServer.Checked == true)
            {
                if (this.stbServerDBPath.Text != "")
                {
                    //配置为远程服务器上的数据库 
                    bool foundMatch = false;
                    try
                    {
                        foundMatch = Regex.IsMatch(this.stbServerDBPath.Text, @"\A(?:(?:25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\z");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (foundMatch)
                    {
                        strcon = this.stbServerDBPath.Text.ToString();
                        this.txtStatus.ForeColor = Color.Green;
                        this.txtStatus.Text = "设置信息：设置成功，更改为远程服务器数据库连接！";
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "设置信息：设置失败，请填写有效的IP地址！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "设置信息：设置失败，请填写远程服务器上数据库文件路径！";
                }
            }
            else if (rdbLocal.Checked == true)
            {
                strcon = strconLocal;
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "设置信息：设置成功，更改为本地数据库连接！";
            }
            if (strcon != null)
            {               
                Properties.Settings.Default.dataSource = strDataSource + strcon;
                Properties.Settings.Default.ConnectionString = Properties.Settings.Default.dataSource + Properties.Settings.Default.ConnectionParas;
                Properties.Settings.Default.ServerName = this.stbServerDBPath.Text;
                Properties.Settings.Default.Save();
            }            
        }

        private void rdbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServer.Checked == true)
            {
                this.stbServerDBPath.Enabled = true;
                this.stbServerDBPath.Focus();
            }
        }

        private void rdbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLocal.Checked == true)
            {
                this.stbServerDBPath.Enabled = false;
                this.rdbLocal.Focus();
            }
        }

        private void myCancelFunc()
        {
            this.Visible = false;
            UserLogin myLogin = new UserLogin();
            myLogin.Visible = true;
        }

        private void UserSelectDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCancelFunc();
        }
    }
}
