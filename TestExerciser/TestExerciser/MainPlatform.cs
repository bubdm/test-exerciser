using System;
using System.Drawing;
using System.Windows.Forms;
using TestExerciser.Logic;
using TestExerciser.User;

namespace TestExerciser
{

    //定义委托
    public delegate void SetUserLoginForm(bool vis);
    public delegate void ShowMainPlatform();

    public partial class MainPlatform : Form
    {
        public static bool isMainPlatformClosed = false;

        //定义委托事件
        public event ShowMainPlatform ShowMainPlatformWhenClosed;

        ManageDB myManageDB = new ManageDB();


        public MainPlatform()
        {
            InitializeComponent();
        }

        private void 项目管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.FormClosed += subForm_FormClosed;     
            myMainProjectManager.Show();
        }

        private void 产品缺陷管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainBugManager myMainBugManager = new MainBugManager();
            myMainBugManager.FormClosed += subForm_FormClosed;
            myMainBugManager.Show();
        }

        private void 用例管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainCaseManager myMainCaseManager = new MainCaseManager();
            myMainCaseManager.FormClosed += subForm_FormClosed;
            myMainCaseManager.Show();
        }

        private void 自动化管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainAutoTesting myMainAutoTesting = new MainAutoTesting();
            myMainAutoTesting.FormClosed += subForm_FormClosed;
            myMainAutoTesting.Show();
        }

        private void 用户管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainUserManager myMainUserManager = new MainUserManager();
            myMainUserManager.FormClosed += subForm_FormClosed;
            myMainUserManager.Show();
        }

        private void 任务管理平台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainTaskManager myMainTaskManager = new MainTaskManager();
            myMainTaskManager.FormClosed += subForm_FormClosed;
            myMainTaskManager.Show();
        }


        public void d_SetMainPlatformWindowActive()
        {
            if (this.IsDisposed == true)
            {
                if (isMainPlatformClosed == true)
                {
                    ShowMainPlatformWhenClosed();
                }
            }
            else if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
            {
                this.Visible = true;
                //还原窗体显示    
                this.WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
            }
        }

        public void d_SetMainPlatformWindowVisableFalse()
        {
            this.Visible = false;
        }

        public void d_SetMainPlatformWindowClosed()
        {
            this.Visible = false;
            this.Close();
        }

        private void MainPlatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            isMainPlatformClosed = true;
        }

        private void MainPlatform_Load(object sender, EventArgs e)
        {
            this.登录ToolStripMenuItem.ForeColor = Color.Green;
            this.登录ToolStripMenuItem.Text = ManageDB.userName;
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo myUserInfo = new UserInfo();
            myUserInfo.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserChangePSD myChangePSD = new UserChangePSD();
            myChangePSD.Show();
        }

        private void 工作管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWorkManager myMainWorkProgress = new MainWorkManager();
            myMainWorkProgress.Show();
        }

        private void 个人笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Process p = new Process();
            //    p.StartInfo.FileName = Application.StartupPath + @"\TestExerciser.Diary.exe";
            //    p.Start();
            //    p.Close();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void 团队成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestExerciser.User.UserTeamMembers myUserTeamMembers = new TestExerciser.User.UserTeamMembers();
            myUserTeamMembers.Show();
        }

        static int x;
        static int y;
        private void windowHidingEffects()
        {
            this.WindowState = FormWindowState.Normal;
            while (this.Width > 374)
            {
                if (this.Height >= 254)
                {
                    this.Location = new System.Drawing.Point(x, y += 35);//设置窗体位置
                    this.Size = new Size(this.Width, this.Height -= 254);//设置窗体大小
                    this.Refresh();//重绘窗体
                }

                else
                {
                    this.Location = new System.Drawing.Point(x += 35, y);

                    if (this.Width > 253)
                    {
                        this.Size = new Size(this.Width -= 254, this.Height);
                        this.Refresh();
                    }
                }
            }
        }

        private void MainPlatform_Move(object sender, EventArgs e)
        {
            x = this.Location.X;
            y = this.Location.Y;
        }

        private void MainPlatform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.windowHidingEffects();
        }

        private void linkCopyRight_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/devdiv/TestExerciser");
        }

        void subForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.d_SetMainPlatformWindowActive();
        }
    }
}
