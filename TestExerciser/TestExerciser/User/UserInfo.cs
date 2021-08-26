using System;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser.User
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void MainUserInfo_Load(object sender, EventArgs e)
        {
            ManageDB myManageDB = new ManageDB();
            myManageDB.queryEmailAddress(UserLogin.pubUserName,UserLogin.pubPasswd);
            myManageDB.queryUserName(UserLogin.pubUserName,UserLogin.pubPasswd);
            this.labUserName.Text = UserLogin.pubUserName;
            this.labFullName.Text = ManageDB.userName;
            this.labEmailAddress.Text = ManageDB.userEmailAddress;
        }

        private void linkChangeFullName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangeUserFullName myChangeUserFullName = new UserChangeUserFullName();
            myChangeUserFullName.Show();
        }

        private void linkChangeMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangeUserEmail myChangeUserEmail = new UserChangeUserEmail();
            myChangeUserEmail.Show();
        }
    }
}
