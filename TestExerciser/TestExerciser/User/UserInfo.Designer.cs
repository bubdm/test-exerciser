namespace TestExerciser.User
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labFullName = new System.Windows.Forms.Label();
            this.labEmailAddress = new System.Windows.Forms.Label();
            this.linkChangeFullName = new System.Windows.Forms.LinkLabel();
            this.linkChangeMail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户邮箱：";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(132, 56);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(0, 12);
            this.labUserName.TabIndex = 3;
            // 
            // labFullName
            // 
            this.labFullName.AutoSize = true;
            this.labFullName.Location = new System.Drawing.Point(132, 105);
            this.labFullName.Name = "labFullName";
            this.labFullName.Size = new System.Drawing.Size(0, 12);
            this.labFullName.TabIndex = 4;
            // 
            // labEmailAddress
            // 
            this.labEmailAddress.AutoSize = true;
            this.labEmailAddress.Location = new System.Drawing.Point(132, 154);
            this.labEmailAddress.Name = "labEmailAddress";
            this.labEmailAddress.Size = new System.Drawing.Size(0, 12);
            this.labEmailAddress.TabIndex = 5;
            // 
            // linkChangeFullName
            // 
            this.linkChangeFullName.AutoSize = true;
            this.linkChangeFullName.Location = new System.Drawing.Point(288, 106);
            this.linkChangeFullName.Name = "linkChangeFullName";
            this.linkChangeFullName.Size = new System.Drawing.Size(29, 12);
            this.linkChangeFullName.TabIndex = 7;
            this.linkChangeFullName.TabStop = true;
            this.linkChangeFullName.Text = "修改";
            this.linkChangeFullName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangeFullName_LinkClicked);
            // 
            // linkChangeMail
            // 
            this.linkChangeMail.AutoSize = true;
            this.linkChangeMail.Location = new System.Drawing.Point(288, 155);
            this.linkChangeMail.Name = "linkChangeMail";
            this.linkChangeMail.Size = new System.Drawing.Size(29, 12);
            this.linkChangeMail.TabIndex = 8;
            this.linkChangeMail.TabStop = true;
            this.linkChangeMail.Text = "修改";
            this.linkChangeMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangeMail_LinkClicked);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 200);
            this.Controls.Add(this.linkChangeMail);
            this.Controls.Add(this.linkChangeFullName);
            this.Controls.Add(this.labEmailAddress);
            this.Controls.Add(this.labFullName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInfo";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.MainUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labFullName;
        private System.Windows.Forms.Label labEmailAddress;
        private System.Windows.Forms.LinkLabel linkChangeFullName;
        private System.Windows.Forms.LinkLabel linkChangeMail;
    }
}