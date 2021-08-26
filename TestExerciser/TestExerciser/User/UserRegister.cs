using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using TestExerciser.Logic;


namespace TestExerciser.User
{
    public partial class UserRegister : Form
    {
        public static string strCheckCode = null;
        public static string userAccount = null;
        public static string userPasswd = null;
        public static string userName =null;
        public static string userEmailAddress = null;

        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            UserLogin myLogin = new UserLogin();
            myLogin.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {           
            myRegisterFunc();           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myCancelFunc();
        }

        private void UserRegister_KeyDown(object sender, KeyEventArgs e)
        {
            myLoginKeyDown(sender, e);
        }

        private void myRegisterFunc()
        {
            ManageDB myManageDB = new ManageDB();
            RegexInfo myLoginInfo = new RegexInfo();
            this.txtStatus.ForeColor = Color.Blue;
            this.txtStatus.Text = "注册信息：注册中...";
            Application.DoEvents();         

            if (this.txtUserName.Text != "" && this.txtPasswd.Text != "" && this.txtConfirmPassWD.Text!="" & txtEmailAddress.Text!="" && this.txtUserFullName.Text!="")
            {
                if (myLoginInfo.isUserNameFair(this.txtUserName.Text))
                {
                    if (!myManageDB.checkUserAccountDuplicate(this.txtUserName.Text))
                    {
                        if (this.txtPasswd.Text == this.txtConfirmPassWD.Text)
                        {
                            if (myLoginInfo.isPasswdSecurity(this.txtPasswd.Text))
                            {
                                if (myLoginInfo.isMailAddress(this.txtEmailAddress.Text))
                                {
                                    userAccount = this.txtUserName.Text;
                                    userPasswd = this.txtPasswd.Text;
                                    userName = this.txtUserFullName.Text;
                                    userEmailAddress = this.txtEmailAddress.Text;
                                    verificationReg();
                                    this.Visible = false;
                                    this.Close();
                                    UserAuthentication myAuthentication = new UserAuthentication();
                                    myAuthentication.Show();
                                }
                                else
                                {
                                    this.txtStatus.ForeColor = Color.Red;
                                    this.txtStatus.Text = "注册信息：注册失败，请正确填写邮箱格式！";
                                }
                            }
                            else
                            {
                                this.txtStatus.ForeColor = Color.Red;
                                this.txtStatus.Text = "注册信息：注册失败！密码为含数字、字母6-20位以上字符！";
                            }
                        }
                        else if (myManageDB.checkUserAccountDuplicate(this.txtUserName.Text))
                        {
                            this.txtStatus.ForeColor = Color.Red;
                            this.txtStatus.Text = "注册信息：注册失败，密码不一致！";                            
                        }
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "注册信息：注册失败，用户名已存在！";
                    }               
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "注册信息：注册失败，用户名为含数字、字母的6-20位字符！";
                }
                
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "注册信息：注册失败，所有项均不能为空！";
            }
        }

        private void myCancelFunc()
        {
            this.Visible = false;
            this.Close();
        }

        private void myLoginKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myRegisterFunc();
            }
        }

        private void verificationReg()
        {
            strCheckCode = GenerateCheckCodeStr(150) + GenerateCheckCodeNO(100);
            SendMail mail = new SendMail();
            mail.mailFrom = "TestExerciser@163.com";
            mail.mailPwd = "admin123";
            mail.mailSubject = "TestExerciser自动化测试工具注册身份验证";
            mail.mailBody = "用户身份验证信息：\r\n\r\n\r\n用户名：\r\n" + this.txtUserName.Text + "\r\n用户姓名：\r\n" + this.txtUserFullName.Text + "\r\n用户邮箱：\r\n" + this.txtEmailAddress.Text + "\r\n验证信息：\r\n" + strCheckCode;
            mail.isbodyHtml = false;
            mail.host = "smtp.163.com";
            mail.mailToArray = new string[] { "TestExerciser@outlook.com", this.txtEmailAddress.Text};
            mail.mailCcArray = new string[] {};
            if (mail.Send())
            {
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "注册信息：注册请求发送成功，待管理员审批！";
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "注册信息：注册请求发送失败，请重新注册！";
            }
        }

        private int rep = 0;
        public string GenerateCheckCodeNO(int codeCount)
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + this.rep;
            this.rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> this.rep)));
            for (int i = 0; i < codeCount; i++)
            {
                int num = random.Next();
                str = str + ((char)(0x30 + ((ushort)(num % 10)))).ToString();
            }
            return str;
        }

        public string GenerateCheckCodeStr(int codeCount)
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + this.rep;
            this.rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> this.rep)));
            for (int i = 0; i < codeCount; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }
    }
}
