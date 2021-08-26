namespace TestExerciser.User
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtUserName = new CCWin.SkinControl.SkinTextBox();
            this.txtPasswd = new CCWin.SkinControl.SkinTextBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.linkForgetPwd = new System.Windows.Forms.LinkLabel();
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_ShowMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_LoginOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 205);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定登录";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 205);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消登录";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(42, 76);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "用户名：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(42, 125);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.DownBack = null;
            this.txtUserName.Icon = null;
            this.txtUserName.IconIsButton = false;
            this.txtUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserName.IsPasswordChat = '\0';
            this.txtUserName.IsSystemPasswordChar = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(101, 72);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserName.MouseBack = null;
            this.txtUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NormlBack = null;
            this.txtUserName.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserName.ReadOnly = false;
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserName.SkinTxt.Name = "BaseText";
            this.txtUserName.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtUserName.SkinTxt.TabIndex = 0;
            this.txtUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.SkinTxt.WaterText = "";
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.WaterText = "";
            this.txtUserName.WordWrap = true;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswd.DownBack = null;
            this.txtPasswd.Icon = null;
            this.txtPasswd.IconIsButton = false;
            this.txtPasswd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPasswd.IsPasswordChat = '●';
            this.txtPasswd.IsSystemPasswordChar = true;
            this.txtPasswd.Lines = new string[0];
            this.txtPasswd.Location = new System.Drawing.Point(101, 119);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPasswd.MaxLength = 32767;
            this.txtPasswd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPasswd.MouseBack = null;
            this.txtPasswd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPasswd.Multiline = false;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.NormlBack = null;
            this.txtPasswd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPasswd.ReadOnly = false;
            this.txtPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtPasswd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPasswd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPasswd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPasswd.SkinTxt.Name = "BaseText";
            this.txtPasswd.SkinTxt.PasswordChar = '●';
            this.txtPasswd.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtPasswd.SkinTxt.TabIndex = 0;
            this.txtPasswd.SkinTxt.UseSystemPasswordChar = true;
            this.txtPasswd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPasswd.SkinTxt.WaterText = "";
            this.txtPasswd.TabIndex = 2;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPasswd.WaterText = "";
            this.txtPasswd.WordWrap = true;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 172);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 8;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(289, 81);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(29, 12);
            this.linkRegister.TabIndex = 5;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "注册";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // linkForgetPwd
            // 
            this.linkForgetPwd.AutoSize = true;
            this.linkForgetPwd.Location = new System.Drawing.Point(289, 128);
            this.linkForgetPwd.Name = "linkForgetPwd";
            this.linkForgetPwd.Size = new System.Drawing.Size(65, 12);
            this.linkForgetPwd.TabIndex = 9;
            this.linkForgetPwd.TabStop = true;
            this.linkForgetPwd.Text = "忘记密码？";
            this.linkForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPwd_LinkClicked);
            // 
            // notifyContextMenu
            // 
            this.notifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ShowMainWindow,
            this.toolStripSeparator2,
            this.toolStripMenuItem_About,
            this.toolStripMenuItem_LoginOut,
            this.toolStripMenuItem_Quit});
            this.notifyContextMenu.Name = "notifyContextMenu";
            this.notifyContextMenu.Size = new System.Drawing.Size(186, 120);
            // 
            // toolStripMenuItem_ShowMainWindow
            // 
            this.toolStripMenuItem_ShowMainWindow.Name = "toolStripMenuItem_ShowMainWindow";
            this.toolStripMenuItem_ShowMainWindow.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_ShowMainWindow.Text = "显示主窗口(Ctrl+M)";
            this.toolStripMenuItem_ShowMainWindow.Click += new System.EventHandler(this.toolStripMenuItem_ShowMainWindow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripMenuItem_LoginOut
            // 
            this.toolStripMenuItem_LoginOut.Name = "toolStripMenuItem_LoginOut";
            this.toolStripMenuItem_LoginOut.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_LoginOut.Text = "注销";
            this.toolStripMenuItem_LoginOut.Click += new System.EventHandler(this.toolStripMenuItem_LoginOut_Click);
            // 
            // toolStripMenuItem_Quit
            // 
            this.toolStripMenuItem_Quit.Name = "toolStripMenuItem_Quit";
            this.toolStripMenuItem_Quit.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_Quit.Text = "退出";
            this.toolStripMenuItem_Quit.Click += new System.EventHandler(this.toolStripMenuItem_Quit_Click);
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.notifyContextMenu;
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.DoubleClick += new System.EventHandler(this.myNotifyIcon_DoubleClick);
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_About.Text = "关于";
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.toolStripMenuItem_About_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 254);
            this.Controls.Add(this.linkForgetPwd);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.Text = "用户登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainLogin_FormClosing);
            this.Load += new System.EventHandler(this.MainLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainLogin_KeyDown);
            this.notifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.Label txtStatus;
        private CCWin.SkinControl.SkinTextBox txtPasswd;
        private CCWin.SkinControl.SkinTextBox txtUserName;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel linkForgetPwd;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ShowMainWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoginOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Quit;
        public System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
    }
}