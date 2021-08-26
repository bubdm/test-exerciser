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

using TestExerciser.Logic;

namespace TestExerciser.User
{
    public partial class UserAuthentication : Form
    {
        public static bool isFormClosed = false;

        public UserAuthentication()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AuthenticationFunc();
        }

        private void AuthenticationFunc()
        {
            if (this.richCheckStr.Text == UserRegister.strCheckCode)
            {
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "验证信息：验证成功！";
                Application.DoEvents();
                addDataToDB();
                TimeDelay myTimeDelay = new TimeDelay();
                this.btnOK.Enabled = false;
                this.btnCancel.Enabled = false;
                myTimeDelay.closingCurrentWindowDelay(3, this.txtStatus, this, "注册信息：注册成功！", "");
                //UserRegister myUserRegister = new UserRegister();                
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "验证信息：输入验证信息有误，请重新输入！";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void addDataToDB()
        {
            ManageDB myManageDB = new ManageDB();
            myManageDB.UpdateDB("insert into UserManager(userAccount,[userPassWord],userName,userEmail,userAdministrator) values ('" + UserRegister.userAccount + "','" + UserRegister.userPasswd + "','" + UserRegister.userName + "','" + UserRegister.userEmailAddress + "','False')");
        }

        private void UserAuthentication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthenticationFunc();
            }            
        }

    }
}
