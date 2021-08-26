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

namespace TestExerciser.User
{
    public partial class UserResetPwd : Form
    {
        public UserResetPwd()
        {
            InitializeComponent();
        }

        private void myLoginFunc()
        {
            RegexInfo myLoginInfo = new RegexInfo();
            ManageDB myManageDB = new ManageDB();
            this.txtStatus.ForeColor = Color.Blue;
            this.txtStatus.Text = "重置信息：重置中...";
            Application.DoEvents();

            if (this.txtUserName.Text != "" && this.txtUserEmail.Text != "")
            {
                if (myManageDB.checkUserAccount(this.txtUserName.Text))
                {
                    if (myLoginInfo.isMailAddress(this.txtUserEmail.Text))
                    {
                        if (myManageDB.userMailToResetPassword(this.txtUserName.Text, this.txtUserEmail.Text))
                        {
                            TimeDelay myTimeDelay = new TimeDelay();
                            this.btnOK.Enabled = false;
                            this.btnCancel.Enabled = false;
                            myTimeDelay.closingCurrentWindowDelay(3, this.txtStatus,this, "重置信息：验证成功，即将开始重置...","");
                            UserChangePSD myUserChangePSD = new UserChangePSD();
                            myUserChangePSD.Show();
                        }
                        else
                        {
                            this.txtStatus.ForeColor = Color.Red;
                            this.txtStatus.Text = "重置信息：重置失败，请确认邮箱是否填写正确！";
                        }
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "重置信息：重置失败！邮箱地址不合法！";
                    }
                    
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "重置信息：重置失败，用户名不存在！";
                }

            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "重置信息：重置失败，用户名和邮箱均不能为空！";
            }
        }

        private void myCancelFunc()
        {
            this.Visible = false;
            UserLogin myLogin = new UserLogin();
            myLogin.Visible=true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            myLoginFunc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void UserResetPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myLoginFunc();
            }
        }

        private void UserResetPwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCancelFunc();
        }
    }
}
