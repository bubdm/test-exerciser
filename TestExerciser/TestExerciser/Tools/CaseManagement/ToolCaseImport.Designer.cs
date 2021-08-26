namespace TestExerciser.Tools.CaseManagement
{
    partial class ToolCaseImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolCaseImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExcelSource = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.labSelectFile = new CCWin.SkinControl.SkinLabel();
            this.tbSelectFile = new CCWin.SkinControl.SkinTextBox();
            this.labSelectProject = new CCWin.SkinControl.SkinLabel();
            this.tbSelectProject = new CCWin.SkinControl.SkinTextBox();
            this.labSelectStruct = new CCWin.SkinControl.SkinLabel();
            this.cbSelectStruct = new CCWin.SkinControl.SkinComboBox();
            this.dgv_CaseToImprot = new CCWin.SkinControl.SkinDataGridView();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.linkSelectInvert = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.labStatus = new System.Windows.Forms.Label();
            this.linkSelectAllRegion = new System.Windows.Forms.LinkLabel();
            this.linkSelectAll = new System.Windows.Forms.LinkLabel();
            this.linkSelectInvertRegion = new System.Windows.Forms.LinkLabel();
            this.tlpMain.SuspendLayout();
            this.tlpExcelSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaseToImprot)).BeginInit();
            this.tlpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpExcelSource, 0, 0);
            this.tlpMain.Controls.Add(this.dgv_CaseToImprot, 0, 1);
            this.tlpMain.Controls.Add(this.tlpBottom, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpMain.Size = new System.Drawing.Size(1432, 789);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpExcelSource
            // 
            this.tlpExcelSource.ColumnCount = 10;
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tlpExcelSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExcelSource.Controls.Add(this.btnSelectFile, 2, 0);
            this.tlpExcelSource.Controls.Add(this.btnSelectProject, 5, 0);
            this.tlpExcelSource.Controls.Add(this.labSelectFile, 0, 0);
            this.tlpExcelSource.Controls.Add(this.tbSelectFile, 1, 0);
            this.tlpExcelSource.Controls.Add(this.labSelectProject, 3, 0);
            this.tlpExcelSource.Controls.Add(this.tbSelectProject, 4, 0);
            this.tlpExcelSource.Controls.Add(this.labSelectStruct, 6, 0);
            this.tlpExcelSource.Controls.Add(this.cbSelectStruct, 7, 0);
            this.tlpExcelSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExcelSource.Location = new System.Drawing.Point(3, 3);
            this.tlpExcelSource.Name = "tlpExcelSource";
            this.tlpExcelSource.RowCount = 1;
            this.tlpExcelSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExcelSource.Size = new System.Drawing.Size(1426, 27);
            this.tlpExcelSource.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.Location = new System.Drawing.Point(469, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(24, 21);
            this.btnSelectFile.TabIndex = 30;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSelectProject.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectProject.Image")));
            this.btnSelectProject.Location = new System.Drawing.Point(882, 3);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(24, 21);
            this.btnSelectProject.TabIndex = 29;
            this.btnSelectProject.UseVisualStyleBackColor = false;
            this.btnSelectProject.Click += new System.EventHandler(this.btnSelectProject_Click);
            // 
            // labSelectFile
            // 
            this.labSelectFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSelectFile.AutoSize = true;
            this.labSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.labSelectFile.BorderColor = System.Drawing.Color.White;
            this.labSelectFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelectFile.Location = new System.Drawing.Point(3, 5);
            this.labSelectFile.Name = "labSelectFile";
            this.labSelectFile.Size = new System.Drawing.Size(169, 17);
            this.labSelectFile.TabIndex = 0;
            this.labSelectFile.Text = "请选择需要导入的Excle文件：";
            // 
            // tbSelectFile
            // 
            this.tbSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.tbSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectFile.DownBack = null;
            this.tbSelectFile.Enabled = false;
            this.tbSelectFile.Icon = null;
            this.tbSelectFile.IconIsButton = false;
            this.tbSelectFile.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbSelectFile.IsPasswordChat = '\0';
            this.tbSelectFile.IsSystemPasswordChar = false;
            this.tbSelectFile.Lines = new string[0];
            this.tbSelectFile.Location = new System.Drawing.Point(180, 0);
            this.tbSelectFile.Margin = new System.Windows.Forms.Padding(0);
            this.tbSelectFile.MaxLength = 32767;
            this.tbSelectFile.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbSelectFile.MouseBack = null;
            this.tbSelectFile.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbSelectFile.Multiline = false;
            this.tbSelectFile.Name = "tbSelectFile";
            this.tbSelectFile.NormlBack = null;
            this.tbSelectFile.Padding = new System.Windows.Forms.Padding(5);
            this.tbSelectFile.ReadOnly = false;
            this.tbSelectFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSelectFile.Size = new System.Drawing.Size(286, 28);
            // 
            // 
            // 
            this.tbSelectFile.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectFile.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectFile.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbSelectFile.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbSelectFile.SkinTxt.Name = "BaseText";
            this.tbSelectFile.SkinTxt.Size = new System.Drawing.Size(276, 18);
            this.tbSelectFile.SkinTxt.TabIndex = 0;
            this.tbSelectFile.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbSelectFile.SkinTxt.WaterText = "支持导入.xls 、.xlsx文件格式...";
            this.tbSelectFile.TabIndex = 1;
            this.tbSelectFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSelectFile.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbSelectFile.WaterText = "支持导入.xls 、.xlsx文件格式...";
            this.tbSelectFile.WordWrap = true;
            // 
            // labSelectProject
            // 
            this.labSelectProject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSelectProject.AutoSize = true;
            this.labSelectProject.BackColor = System.Drawing.Color.Transparent;
            this.labSelectProject.BorderColor = System.Drawing.Color.White;
            this.labSelectProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelectProject.Location = new System.Drawing.Point(506, 5);
            this.labSelectProject.Name = "labSelectProject";
            this.labSelectProject.Size = new System.Drawing.Size(80, 17);
            this.labSelectProject.TabIndex = 5;
            this.labSelectProject.Text = "请选择项目：";
            // 
            // tbSelectProject
            // 
            this.tbSelectProject.BackColor = System.Drawing.Color.Transparent;
            this.tbSelectProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectProject.DownBack = null;
            this.tbSelectProject.Enabled = false;
            this.tbSelectProject.Icon = null;
            this.tbSelectProject.IconIsButton = false;
            this.tbSelectProject.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbSelectProject.IsPasswordChat = '\0';
            this.tbSelectProject.IsSystemPasswordChar = false;
            this.tbSelectProject.Lines = new string[0];
            this.tbSelectProject.Location = new System.Drawing.Point(593, 0);
            this.tbSelectProject.Margin = new System.Windows.Forms.Padding(0);
            this.tbSelectProject.MaxLength = 32767;
            this.tbSelectProject.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbSelectProject.MouseBack = null;
            this.tbSelectProject.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbSelectProject.Multiline = false;
            this.tbSelectProject.Name = "tbSelectProject";
            this.tbSelectProject.NormlBack = null;
            this.tbSelectProject.Padding = new System.Windows.Forms.Padding(5);
            this.tbSelectProject.ReadOnly = false;
            this.tbSelectProject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSelectProject.Size = new System.Drawing.Size(286, 28);
            // 
            // 
            // 
            this.tbSelectProject.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectProject.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectProject.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbSelectProject.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbSelectProject.SkinTxt.Name = "BaseText";
            this.tbSelectProject.SkinTxt.Size = new System.Drawing.Size(276, 18);
            this.tbSelectProject.SkinTxt.TabIndex = 0;
            this.tbSelectProject.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbSelectProject.SkinTxt.WaterText = "";
            this.tbSelectProject.TabIndex = 7;
            this.tbSelectProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSelectProject.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbSelectProject.WaterText = "";
            this.tbSelectProject.WordWrap = true;
            // 
            // labSelectStruct
            // 
            this.labSelectStruct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSelectStruct.AutoSize = true;
            this.labSelectStruct.BackColor = System.Drawing.Color.Transparent;
            this.labSelectStruct.BorderColor = System.Drawing.Color.White;
            this.labSelectStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelectStruct.Location = new System.Drawing.Point(919, 5);
            this.labSelectStruct.Name = "labSelectStruct";
            this.labSelectStruct.Size = new System.Drawing.Size(80, 17);
            this.labSelectStruct.TabIndex = 8;
            this.labSelectStruct.Text = "请选择架构：";
            // 
            // cbSelectStruct
            // 
            this.cbSelectStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSelectStruct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectStruct.FormattingEnabled = true;
            this.cbSelectStruct.Location = new System.Drawing.Point(1009, 3);
            this.cbSelectStruct.Name = "cbSelectStruct";
            this.cbSelectStruct.Size = new System.Drawing.Size(280, 22);
            this.cbSelectStruct.TabIndex = 9;
            this.cbSelectStruct.WaterText = "";
            // 
            // dgv_CaseToImprot
            // 
            this.dgv_CaseToImprot.AllowUserToAddRows = false;
            this.dgv_CaseToImprot.AllowUserToDeleteRows = false;
            this.dgv_CaseToImprot.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_CaseToImprot.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CaseToImprot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CaseToImprot.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_CaseToImprot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CaseToImprot.ColumnFont = null;
            this.dgv_CaseToImprot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CaseToImprot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CaseToImprot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CaseToImprot.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CaseToImprot.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CaseToImprot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CaseToImprot.EnableHeadersVisualStyles = false;
            this.dgv_CaseToImprot.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_CaseToImprot.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_CaseToImprot.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_CaseToImprot.Location = new System.Drawing.Point(3, 36);
            this.dgv_CaseToImprot.Name = "dgv_CaseToImprot";
            this.dgv_CaseToImprot.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_CaseToImprot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_CaseToImprot.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CaseToImprot.RowTemplate.Height = 23;
            this.dgv_CaseToImprot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CaseToImprot.Size = new System.Drawing.Size(1426, 713);
            this.dgv_CaseToImprot.TabIndex = 1;
            this.dgv_CaseToImprot.TitleBack = null;
            this.dgv_CaseToImprot.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_CaseToImprot.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 8;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpBottom.Controls.Add(this.btnOK, 6, 0);
            this.tlpBottom.Controls.Add(this.linkSelectInvert, 4, 0);
            this.tlpBottom.Controls.Add(this.btnCancel, 7, 0);
            this.tlpBottom.Controls.Add(this.labStatus, 0, 0);
            this.tlpBottom.Controls.Add(this.linkSelectAllRegion, 1, 0);
            this.tlpBottom.Controls.Add(this.linkSelectAll, 3, 0);
            this.tlpBottom.Controls.Add(this.linkSelectInvertRegion, 2, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(3, 755);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(1426, 31);
            this.tlpBottom.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(1186, 4);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定导入";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // linkSelectInvert
            // 
            this.linkSelectInvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSelectInvert.AutoSize = true;
            this.linkSelectInvert.Location = new System.Drawing.Point(1029, 9);
            this.linkSelectInvert.Name = "linkSelectInvert";
            this.linkSelectInvert.Size = new System.Drawing.Size(53, 12);
            this.linkSelectInvert.TabIndex = 5;
            this.linkSelectInvert.TabStop = true;
            this.linkSelectInvert.Text = "反选所有";
            this.linkSelectInvert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectInvert_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(1316, 4);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消导入";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labStatus
            // 
            this.labStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(3, 9);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 2;
            // 
            // linkSelectAllRegion
            // 
            this.linkSelectAllRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSelectAllRegion.AutoSize = true;
            this.linkSelectAllRegion.Location = new System.Drawing.Point(849, 9);
            this.linkSelectAllRegion.Name = "linkSelectAllRegion";
            this.linkSelectAllRegion.Size = new System.Drawing.Size(53, 12);
            this.linkSelectAllRegion.TabIndex = 3;
            this.linkSelectAllRegion.TabStop = true;
            this.linkSelectAllRegion.Text = "全选选区";
            this.linkSelectAllRegion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectAllRegion_LinkClicked);
            // 
            // linkSelectAll
            // 
            this.linkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSelectAll.AutoSize = true;
            this.linkSelectAll.Location = new System.Drawing.Point(969, 9);
            this.linkSelectAll.Name = "linkSelectAll";
            this.linkSelectAll.Size = new System.Drawing.Size(53, 12);
            this.linkSelectAll.TabIndex = 6;
            this.linkSelectAll.TabStop = true;
            this.linkSelectAll.Text = "全选所有";
            this.linkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectAll_LinkClicked);
            // 
            // linkSelectInvertRegion
            // 
            this.linkSelectInvertRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSelectInvertRegion.AutoSize = true;
            this.linkSelectInvertRegion.Location = new System.Drawing.Point(909, 9);
            this.linkSelectInvertRegion.Name = "linkSelectInvertRegion";
            this.linkSelectInvertRegion.Size = new System.Drawing.Size(53, 12);
            this.linkSelectInvertRegion.TabIndex = 4;
            this.linkSelectInvertRegion.TabStop = true;
            this.linkSelectInvertRegion.Text = "反选选区";
            this.linkSelectInvertRegion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectInvertRegion_LinkClicked);
            // 
            // ToolCaseImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolCaseImport";
            this.Text = "用例导入";
            
            this.Load += new System.EventHandler(this.ToolCaseImport_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpExcelSource.ResumeLayout(false);
            this.tlpExcelSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaseToImprot)).EndInit();
            this.tlpBottom.ResumeLayout(false);
            this.tlpBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpExcelSource;
        private CCWin.SkinControl.SkinLabel labSelectFile;
        private CCWin.SkinControl.SkinTextBox tbSelectFile;
        private CCWin.SkinControl.SkinDataGridView dgv_CaseToImprot;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.LinkLabel linkSelectAllRegion;
        private System.Windows.Forms.LinkLabel linkSelectInvertRegion;
        private CCWin.SkinControl.SkinLabel labSelectProject;
        private CCWin.SkinControl.SkinTextBox tbSelectProject;
        private CCWin.SkinControl.SkinLabel labSelectStruct;
        private CCWin.SkinControl.SkinComboBox cbSelectStruct;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSelectProject;
        private System.Windows.Forms.LinkLabel linkSelectAll;
        private System.Windows.Forms.LinkLabel linkSelectInvert;
    }
}