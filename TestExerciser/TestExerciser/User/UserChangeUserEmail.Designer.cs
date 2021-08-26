namespace TestExerciser.User
{
    partial class UserChangeUserEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChangeUserEmail));
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtChangeTo = new CCWin.SkinControl.SkinTextBox();
            this.labNewUserMail = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 96);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 124);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "取消修改";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 124);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "确定修改";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChangeTo
            // 
            this.txtChangeTo.BackColor = System.Drawing.Color.Transparent;
            this.txtChangeTo.DownBack = null;
            this.txtChangeTo.Icon = null;
            this.txtChangeTo.IconIsButton = false;
            this.txtChangeTo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTo.IsPasswordChat = '\0';
            this.txtChangeTo.IsSystemPasswordChar = false;
            this.txtChangeTo.Lines = new string[0];
            this.txtChangeTo.Location = new System.Drawing.Point(128, 57);
            this.txtChangeTo.Margin = new System.Windows.Forms.Padding(0);
            this.txtChangeTo.MaxLength = 32767;
            this.txtChangeTo.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtChangeTo.MouseBack = null;
            this.txtChangeTo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTo.Multiline = false;
            this.txtChangeTo.Name = "txtChangeTo";
            this.txtChangeTo.NormlBack = null;
            this.txtChangeTo.Padding = new System.Windows.Forms.Padding(5);
            this.txtChangeTo.ReadOnly = false;
            this.txtChangeTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangeTo.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtChangeTo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeTo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChangeTo.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtChangeTo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtChangeTo.SkinTxt.Name = "BaseText";
            this.txtChangeTo.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtChangeTo.SkinTxt.TabIndex = 0;
            this.txtChangeTo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTo.SkinTxt.WaterText = "如@outlook.com";
            this.txtChangeTo.TabIndex = 28;
            this.txtChangeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChangeTo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTo.WaterText = "如@outlook.com";
            this.txtChangeTo.WordWrap = true;
            // 
            // labNewUserMail
            // 
            this.labNewUserMail.AutoSize = true;
            this.labNewUserMail.BackColor = System.Drawing.Color.Transparent;
            this.labNewUserMail.BorderColor = System.Drawing.Color.White;
            this.labNewUserMail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNewUserMail.Location = new System.Drawing.Point(54, 63);
            this.labNewUserMail.Name = "labNewUserMail";
            this.labNewUserMail.Size = new System.Drawing.Size(80, 17);
            this.labNewUserMail.TabIndex = 29;
            this.labNewUserMail.Text = "新用户邮箱：";
            // 
            // UserChangeUserEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 178);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChangeTo);
            this.Controls.Add(this.labNewUserMail);
            this.Controls.Add(this.txtStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserChangeUserEmail";
            this.Text = "修改用户邮箱";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserChangeUserEmail_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStatus;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinTextBox txtChangeTo;
        private CCWin.SkinControl.SkinLabel labNewUserMail;
    }
}