namespace TestExerciser.Tools.AutoTestingManagement
{
    partial class ToolAutoNewSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolAutoNewSolution));
            this.labProName = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.stbLocation = new CCWin.SkinControl.SkinTextBox();
            this.stbProName = new CCWin.SkinControl.SkinTextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.selectLocationFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // labProName
            // 
            this.labProName.AutoSize = true;
            this.labProName.Location = new System.Drawing.Point(42, 76);
            this.labProName.Name = "labProName";
            this.labProName.Size = new System.Drawing.Size(83, 12);
            this.labProName.TabIndex = 0;
            this.labProName.Text = "项目名称(N)：";
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Location = new System.Drawing.Point(51, 130);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(59, 12);
            this.labLocation.TabIndex = 1;
            this.labLocation.Text = "位置(L)：";
            // 
            // stbLocation
            // 
            this.stbLocation.BackColor = System.Drawing.Color.Transparent;
            this.stbLocation.DownBack = null;
            this.stbLocation.Icon = null;
            this.stbLocation.IconIsButton = false;
            this.stbLocation.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbLocation.IsPasswordChat = '\0';
            this.stbLocation.IsSystemPasswordChar = false;
            this.stbLocation.Lines = new string[0];
            this.stbLocation.Location = new System.Drawing.Point(117, 124);
            this.stbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.stbLocation.MaxLength = 32767;
            this.stbLocation.MinimumSize = new System.Drawing.Size(24, 24);
            this.stbLocation.MouseBack = null;
            this.stbLocation.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbLocation.Multiline = false;
            this.stbLocation.Name = "stbLocation";
            this.stbLocation.NormlBack = null;
            this.stbLocation.Padding = new System.Windows.Forms.Padding(4);
            this.stbLocation.ReadOnly = false;
            this.stbLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbLocation.Size = new System.Drawing.Size(341, 24);
            // 
            // 
            // 
            this.stbLocation.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbLocation.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbLocation.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbLocation.SkinTxt.Location = new System.Drawing.Point(4, 4);
            this.stbLocation.SkinTxt.Name = "BaseText";
            this.stbLocation.SkinTxt.Size = new System.Drawing.Size(333, 18);
            this.stbLocation.SkinTxt.TabIndex = 0;
            this.stbLocation.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbLocation.SkinTxt.WaterText = "";
            this.stbLocation.TabIndex = 3;
            this.stbLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbLocation.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbLocation.WaterText = "";
            this.stbLocation.WordWrap = true;
            // 
            // stbProName
            // 
            this.stbProName.BackColor = System.Drawing.Color.Transparent;
            this.stbProName.DownBack = null;
            this.stbProName.Icon = null;
            this.stbProName.IconIsButton = false;
            this.stbProName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbProName.IsPasswordChat = '\0';
            this.stbProName.IsSystemPasswordChar = false;
            this.stbProName.Lines = new string[0];
            this.stbProName.Location = new System.Drawing.Point(117, 71);
            this.stbProName.Margin = new System.Windows.Forms.Padding(0);
            this.stbProName.MaxLength = 32767;
            this.stbProName.MinimumSize = new System.Drawing.Size(24, 24);
            this.stbProName.MouseBack = null;
            this.stbProName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbProName.Multiline = false;
            this.stbProName.Name = "stbProName";
            this.stbProName.NormlBack = null;
            this.stbProName.Padding = new System.Windows.Forms.Padding(4);
            this.stbProName.ReadOnly = false;
            this.stbProName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbProName.Size = new System.Drawing.Size(383, 24);
            // 
            // 
            // 
            this.stbProName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbProName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbProName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbProName.SkinTxt.Location = new System.Drawing.Point(4, 4);
            this.stbProName.SkinTxt.Name = "BaseText";
            this.stbProName.SkinTxt.Size = new System.Drawing.Size(375, 18);
            this.stbProName.SkinTxt.TabIndex = 0;
            this.stbProName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbProName.SkinTxt.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbProName.TabIndex = 2;
            this.stbProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbProName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbProName.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbProName.WordWrap = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(461, 124);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(39, 24);
            this.btnSelectPath.TabIndex = 4;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(45, 162);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(300, 189);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 40;
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
            this.btnOK.Location = new System.Drawing.Point(151, 189);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(111, 23);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "确定新建";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            // 
            // ToolNewSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.stbLocation);
            this.Controls.Add(this.stbProName);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.labProName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ToolNewSolution";
            this.Text = "新建项目选项";
            
            this.Load += new System.EventHandler(this.ToolNewSolution_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolNewSolution_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labProName;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog selectLocationFolderBrowser;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        public CCWin.SkinControl.SkinTextBox stbLocation;
        public CCWin.SkinControl.SkinTextBox stbProName;
        public System.Windows.Forms.Label txtStatus;

    }
}