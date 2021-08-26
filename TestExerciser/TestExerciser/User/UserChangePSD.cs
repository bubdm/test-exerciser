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
    public partial class UserChangePSD : Form
    {
        public UserChangePSD()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            changeFunc();
        }

        private void changeFunc()
        {
            this.txtStatus.ForeColor = Color.Blue;
            this.txtStatus.Text = "修改信息：正在修改...";
            Application.DoEvents();
            RegexInfo myLoginInfo = new RegexInfo();
            if (this.txtPasswd.Text != "" && this.txtChangeTo.Text != "")
            {
                if (this.txtPasswd.Text == this.txtChangeTo.Text)
                {
                    if (myLoginInfo.isPasswdSecurity(this.txtChangeTo.Text))
                    {
                        ManageDB myManageDB = new ManageDB();
                        myManageDB.UpdateDB("UserManager","[userPassWord]", this.txtChangeTo);
                        TimeDelay myTimeDelay = new TimeDelay();
                        this.btnOK.Enabled = false;
                        this.btnCancel.Enabled = false;
                        myTimeDelay.restartDelay(3, this.txtStatus, "修改信息：修改成功！", "请重新登录！");
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "修改信息：修改失败！密码为含数字、字母6位以上字符！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "修改信息：修改失败，密码输入不一致！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "修改信息：修改失败，所有项不能为空！";
            }
        }

        private void UserChangePSD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeFunc();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
