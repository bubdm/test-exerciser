namespace TestExerciser.User
{
    partial class UserResetPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserResetPwd));
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtUserEmail = new CCWin.SkinControl.SkinTextBox();
            this.labUserMail = new CCWin.SkinControl.SkinLabel();
            this.txtUserName = new CCWin.SkinControl.SkinTextBox();
            this.labUserName = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 154);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 182);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消申请";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 182);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "申请重置";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtUserEmail.DownBack = null;
            this.txtUserEmail.Icon = null;
            this.txtUserEmail.IconIsButton = false;
            this.txtUserEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserEmail.IsPasswordChat = '\0';
            this.txtUserEmail.IsSystemPasswordChar = false;
            this.txtUserEmail.Lines = new string[0];
            this.txtUserEmail.Location = new System.Drawing.Point(126, 110);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserEmail.MaxLength = 32767;
            this.txtUserEmail.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserEmail.MouseBack = null;
            this.txtUserEmail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserEmail.Multiline = false;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.NormlBack = null;
            this.txtUserEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserEmail.ReadOnly = false;
            this.txtUserEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserEmail.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtUserEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserEmail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserEmail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserEmail.SkinTxt.Name = "BaseText";
            this.txtUserEmail.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtUserEmail.SkinTxt.TabIndex = 0;
            this.txtUserEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserEmail.SkinTxt.WaterText = "如@outlook.com";
            this.txtUserEmail.TabIndex = 2;
            this.txtUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserEmail.WaterText = "如@outlook.com";
            this.txtUserEmail.WordWrap = true;
            // 
            // labUserMail
            // 
            this.labUserMail.AutoSize = true;
            this.labUserMail.BackColor = System.Drawing.Color.Transparent;
            this.labUserMail.BorderColor = System.Drawing.Color.White;
            this.labUserMail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserMail.Location = new System.Drawing.Point(54, 115);
            this.labUserMail.Name = "labUserMail";
            this.labUserMail.Size = new System.Drawing.Size(68, 17);
            this.labUserMail.TabIndex = 6;
            this.labUserMail.Text = "用户邮箱：";
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
            this.txtUserName.Location = new System.Drawing.Point(126, 58);
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
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.BorderColor = System.Drawing.Color.White;
            this.labUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserName.Location = new System.Drawing.Point(66, 64);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(56, 17);
            this.labUserName.TabIndex = 5;
            this.labUserName.Text = "用户名：";
            // 
            // UserResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 249);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.labUserMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserResetPwd";
            this.Text = "重置密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserResetPwd_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserResetPwd_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStatus;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinTextBox txtUserEmail;
        private CCWin.SkinControl.SkinLabel labUserMail;
        private CCWin.SkinControl.SkinTextBox txtUserName;
        private CCWin.SkinControl.SkinLabel labUserName;
    }
}