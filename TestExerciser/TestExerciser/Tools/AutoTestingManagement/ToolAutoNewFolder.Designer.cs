namespace TestExerciser.Tools.AutoTestingManagement
{
    partial class ToolAutoNewFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolAutoNewFolder));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtStatus = new System.Windows.Forms.Label();
            this.stbFolderName = new CCWin.SkinControl.SkinTextBox();
            this.labFolderName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(278, 153);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "取消新建";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(129, 153);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(111, 23);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "确定新建";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(41, 126);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 46;
            // 
            // stbFolderName
            // 
            this.stbFolderName.BackColor = System.Drawing.Color.Transparent;
            this.stbFolderName.DownBack = null;
            this.stbFolderName.Icon = null;
            this.stbFolderName.IconIsButton = false;
            this.stbFolderName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFolderName.IsPasswordChat = '\0';
            this.stbFolderName.IsSystemPasswordChar = false;
            this.stbFolderName.Lines = new string[0];
            this.stbFolderName.Location = new System.Drawing.Point(150, 71);
            this.stbFolderName.Margin = new System.Windows.Forms.Padding(0);
            this.stbFolderName.MaxLength = 32767;
            this.stbFolderName.MinimumSize = new System.Drawing.Size(24, 24);
            this.stbFolderName.MouseBack = null;
            this.stbFolderName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFolderName.Multiline = false;
            this.stbFolderName.Name = "stbFolderName";
            this.stbFolderName.NormlBack = null;
            this.stbFolderName.Padding = new System.Windows.Forms.Padding(4);
            this.stbFolderName.ReadOnly = false;
            this.stbFolderName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbFolderName.Size = new System.Drawing.Size(301, 24);
            // 
            // 
            // 
            this.stbFolderName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbFolderName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbFolderName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbFolderName.SkinTxt.Location = new System.Drawing.Point(4, 4);
            this.stbFolderName.SkinTxt.Name = "BaseText";
            this.stbFolderName.SkinTxt.Size = new System.Drawing.Size(293, 18);
            this.stbFolderName.SkinTxt.TabIndex = 0;
            this.stbFolderName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFolderName.SkinTxt.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbFolderName.TabIndex = 43;
            this.stbFolderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbFolderName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFolderName.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbFolderName.WordWrap = true;
            // 
            // labFolderName
            // 
            this.labFolderName.AutoSize = true;
            this.labFolderName.Location = new System.Drawing.Point(46, 76);
            this.labFolderName.Name = "labFolderName";
            this.labFolderName.Size = new System.Drawing.Size(95, 12);
            this.labFolderName.TabIndex = 41;
            this.labFolderName.Text = "文件夹名称(R)：";
            // 
            // ToolNewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.stbFolderName);
            this.Controls.Add(this.labFolderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ToolNewFolder";
            this.Text = "新建文件夹选项";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolNewFolder_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        public System.Windows.Forms.Label txtStatus;
        public CCWin.SkinControl.SkinTextBox stbFolderName;
        private System.Windows.Forms.Label labFolderName;
    }
}