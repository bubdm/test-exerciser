namespace TestExerciser.User
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            this.txtPasswd = new CCWin.SkinControl.SkinTextBox();
            this.txtUserName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtConfirmPassWD = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtEmailAddress = new CCWin.SkinControl.SkinTextBox();
            this.txtUserFullName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.txtPasswd.Location = new System.Drawing.Point(120, 108);
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
            this.txtPasswd.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.txtPasswd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPasswd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPasswd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPasswd.SkinTxt.Name = "BaseText";
            this.txtPasswd.SkinTxt.PasswordChar = '●';
            this.txtPasswd.SkinTxt.Size = new System.Drawing.Size(187, 18);
            this.txtPasswd.SkinTxt.TabIndex = 0;
            this.txtPasswd.SkinTxt.UseSystemPasswordChar = true;
            this.txtPasswd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPasswd.SkinTxt.WaterText = "必须含字母、数字6-20位字符";
            this.txtPasswd.TabIndex = 11;
            this.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPasswd.WaterText = "必须含字母、数字6-20位字符";
            this.txtPasswd.WordWrap = true;
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
            this.txtUserName.Location = new System.Drawing.Point(120, 61);
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
            this.txtUserName.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.txtUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserName.SkinTxt.Name = "BaseText";
            this.txtUserName.SkinTxt.Size = new System.Drawing.Size(187, 18);
            this.txtUserName.SkinTxt.TabIndex = 0;
            this.txtUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.SkinTxt.WaterText = "字母开头6-20位字符，可含数字";
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserName.WaterText = "字母开头6-20位字符，可含数字";
            this.txtUserName.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(44, 114);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "密码：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(44, 67);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "用户名：";
            // 
            // txtConfirmPassWD
            // 
            this.txtConfirmPassWD.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassWD.DownBack = null;
            this.txtConfirmPassWD.Icon = null;
            this.txtConfirmPassWD.IconIsButton = false;
            this.txtConfirmPassWD.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConfirmPassWD.IsPasswordChat = '●';
            this.txtConfirmPassWD.IsSystemPasswordChar = true;
            this.txtConfirmPassWD.Lines = new string[0];
            this.txtConfirmPassWD.Location = new System.Drawing.Point(120, 154);
            this.txtConfirmPassWD.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassWD.MaxLength = 32767;
            this.txtConfirmPassWD.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtConfirmPassWD.MouseBack = null;
            this.txtConfirmPassWD.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtConfirmPassWD.Multiline = false;
            this.txtConfirmPassWD.Name = "txtConfirmPassWD";
            this.txtConfirmPassWD.NormlBack = null;
            this.txtConfirmPassWD.Padding = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassWD.ReadOnly = false;
            this.txtConfirmPassWD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassWD.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.txtConfirmPassWD.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassWD.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPassWD.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtConfirmPassWD.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtConfirmPassWD.SkinTxt.Name = "BaseText";
            this.txtConfirmPassWD.SkinTxt.PasswordChar = '●';
            this.txtConfirmPassWD.SkinTxt.Size = new System.Drawing.Size(187, 18);
            this.txtConfirmPassWD.SkinTxt.TabIndex = 0;
            this.txtConfirmPassWD.SkinTxt.UseSystemPasswordChar = true;
            this.txtConfirmPassWD.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConfirmPassWD.SkinTxt.WaterText = "必须含字母、数字6-20位字符";
            this.txtConfirmPassWD.TabIndex = 12;
            this.txtConfirmPassWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassWD.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtConfirmPassWD.WaterText = "必须含字母、数字6-20位字符";
            this.txtConfirmPassWD.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(44, 160);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "确认密码：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 320);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消注册";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 320);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定注册";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailAddress.DownBack = null;
            this.txtEmailAddress.Icon = null;
            this.txtEmailAddress.IconIsButton = false;
            this.txtEmailAddress.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtEmailAddress.IsPasswordChat = '\0';
            this.txtEmailAddress.IsSystemPasswordChar = false;
            this.txtEmailAddress.Lines = new string[0];
            this.txtEmailAddress.Location = new System.Drawing.Point(120, 246);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtEmailAddress.MouseBack = null;
            this.txtEmailAddress.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtEmailAddress.Multiline = false;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.NormlBack = null;
            this.txtEmailAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmailAddress.ReadOnly = false;
            this.txtEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailAddress.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.txtEmailAddress.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAddress.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailAddress.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtEmailAddress.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtEmailAddress.SkinTxt.Name = "BaseText";
            this.txtEmailAddress.SkinTxt.Size = new System.Drawing.Size(187, 18);
            this.txtEmailAddress.SkinTxt.TabIndex = 0;
            this.txtEmailAddress.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtEmailAddress.SkinTxt.WaterText = "如@outlook.com";
            this.txtEmailAddress.TabIndex = 14;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailAddress.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtEmailAddress.WaterText = "如@outlook.com";
            this.txtEmailAddress.WordWrap = true;
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserFullName.DownBack = null;
            this.txtUserFullName.Icon = null;
            this.txtUserFullName.IconIsButton = false;
            this.txtUserFullName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserFullName.IsPasswordChat = '\0';
            this.txtUserFullName.IsSystemPasswordChar = false;
            this.txtUserFullName.Lines = new string[0];
            this.txtUserFullName.Location = new System.Drawing.Point(120, 202);
            this.txtUserFullName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserFullName.MaxLength = 32767;
            this.txtUserFullName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserFullName.MouseBack = null;
            this.txtUserFullName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserFullName.Multiline = false;
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.NormlBack = null;
            this.txtUserFullName.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserFullName.ReadOnly = false;
            this.txtUserFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserFullName.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.txtUserFullName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserFullName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserFullName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserFullName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserFullName.SkinTxt.Name = "BaseText";
            this.txtUserFullName.SkinTxt.Size = new System.Drawing.Size(187, 18);
            this.txtUserFullName.SkinTxt.TabIndex = 0;
            this.txtUserFullName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserFullName.SkinTxt.WaterText = "3-20位中文字符";
            this.txtUserFullName.TabIndex = 13;
            this.txtUserFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserFullName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserFullName.WaterText = "3-20位中文字符";
            this.txtUserFullName.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(44, 252);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 5;
            this.skinLabel4.Text = "邮箱：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(44, 206);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 4;
            this.skinLabel5.Text = "姓名：";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 290);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 20;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 381);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtUserFullName);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtConfirmPassWD);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserRegister";
            this.Text = "用户注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserRegister_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserRegister_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox txtPasswd;
        private CCWin.SkinControl.SkinTextBox txtUserName;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtConfirmPassWD;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinTextBox txtEmailAddress;
        private CCWin.SkinControl.SkinTextBox txtUserFullName;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.Label txtStatus;
    }
}