namespace TestExerciser.Tools.BugManagement
{
    partial class ToolBugModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBugModify));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.cbVersion = new CCWin.SkinControl.SkinComboBox();
            this.tbBugTitle = new CCWin.SkinControl.SkinTextBox();
            this.labProject = new CCWin.SkinControl.SkinLabel();
            this.tbProject = new CCWin.SkinControl.SkinTextBox();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.labStruct = new CCWin.SkinControl.SkinLabel();
            this.labOccurrence = new CCWin.SkinControl.SkinLabel();
            this.cbStruct = new CCWin.SkinControl.SkinComboBox();
            this.cbOccurrence = new CCWin.SkinControl.SkinComboBox();
            this.labVersion = new CCWin.SkinControl.SkinLabel();
            this.labBugTitle = new CCWin.SkinControl.SkinLabel();
            this.labCategory = new CCWin.SkinControl.SkinLabel();
            this.labExceptDate = new CCWin.SkinControl.SkinLabel();
            this.dtpEditDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtpExceptDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.cbCategory = new CCWin.SkinControl.SkinComboBox();
            this.cbHowFound = new CCWin.SkinControl.SkinComboBox();
            this.cbGravity = new CCWin.SkinControl.SkinComboBox();
            this.cbPriority = new CCWin.SkinControl.SkinComboBox();
            this.tbAuthor = new CCWin.SkinControl.SkinTextBox();
            this.labHowFound = new CCWin.SkinControl.SkinLabel();
            this.labGravity = new CCWin.SkinControl.SkinLabel();
            this.labPriority = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.tbModify = new CCWin.SkinControl.SkinTextBox();
            this.labModifyDate = new CCWin.SkinControl.SkinLabel();
            this.labEditDate = new CCWin.SkinControl.SkinLabel();
            this.dtpModifyDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labReproSteps = new CCWin.SkinControl.SkinLabel();
            this.rtbReproSteps = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtbSamples = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtbExcept = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtbActually = new CCWin.SkinControl.SkinChatRichTextBox();
            this.labSampes = new CCWin.SkinControl.SkinLabel();
            this.labExcept = new CCWin.SkinControl.SkinLabel();
            this.labActually = new CCWin.SkinControl.SkinLabel();
            this.btnAttachment = new CCWin.SkinControl.SkinButton();
            this.labAuditor = new CCWin.SkinControl.SkinLabel();
            this.cbAuditor = new System.Windows.Forms.ComboBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.btnSubmit = new System.Windows.Forms.ToolStripButton();
            this.tsbQuite = new System.Windows.Forms.ToolStripButton();
            this.tlpMain.SuspendLayout();
            this.tlpMainManager.SuspendLayout();
            this.tlpMainEditor.SuspendLayout();
            this.tlpSort.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.stsManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMainManager, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1432, 789);
            this.tlpMain.TabIndex = 4;
            // 
            // tlpMainManager
            // 
            this.tlpMainManager.ColumnCount = 1;
            this.tlpMainManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Controls.Add(this.tlpMainEditor, 0, 1);
            this.tlpMainManager.Controls.Add(this.stsManager, 0, 0);
            this.tlpMainManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainManager.Location = new System.Drawing.Point(3, 3);
            this.tlpMainManager.Name = "tlpMainManager";
            this.tlpMainManager.RowCount = 2;
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Size = new System.Drawing.Size(1426, 783);
            this.tlpMainManager.TabIndex = 2;
            // 
            // tlpMainEditor
            // 
            this.tlpMainEditor.ColumnCount = 1;
            this.tlpMainEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Controls.Add(this.tlpSort, 0, 0);
            this.tlpMainEditor.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainEditor.Location = new System.Drawing.Point(3, 33);
            this.tlpMainEditor.Name = "tlpMainEditor";
            this.tlpMainEditor.RowCount = 2;
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1420, 747);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 5;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.Controls.Add(this.skinLabel1, 0, 6);
            this.tlpSort.Controls.Add(this.cbVersion, 1, 1);
            this.tlpSort.Controls.Add(this.tbBugTitle, 4, 1);
            this.tlpSort.Controls.Add(this.labProject, 0, 0);
            this.tlpSort.Controls.Add(this.tbProject, 1, 0);
            this.tlpSort.Controls.Add(this.btnSelectProject, 2, 0);
            this.tlpSort.Controls.Add(this.labStruct, 3, 0);
            this.tlpSort.Controls.Add(this.labOccurrence, 3, 3);
            this.tlpSort.Controls.Add(this.cbStruct, 4, 0);
            this.tlpSort.Controls.Add(this.cbOccurrence, 4, 3);
            this.tlpSort.Controls.Add(this.labVersion, 0, 1);
            this.tlpSort.Controls.Add(this.labBugTitle, 3, 1);
            this.tlpSort.Controls.Add(this.labCategory, 3, 2);
            this.tlpSort.Controls.Add(this.labExceptDate, 3, 4);
            this.tlpSort.Controls.Add(this.dtpEditDate, 4, 5);
            this.tlpSort.Controls.Add(this.dtpExceptDate, 4, 4);
            this.tlpSort.Controls.Add(this.cbCategory, 4, 2);
            this.tlpSort.Controls.Add(this.cbHowFound, 1, 2);
            this.tlpSort.Controls.Add(this.cbGravity, 1, 3);
            this.tlpSort.Controls.Add(this.cbPriority, 1, 4);
            this.tlpSort.Controls.Add(this.tbAuthor, 1, 5);
            this.tlpSort.Controls.Add(this.labHowFound, 0, 2);
            this.tlpSort.Controls.Add(this.labGravity, 0, 3);
            this.tlpSort.Controls.Add(this.labPriority, 0, 4);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 5);
            this.tlpSort.Controls.Add(this.tbModify, 1, 6);
            this.tlpSort.Controls.Add(this.labModifyDate, 3, 6);
            this.tlpSort.Controls.Add(this.labEditDate, 3, 5);
            this.tlpSort.Controls.Add(this.dtpModifyDate, 4, 6);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 3);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 7;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.Size = new System.Drawing.Size(1414, 198);
            this.tlpSort.TabIndex = 2;
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.White;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 174);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 38;
            this.skinLabel1.Text = "修改人：";
            // 
            // cbVersion
            // 
            this.cbVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(98, 31);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(589, 22);
            this.cbVersion.TabIndex = 32;
            this.cbVersion.WaterText = "必填...";
            // 
            // tbBugTitle
            // 
            this.tbBugTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBugTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbBugTitle.DownBack = null;
            this.tbBugTitle.Icon = null;
            this.tbBugTitle.IconIsButton = false;
            this.tbBugTitle.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbBugTitle.IsPasswordChat = '\0';
            this.tbBugTitle.IsSystemPasswordChar = false;
            this.tbBugTitle.Lines = new string[0];
            this.tbBugTitle.Location = new System.Drawing.Point(819, 28);
            this.tbBugTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tbBugTitle.MaxLength = 32767;
            this.tbBugTitle.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbBugTitle.MouseBack = null;
            this.tbBugTitle.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbBugTitle.Multiline = false;
            this.tbBugTitle.Name = "tbBugTitle";
            this.tbBugTitle.NormlBack = null;
            this.tbBugTitle.Padding = new System.Windows.Forms.Padding(5);
            this.tbBugTitle.ReadOnly = false;
            this.tbBugTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBugTitle.Size = new System.Drawing.Size(595, 28);
            // 
            // 
            // 
            this.tbBugTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBugTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBugTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbBugTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbBugTitle.SkinTxt.Name = "BaseText";
            this.tbBugTitle.SkinTxt.Size = new System.Drawing.Size(585, 18);
            this.tbBugTitle.SkinTxt.TabIndex = 0;
            this.tbBugTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbBugTitle.SkinTxt.WaterText = "必填(1-20位中文、英文、数字)...";
            this.tbBugTitle.TabIndex = 6;
            this.tbBugTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBugTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbBugTitle.WaterText = "必填(1-20位中文、英文、数字)...";
            this.tbBugTitle.WordWrap = true;
            // 
            // labProject
            // 
            this.labProject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProject.AutoSize = true;
            this.labProject.BackColor = System.Drawing.Color.White;
            this.labProject.BorderColor = System.Drawing.Color.White;
            this.labProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProject.Location = new System.Drawing.Point(3, 5);
            this.labProject.Name = "labProject";
            this.labProject.Size = new System.Drawing.Size(68, 17);
            this.labProject.TabIndex = 1;
            this.labProject.Text = "项目名称：";
            // 
            // tbProject
            // 
            this.tbProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProject.BackColor = System.Drawing.Color.Transparent;
            this.tbProject.DownBack = null;
            this.tbProject.Icon = null;
            this.tbProject.IconIsButton = false;
            this.tbProject.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbProject.IsPasswordChat = '\0';
            this.tbProject.IsSystemPasswordChar = false;
            this.tbProject.Lines = new string[0];
            this.tbProject.Location = new System.Drawing.Point(95, 0);
            this.tbProject.Margin = new System.Windows.Forms.Padding(0);
            this.tbProject.MaxLength = 32767;
            this.tbProject.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbProject.MouseBack = null;
            this.tbProject.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbProject.Multiline = false;
            this.tbProject.Name = "tbProject";
            this.tbProject.NormlBack = null;
            this.tbProject.Padding = new System.Windows.Forms.Padding(5);
            this.tbProject.ReadOnly = true;
            this.tbProject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProject.Size = new System.Drawing.Size(595, 28);
            // 
            // 
            // 
            this.tbProject.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProject.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProject.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbProject.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbProject.SkinTxt.Name = "BaseText";
            this.tbProject.SkinTxt.ReadOnly = true;
            this.tbProject.SkinTxt.Size = new System.Drawing.Size(585, 18);
            this.tbProject.SkinTxt.TabIndex = 0;
            this.tbProject.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbProject.SkinTxt.WaterText = "必选...";
            this.tbProject.TabIndex = 1;
            this.tbProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbProject.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbProject.WaterText = "必选...";
            this.tbProject.WordWrap = true;
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSelectProject.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectProject.Image")));
            this.btnSelectProject.Location = new System.Drawing.Point(693, 3);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(24, 21);
            this.btnSelectProject.TabIndex = 28;
            this.btnSelectProject.UseVisualStyleBackColor = false;
            // 
            // labStruct
            // 
            this.labStruct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStruct.AutoSize = true;
            this.labStruct.BackColor = System.Drawing.Color.White;
            this.labStruct.BorderColor = System.Drawing.Color.White;
            this.labStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStruct.Location = new System.Drawing.Point(723, 5);
            this.labStruct.Name = "labStruct";
            this.labStruct.Size = new System.Drawing.Size(68, 17);
            this.labStruct.TabIndex = 2;
            this.labStruct.Text = "产品架构：";
            // 
            // labOccurrence
            // 
            this.labOccurrence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labOccurrence.AutoSize = true;
            this.labOccurrence.BackColor = System.Drawing.Color.White;
            this.labOccurrence.BorderColor = System.Drawing.Color.White;
            this.labOccurrence.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOccurrence.Location = new System.Drawing.Point(723, 89);
            this.labOccurrence.Name = "labOccurrence";
            this.labOccurrence.Size = new System.Drawing.Size(68, 17);
            this.labOccurrence.TabIndex = 8;
            this.labOccurrence.Text = "发生概率：";
            // 
            // cbStruct
            // 
            this.cbStruct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStruct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStruct.FormattingEnabled = true;
            this.cbStruct.Location = new System.Drawing.Point(822, 3);
            this.cbStruct.Name = "cbStruct";
            this.cbStruct.Size = new System.Drawing.Size(589, 22);
            this.cbStruct.TabIndex = 2;
            this.cbStruct.WaterText = "必选...";
            // 
            // cbOccurrence
            // 
            this.cbOccurrence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOccurrence.FormattingEnabled = true;
            this.cbOccurrence.Items.AddRange(new object[] {
            "稳定复现",
            "概率复现"});
            this.cbOccurrence.Location = new System.Drawing.Point(822, 87);
            this.cbOccurrence.Name = "cbOccurrence";
            this.cbOccurrence.Size = new System.Drawing.Size(589, 22);
            this.cbOccurrence.TabIndex = 8;
            this.cbOccurrence.Text = "稳定复现";
            this.cbOccurrence.WaterText = "";
            // 
            // labVersion
            // 
            this.labVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labVersion.AutoSize = true;
            this.labVersion.BackColor = System.Drawing.Color.White;
            this.labVersion.BorderColor = System.Drawing.Color.White;
            this.labVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labVersion.Location = new System.Drawing.Point(3, 33);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(68, 17);
            this.labVersion.TabIndex = 29;
            this.labVersion.Text = "产品版本：";
            // 
            // labBugTitle
            // 
            this.labBugTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labBugTitle.AutoSize = true;
            this.labBugTitle.BackColor = System.Drawing.Color.White;
            this.labBugTitle.BorderColor = System.Drawing.Color.White;
            this.labBugTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBugTitle.Location = new System.Drawing.Point(723, 33);
            this.labBugTitle.Name = "labBugTitle";
            this.labBugTitle.Size = new System.Drawing.Size(68, 17);
            this.labBugTitle.TabIndex = 6;
            this.labBugTitle.Text = "缺陷名称：";
            // 
            // labCategory
            // 
            this.labCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCategory.AutoSize = true;
            this.labCategory.BackColor = System.Drawing.Color.White;
            this.labCategory.BorderColor = System.Drawing.Color.White;
            this.labCategory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCategory.Location = new System.Drawing.Point(723, 61);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(44, 17);
            this.labCategory.TabIndex = 30;
            this.labCategory.Text = "类别：";
            // 
            // labExceptDate
            // 
            this.labExceptDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExceptDate.AutoSize = true;
            this.labExceptDate.BackColor = System.Drawing.Color.White;
            this.labExceptDate.BorderColor = System.Drawing.Color.White;
            this.labExceptDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExceptDate.Location = new System.Drawing.Point(723, 117);
            this.labExceptDate.Name = "labExceptDate";
            this.labExceptDate.Size = new System.Drawing.Size(92, 17);
            this.labExceptDate.TabIndex = 31;
            this.labExceptDate.Text = "期望解决日期：";
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpEditDate.DropDownHeight = 180;
            this.dtpEditDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpEditDate.DropDownWidth = 120;
            this.dtpEditDate.Enabled = false;
            this.dtpEditDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpEditDate.Items = null;
            this.dtpEditDate.Location = new System.Drawing.Point(822, 143);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(589, 22);
            this.dtpEditDate.TabIndex = 12;
            this.dtpEditDate.text = "";
            // 
            // dtpExceptDate
            // 
            this.dtpExceptDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExceptDate.DropDownHeight = 180;
            this.dtpExceptDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpExceptDate.DropDownWidth = 120;
            this.dtpExceptDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpExceptDate.Items = null;
            this.dtpExceptDate.Location = new System.Drawing.Point(822, 115);
            this.dtpExceptDate.Name = "dtpExceptDate";
            this.dtpExceptDate.Size = new System.Drawing.Size(589, 22);
            this.dtpExceptDate.TabIndex = 33;
            this.dtpExceptDate.text = "";
            // 
            // cbCategory
            // 
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "功能类",
            "接口类",
            "逻辑类",
            "数据类",
            "UI类",
            "其他"});
            this.cbCategory.Location = new System.Drawing.Point(822, 59);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(589, 22);
            this.cbCategory.TabIndex = 37;
            this.cbCategory.Text = "功能类";
            this.cbCategory.WaterText = "";
            // 
            // cbHowFound
            // 
            this.cbHowFound.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHowFound.FormattingEnabled = true;
            this.cbHowFound.Items.AddRange(new object[] {
            "技术评审",
            "功能测试",
            "性能测试",
            "验收测试",
            "可靠性测试",
            "单元测试",
            "集成测试",
            "代码检查",
            "客户反馈"});
            this.cbHowFound.Location = new System.Drawing.Point(98, 59);
            this.cbHowFound.Name = "cbHowFound";
            this.cbHowFound.Size = new System.Drawing.Size(589, 22);
            this.cbHowFound.TabIndex = 34;
            this.cbHowFound.Text = "功能测试";
            this.cbHowFound.WaterText = "";
            // 
            // cbGravity
            // 
            this.cbGravity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGravity.FormattingEnabled = true;
            this.cbGravity.Items.AddRange(new object[] {
            "致命",
            "严重",
            "一般",
            "提示"});
            this.cbGravity.Location = new System.Drawing.Point(98, 87);
            this.cbGravity.Name = "cbGravity";
            this.cbGravity.Size = new System.Drawing.Size(589, 22);
            this.cbGravity.TabIndex = 35;
            this.cbGravity.Text = "一般";
            this.cbGravity.WaterText = "";
            // 
            // cbPriority
            // 
            this.cbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.cbPriority.Location = new System.Drawing.Point(98, 115);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(589, 22);
            this.cbPriority.TabIndex = 36;
            this.cbPriority.Text = "中";
            this.cbPriority.WaterText = "";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.tbAuthor.DownBack = null;
            this.tbAuthor.Enabled = false;
            this.tbAuthor.Icon = null;
            this.tbAuthor.IconIsButton = false;
            this.tbAuthor.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbAuthor.IsPasswordChat = '\0';
            this.tbAuthor.IsSystemPasswordChar = false;
            this.tbAuthor.Lines = new string[0];
            this.tbAuthor.Location = new System.Drawing.Point(95, 140);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.tbAuthor.MaxLength = 32767;
            this.tbAuthor.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbAuthor.MouseBack = null;
            this.tbAuthor.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbAuthor.Multiline = false;
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.NormlBack = null;
            this.tbAuthor.Padding = new System.Windows.Forms.Padding(5);
            this.tbAuthor.ReadOnly = false;
            this.tbAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAuthor.Size = new System.Drawing.Size(595, 28);
            // 
            // 
            // 
            this.tbAuthor.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthor.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuthor.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbAuthor.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbAuthor.SkinTxt.Name = "BaseText";
            this.tbAuthor.SkinTxt.Size = new System.Drawing.Size(585, 18);
            this.tbAuthor.SkinTxt.TabIndex = 0;
            this.tbAuthor.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbAuthor.SkinTxt.WaterText = "必填...";
            this.tbAuthor.TabIndex = 11;
            this.tbAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAuthor.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbAuthor.WaterText = "必填...";
            this.tbAuthor.WordWrap = true;
            // 
            // labHowFound
            // 
            this.labHowFound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labHowFound.AutoSize = true;
            this.labHowFound.BackColor = System.Drawing.Color.White;
            this.labHowFound.BorderColor = System.Drawing.Color.White;
            this.labHowFound.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHowFound.Location = new System.Drawing.Point(3, 61);
            this.labHowFound.Name = "labHowFound";
            this.labHowFound.Size = new System.Drawing.Size(68, 17);
            this.labHowFound.TabIndex = 7;
            this.labHowFound.Text = "发现方法：";
            // 
            // labGravity
            // 
            this.labGravity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGravity.AutoSize = true;
            this.labGravity.BackColor = System.Drawing.Color.White;
            this.labGravity.BorderColor = System.Drawing.Color.White;
            this.labGravity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGravity.Location = new System.Drawing.Point(3, 89);
            this.labGravity.Name = "labGravity";
            this.labGravity.Size = new System.Drawing.Size(56, 17);
            this.labGravity.TabIndex = 9;
            this.labGravity.Text = "严重性：";
            // 
            // labPriority
            // 
            this.labPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPriority.AutoSize = true;
            this.labPriority.BackColor = System.Drawing.Color.White;
            this.labPriority.BorderColor = System.Drawing.Color.White;
            this.labPriority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPriority.Location = new System.Drawing.Point(3, 117);
            this.labPriority.Name = "labPriority";
            this.labPriority.Size = new System.Drawing.Size(56, 17);
            this.labPriority.TabIndex = 10;
            this.labPriority.Text = "优先级：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.White;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 145);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(68, 17);
            this.labAuthor.TabIndex = 11;
            this.labAuthor.Text = "缺陷作者：";
            // 
            // tbModify
            // 
            this.tbModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModify.BackColor = System.Drawing.Color.Transparent;
            this.tbModify.DownBack = null;
            this.tbModify.Enabled = false;
            this.tbModify.Icon = null;
            this.tbModify.IconIsButton = false;
            this.tbModify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbModify.IsPasswordChat = '\0';
            this.tbModify.IsSystemPasswordChar = false;
            this.tbModify.Lines = new string[] {
        "必填..."};
            this.tbModify.Location = new System.Drawing.Point(95, 169);
            this.tbModify.Margin = new System.Windows.Forms.Padding(0);
            this.tbModify.MaxLength = 32767;
            this.tbModify.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbModify.MouseBack = null;
            this.tbModify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbModify.Multiline = false;
            this.tbModify.Name = "tbModify";
            this.tbModify.NormlBack = null;
            this.tbModify.Padding = new System.Windows.Forms.Padding(5);
            this.tbModify.ReadOnly = false;
            this.tbModify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbModify.Size = new System.Drawing.Size(595, 28);
            // 
            // 
            // 
            this.tbModify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModify.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbModify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbModify.SkinTxt.Name = "BaseText";
            this.tbModify.SkinTxt.Size = new System.Drawing.Size(585, 18);
            this.tbModify.SkinTxt.TabIndex = 0;
            this.tbModify.SkinTxt.Text = "必填...";
            this.tbModify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbModify.SkinTxt.WaterText = "";
            this.tbModify.TabIndex = 39;
            this.tbModify.Text = "必填...";
            this.tbModify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbModify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbModify.WaterText = "";
            this.tbModify.WordWrap = true;
            // 
            // labModifyDate
            // 
            this.labModifyDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifyDate.AutoSize = true;
            this.labModifyDate.BackColor = System.Drawing.Color.White;
            this.labModifyDate.BorderColor = System.Drawing.Color.White;
            this.labModifyDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifyDate.Location = new System.Drawing.Point(723, 174);
            this.labModifyDate.Name = "labModifyDate";
            this.labModifyDate.Size = new System.Drawing.Size(68, 17);
            this.labModifyDate.TabIndex = 41;
            this.labModifyDate.Text = "修改日期：";
            // 
            // labEditDate
            // 
            this.labEditDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labEditDate.AutoSize = true;
            this.labEditDate.BackColor = System.Drawing.Color.White;
            this.labEditDate.BorderColor = System.Drawing.Color.White;
            this.labEditDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEditDate.Location = new System.Drawing.Point(723, 145);
            this.labEditDate.Name = "labEditDate";
            this.labEditDate.Size = new System.Drawing.Size(68, 17);
            this.labEditDate.TabIndex = 12;
            this.labEditDate.Text = "编写日期：";
            // 
            // dtpModifyDate
            // 
            this.dtpModifyDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpModifyDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpModifyDate.DropDownHeight = 180;
            this.dtpModifyDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpModifyDate.DropDownWidth = 120;
            this.dtpModifyDate.Enabled = false;
            this.dtpModifyDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpModifyDate.Items = null;
            this.dtpModifyDate.Location = new System.Drawing.Point(822, 171);
            this.dtpModifyDate.Name = "dtpModifyDate";
            this.dtpModifyDate.Size = new System.Drawing.Size(589, 24);
            this.dtpModifyDate.TabIndex = 42;
            this.dtpModifyDate.text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labReproSteps, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbReproSteps, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbSamples, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbExcept, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbActually, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labSampes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labExcept, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labActually, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAttachment, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labAuditor, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbAuditor, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 537);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labReproSteps
            // 
            this.labReproSteps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labReproSteps.AutoSize = true;
            this.labReproSteps.BackColor = System.Drawing.Color.White;
            this.labReproSteps.BorderColor = System.Drawing.Color.White;
            this.labReproSteps.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReproSteps.Location = new System.Drawing.Point(3, 128);
            this.labReproSteps.Name = "labReproSteps";
            this.labReproSteps.Size = new System.Drawing.Size(68, 17);
            this.labReproSteps.TabIndex = 17;
            this.labReproSteps.Text = "复现步骤：";
            // 
            // rtbReproSteps
            // 
            this.rtbReproSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReproSteps.Location = new System.Drawing.Point(93, 3);
            this.rtbReproSteps.Name = "rtbReproSteps";
            this.rtbReproSteps.SelectControl = null;
            this.rtbReproSteps.SelectControlIndex = 0;
            this.rtbReproSteps.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtbReproSteps.Size = new System.Drawing.Size(1318, 268);
            this.rtbReproSteps.TabIndex = 17;
            this.rtbReproSteps.Text = "";
            // 
            // rtbSamples
            // 
            this.rtbSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSamples.Location = new System.Drawing.Point(93, 277);
            this.rtbSamples.Name = "rtbSamples";
            this.rtbSamples.SelectControl = null;
            this.rtbSamples.SelectControlIndex = 0;
            this.rtbSamples.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtbSamples.Size = new System.Drawing.Size(1318, 62);
            this.rtbSamples.TabIndex = 18;
            this.rtbSamples.Text = "";
            // 
            // rtbExcept
            // 
            this.rtbExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbExcept.Location = new System.Drawing.Point(93, 345);
            this.rtbExcept.Name = "rtbExcept";
            this.rtbExcept.SelectControl = null;
            this.rtbExcept.SelectControlIndex = 0;
            this.rtbExcept.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtbExcept.Size = new System.Drawing.Size(1318, 62);
            this.rtbExcept.TabIndex = 19;
            this.rtbExcept.Text = "";
            // 
            // rtbActually
            // 
            this.rtbActually.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbActually.Location = new System.Drawing.Point(93, 413);
            this.rtbActually.Name = "rtbActually";
            this.rtbActually.SelectControl = null;
            this.rtbActually.SelectControlIndex = 0;
            this.rtbActually.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtbActually.Size = new System.Drawing.Size(1318, 62);
            this.rtbActually.TabIndex = 20;
            this.rtbActually.Text = "";
            // 
            // labSampes
            // 
            this.labSampes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSampes.AutoSize = true;
            this.labSampes.BackColor = System.Drawing.Color.White;
            this.labSampes.BorderColor = System.Drawing.Color.White;
            this.labSampes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSampes.Location = new System.Drawing.Point(3, 299);
            this.labSampes.Name = "labSampes";
            this.labSampes.Size = new System.Drawing.Size(56, 17);
            this.labSampes.TabIndex = 18;
            this.labSampes.Text = "样本点：";
            // 
            // labExcept
            // 
            this.labExcept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExcept.AutoSize = true;
            this.labExcept.BackColor = System.Drawing.Color.White;
            this.labExcept.BorderColor = System.Drawing.Color.White;
            this.labExcept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExcept.Location = new System.Drawing.Point(3, 367);
            this.labExcept.Name = "labExcept";
            this.labExcept.Size = new System.Drawing.Size(68, 17);
            this.labExcept.TabIndex = 20;
            this.labExcept.Text = "预期结果：";
            // 
            // labActually
            // 
            this.labActually.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labActually.AutoSize = true;
            this.labActually.BackColor = System.Drawing.Color.White;
            this.labActually.BorderColor = System.Drawing.Color.White;
            this.labActually.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labActually.Location = new System.Drawing.Point(3, 435);
            this.labActually.Name = "labActually";
            this.labActually.Size = new System.Drawing.Size(68, 17);
            this.labActually.TabIndex = 21;
            this.labActually.Text = "实际结果：";
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAttachment.BackColor = System.Drawing.Color.Transparent;
            this.btnAttachment.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAttachment.DownBack = null;
            this.btnAttachment.Location = new System.Drawing.Point(93, 511);
            this.btnAttachment.MouseBack = null;
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.NormlBack = null;
            this.btnAttachment.Size = new System.Drawing.Size(70, 20);
            this.btnAttachment.TabIndex = 22;
            this.btnAttachment.Text = "添加附件";
            this.btnAttachment.UseVisualStyleBackColor = false;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // labAuditor
            // 
            this.labAuditor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuditor.AutoSize = true;
            this.labAuditor.BackColor = System.Drawing.Color.White;
            this.labAuditor.BorderColor = System.Drawing.Color.White;
            this.labAuditor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuditor.Location = new System.Drawing.Point(3, 483);
            this.labAuditor.Name = "labAuditor";
            this.labAuditor.Size = new System.Drawing.Size(56, 17);
            this.labAuditor.TabIndex = 24;
            this.labAuditor.Text = "审核人：";
            // 
            // cbAuditor
            // 
            this.cbAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAuditor.FormattingEnabled = true;
            this.cbAuditor.Location = new System.Drawing.Point(93, 482);
            this.cbAuditor.Name = "cbAuditor";
            this.cbAuditor.Size = new System.Drawing.Size(1318, 20);
            this.cbAuditor.TabIndex = 25;
            this.cbAuditor.DropDown += new System.EventHandler(this.cbAuditor_DropDown);
            // 
            // stsManager
            // 
            this.stsManager.Arrow = System.Drawing.Color.Black;
            this.stsManager.Back = System.Drawing.Color.White;
            this.stsManager.BackRadius = 4;
            this.stsManager.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.stsManager.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.stsManager.BaseFore = System.Drawing.Color.Black;
            this.stsManager.BaseForeAnamorphosis = false;
            this.stsManager.BaseForeAnamorphosisBorder = 4;
            this.stsManager.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.stsManager.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.stsManager.BaseHoverFore = System.Drawing.Color.White;
            this.stsManager.BaseItemAnamorphosis = true;
            this.stsManager.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemBorderShow = true;
            this.stsManager.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("stsManager.BaseItemDown")));
            this.stsManager.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("stsManager.BaseItemMouse")));
            this.stsManager.BaseItemNorml = null;
            this.stsManager.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemRadius = 4;
            this.stsManager.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BindTabControl = null;
            this.stsManager.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.stsManager.Fore = System.Drawing.Color.Black;
            this.stsManager.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.stsManager.HoverFore = System.Drawing.Color.White;
            this.stsManager.ItemAnamorphosis = true;
            this.stsManager.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemBorderShow = true;
            this.stsManager.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemRadius = 4;
            this.stsManager.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.btnSubmit,
            this.tsbQuite});
            this.stsManager.Location = new System.Drawing.Point(0, 0);
            this.stsManager.Name = "stsManager";
            this.stsManager.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.Size = new System.Drawing.Size(1426, 25);
            this.stsManager.SkinAllColor = true;
            this.stsManager.TabIndex = 3;
            this.stsManager.Text = "skinToolStrip1";
            this.stsManager.TitleAnamorphosis = true;
            this.stsManager.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.stsManager.TitleRadius = 4;
            this.stsManager.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 22);
            this.btnSubmit.Text = "保存并提交";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tsbQuite
            // 
            this.tsbQuite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbQuite.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuite.Image")));
            this.tsbQuite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuite.Name = "tsbQuite";
            this.tsbQuite.Size = new System.Drawing.Size(36, 22);
            this.tsbQuite.Text = "取消";
            this.tsbQuite.Click += new System.EventHandler(this.tsbQuite_Click);
            // 
            // ToolBugModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolBugModify";
            this.Text = "修改缺陷";
            
            this.Load += new System.EventHandler(this.ToolBugModify_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMainManager.ResumeLayout(false);
            this.tlpMainManager.PerformLayout();
            this.tlpMainEditor.ResumeLayout(false);
            this.tlpSort.ResumeLayout(false);
            this.tlpSort.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.stsManager.ResumeLayout(false);
            this.stsManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainManager;
        private System.Windows.Forms.TableLayoutPanel tlpMainEditor;
        private System.Windows.Forms.TableLayoutPanel tlpSort;
        private CCWin.SkinControl.SkinComboBox cbVersion;
        private CCWin.SkinControl.SkinTextBox tbBugTitle;
        private CCWin.SkinControl.SkinLabel labProject;
        private CCWin.SkinControl.SkinTextBox tbProject;
        private System.Windows.Forms.Button btnSelectProject;
        private CCWin.SkinControl.SkinLabel labStruct;
        private CCWin.SkinControl.SkinLabel labOccurrence;
        private CCWin.SkinControl.SkinComboBox cbStruct;
        private CCWin.SkinControl.SkinComboBox cbOccurrence;
        private CCWin.SkinControl.SkinLabel labVersion;
        private CCWin.SkinControl.SkinLabel labBugTitle;
        private CCWin.SkinControl.SkinLabel labCategory;
        private CCWin.SkinControl.SkinLabel labExceptDate;
        private CCWin.SkinControl.SkinDateTimePicker dtpEditDate;
        private CCWin.SkinControl.SkinDateTimePicker dtpExceptDate;
        private CCWin.SkinControl.SkinComboBox cbCategory;
        private CCWin.SkinControl.SkinComboBox cbHowFound;
        private CCWin.SkinControl.SkinComboBox cbGravity;
        private CCWin.SkinControl.SkinComboBox cbPriority;
        private CCWin.SkinControl.SkinTextBox tbAuthor;
        private CCWin.SkinControl.SkinLabel labHowFound;
        private CCWin.SkinControl.SkinLabel labGravity;
        private CCWin.SkinControl.SkinLabel labPriority;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labEditDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labReproSteps;
        private CCWin.SkinControl.SkinChatRichTextBox rtbReproSteps;
        private CCWin.SkinControl.SkinChatRichTextBox rtbSamples;
        private CCWin.SkinControl.SkinChatRichTextBox rtbExcept;
        private CCWin.SkinControl.SkinChatRichTextBox rtbActually;
        private CCWin.SkinControl.SkinLabel labSampes;
        private CCWin.SkinControl.SkinLabel labExcept;
        private CCWin.SkinControl.SkinLabel labActually;
        private CCWin.SkinControl.SkinButton btnAttachment;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox tbModify;
        private CCWin.SkinControl.SkinLabel labModifyDate;
        private CCWin.SkinControl.SkinDateTimePicker dtpModifyDate;
        private System.Windows.Forms.ToolStripButton btnSubmit;
        private CCWin.SkinControl.SkinLabel labAuditor;
        private System.Windows.Forms.ComboBox cbAuditor;
    }
}