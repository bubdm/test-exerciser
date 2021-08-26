namespace TestExerciser.Tools.AutoTestingManagement
{
    partial class ToolAutoCleanScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolAutoCleanScripts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLocalPath = new CCWin.SkinControl.SkinTextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progClean = new CCWin.SkinControl.SkinProgressBar();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCleanDetail = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.selectLocalPath = new System.Windows.Forms.FolderBrowserDialog();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLocalPath);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.lblLocalPath);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择清理区域";
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.BackColor = System.Drawing.Color.Transparent;
            this.tbLocalPath.DownBack = null;
            this.tbLocalPath.Icon = null;
            this.tbLocalPath.IconIsButton = false;
            this.tbLocalPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbLocalPath.IsPasswordChat = '\0';
            this.tbLocalPath.IsSystemPasswordChar = false;
            this.tbLocalPath.Lines = new string[0];
            this.tbLocalPath.Location = new System.Drawing.Point(14, 45);
            this.tbLocalPath.Margin = new System.Windows.Forms.Padding(0);
            this.tbLocalPath.MaxLength = 32767;
            this.tbLocalPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbLocalPath.MouseBack = null;
            this.tbLocalPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbLocalPath.Multiline = false;
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.NormlBack = null;
            this.tbLocalPath.Padding = new System.Windows.Forms.Padding(5);
            this.tbLocalPath.ReadOnly = false;
            this.tbLocalPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocalPath.Size = new System.Drawing.Size(382, 28);
            // 
            // 
            // 
            this.tbLocalPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocalPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLocalPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbLocalPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbLocalPath.SkinTxt.Name = "BaseText";
            this.tbLocalPath.SkinTxt.Size = new System.Drawing.Size(372, 18);
            this.tbLocalPath.SkinTxt.TabIndex = 0;
            this.tbLocalPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbLocalPath.SkinTxt.WaterText = "请填写要清理的路径...";
            this.tbLocalPath.TabIndex = 21;
            this.tbLocalPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLocalPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbLocalPath.WaterText = "请填写要清理的路径...";
            this.tbLocalPath.WordWrap = true;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(399, 45);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(31, 28);
            this.btnSelectFolder.TabIndex = 18;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(13, 27);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(59, 12);
            this.lblLocalPath.TabIndex = 10;
            this.lblLocalPath.Text = "本地路径:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(731, 521);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progClean);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.lblProgress);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Location = new System.Drawing.Point(14, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 151);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "清理结果";
            // 
            // progClean
            // 
            this.progClean.Back = null;
            this.progClean.BackColor = System.Drawing.Color.Transparent;
            this.progClean.BarBack = null;
            this.progClean.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.progClean.ForeColor = System.Drawing.Color.Red;
            this.progClean.Location = new System.Drawing.Point(67, 20);
            this.progClean.Name = "progClean";
            this.progClean.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.progClean.Size = new System.Drawing.Size(359, 23);
            this.progClean.TabIndex = 19;
            this.progClean.TrackFore = System.Drawing.Color.Lime;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOK.Location = new System.Drawing.Point(68, 92);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(130, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "清理";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolClean_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(246, 92);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(9, 26);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(59, 12);
            this.lblProgress.TabIndex = 16;
            this.lblProgress.Text = "清理进度:";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(13, 61);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCleanDetail);
            this.groupBox2.Location = new System.Drawing.Point(14, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 226);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "清理过程";
            // 
            // txtCleanDetail
            // 
            this.txtCleanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCleanDetail.Location = new System.Drawing.Point(3, 17);
            this.txtCleanDetail.Multiline = true;
            this.txtCleanDetail.Name = "txtCleanDetail";
            this.txtCleanDetail.ReadOnly = true;
            this.txtCleanDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCleanDetail.Size = new System.Drawing.Size(440, 206);
            this.txtCleanDetail.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVersion);
            this.groupBox5.Location = new System.Drawing.Point(12, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 223);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "版本信息：";
            // 
            // txtVersion
            // 
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(3, 17);
            this.txtVersion.Multiline = true;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(218, 203);
            this.txtVersion.TabIndex = 0;
            this.txtVersion.Text = "Version：v1.0.1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtComments);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 264);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文件清理工具描述：";
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtComments.Location = new System.Drawing.Point(3, 17);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(218, 244);
            this.txtComments.TabIndex = 0;
            this.txtComments.Text = "    文件清理是用来清理和测试脚本无关项的简易工具。";
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // ToolAutoCleanScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 557);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ToolAutoCleanScripts";
            this.Text = "文件清理";
            this.Load += new System.EventHandler(this.ToolAutoCleanScripts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinTextBox tbLocalPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinProgressBar progClean;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.FolderBrowserDialog selectLocalPath;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.TextBox txtCleanDetail;
    }
}