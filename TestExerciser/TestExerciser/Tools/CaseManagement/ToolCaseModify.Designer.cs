namespace TestExerciser.Tools.CaseManagement
{
    partial class ToolCaseModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolCaseModify));
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.labProject = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labReqNO = new CCWin.SkinControl.SkinLabel();
            this.tProject = new CCWin.SkinControl.SkinTextBox();
            this.labSuiteNO = new CCWin.SkinControl.SkinLabel();
            this.labSuiteName = new CCWin.SkinControl.SkinLabel();
            this.labCaseNO = new CCWin.SkinControl.SkinLabel();
            this.tSuiteNO = new CCWin.SkinControl.SkinTextBox();
            this.tSuiteName = new CCWin.SkinControl.SkinTextBox();
            this.tCaseNO = new CCWin.SkinControl.SkinTextBox();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.labCaseName = new CCWin.SkinControl.SkinLabel();
            this.tCaseName = new CCWin.SkinControl.SkinTextBox();
            this.labStruct = new CCWin.SkinControl.SkinLabel();
            this.labCaseLevel = new CCWin.SkinControl.SkinLabel();
            this.cStruct = new CCWin.SkinControl.SkinComboBox();
            this.cCaseLevel = new CCWin.SkinControl.SkinComboBox();
            this.tReqNO = new CCWin.SkinControl.SkinTextBox();
            this.tAuthor = new CCWin.SkinControl.SkinTextBox();
            this.labEditDate = new CCWin.SkinControl.SkinLabel();
            this.labModifyDate = new CCWin.SkinControl.SkinLabel();
            this.dtpModifyDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.labIfAuto = new CCWin.SkinControl.SkinLabel();
            this.cIfAuto = new CCWin.SkinControl.SkinComboBox();
            this.labModifier = new CCWin.SkinControl.SkinLabel();
            this.tModifier = new CCWin.SkinControl.SkinTextBox();
            this.tEditDate = new CCWin.SkinControl.SkinTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labPrecondition = new CCWin.SkinControl.SkinLabel();
            this.labSteps = new CCWin.SkinControl.SkinLabel();
            this.labSamples = new CCWin.SkinControl.SkinLabel();
            this.labExcept = new CCWin.SkinControl.SkinLabel();
            this.rtPrecondition = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtSteps = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtSamples = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtExcept = new CCWin.SkinControl.SkinChatRichTextBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbQuite = new System.Windows.Forms.ToolStripButton();
            this.tlpMainManager.SuspendLayout();
            this.tlpMainEditor.SuspendLayout();
            this.tlpSort.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.stsManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainManager
            // 
            this.tlpMainManager.ColumnCount = 1;
            this.tlpMainManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Controls.Add(this.tlpMainEditor, 0, 1);
            this.tlpMainManager.Controls.Add(this.stsManager, 0, 0);
            this.tlpMainManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainManager.Location = new System.Drawing.Point(4, 32);
            this.tlpMainManager.Name = "tlpMainManager";
            this.tlpMainManager.RowCount = 2;
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Size = new System.Drawing.Size(1432, 789);
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
            this.tlpMainEditor.Size = new System.Drawing.Size(1426, 753);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 5;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.Controls.Add(this.labProject, 0, 0);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 4);
            this.tlpSort.Controls.Add(this.labReqNO, 0, 3);
            this.tlpSort.Controls.Add(this.tProject, 1, 0);
            this.tlpSort.Controls.Add(this.labSuiteNO, 0, 1);
            this.tlpSort.Controls.Add(this.labSuiteName, 3, 1);
            this.tlpSort.Controls.Add(this.labCaseNO, 0, 2);
            this.tlpSort.Controls.Add(this.tSuiteNO, 1, 1);
            this.tlpSort.Controls.Add(this.tSuiteName, 4, 1);
            this.tlpSort.Controls.Add(this.tCaseNO, 1, 2);
            this.tlpSort.Controls.Add(this.btnAuthor, 2, 0);
            this.tlpSort.Controls.Add(this.labCaseName, 3, 2);
            this.tlpSort.Controls.Add(this.tCaseName, 4, 2);
            this.tlpSort.Controls.Add(this.labStruct, 3, 0);
            this.tlpSort.Controls.Add(this.labCaseLevel, 3, 3);
            this.tlpSort.Controls.Add(this.cStruct, 4, 0);
            this.tlpSort.Controls.Add(this.cCaseLevel, 4, 3);
            this.tlpSort.Controls.Add(this.tReqNO, 1, 3);
            this.tlpSort.Controls.Add(this.tAuthor, 1, 4);
            this.tlpSort.Controls.Add(this.labEditDate, 3, 4);
            this.tlpSort.Controls.Add(this.labModifyDate, 3, 5);
            this.tlpSort.Controls.Add(this.dtpModifyDate, 4, 5);
            this.tlpSort.Controls.Add(this.labIfAuto, 0, 6);
            this.tlpSort.Controls.Add(this.cIfAuto, 1, 6);
            this.tlpSort.Controls.Add(this.labModifier, 0, 5);
            this.tlpSort.Controls.Add(this.tModifier, 1, 5);
            this.tlpSort.Controls.Add(this.tEditDate, 4, 4);
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
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSort.Size = new System.Drawing.Size(1420, 198);
            this.tlpSort.TabIndex = 2;
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
            this.labProject.Text = "所属项目：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.White;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 117);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(68, 17);
            this.labAuthor.TabIndex = 11;
            this.labAuthor.Text = "用例作者：";
            // 
            // labReqNO
            // 
            this.labReqNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labReqNO.AutoSize = true;
            this.labReqNO.BackColor = System.Drawing.Color.White;
            this.labReqNO.BorderColor = System.Drawing.Color.White;
            this.labReqNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReqNO.Location = new System.Drawing.Point(3, 89);
            this.labReqNO.Name = "labReqNO";
            this.labReqNO.Size = new System.Drawing.Size(68, 17);
            this.labReqNO.TabIndex = 7;
            this.labReqNO.Text = "需求编号：";
            // 
            // tProject
            // 
            this.tProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tProject.BackColor = System.Drawing.Color.Transparent;
            this.tProject.DownBack = null;
            this.tProject.Icon = null;
            this.tProject.IconIsButton = false;
            this.tProject.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProject.IsPasswordChat = '\0';
            this.tProject.IsSystemPasswordChar = false;
            this.tProject.Lines = new string[0];
            this.tProject.Location = new System.Drawing.Point(95, 0);
            this.tProject.Margin = new System.Windows.Forms.Padding(0);
            this.tProject.MaxLength = 32767;
            this.tProject.MinimumSize = new System.Drawing.Size(28, 28);
            this.tProject.MouseBack = null;
            this.tProject.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProject.Multiline = false;
            this.tProject.Name = "tProject";
            this.tProject.NormlBack = null;
            this.tProject.Padding = new System.Windows.Forms.Padding(5);
            this.tProject.ReadOnly = true;
            this.tProject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tProject.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tProject.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tProject.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tProject.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tProject.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tProject.SkinTxt.Name = "BaseText";
            this.tProject.SkinTxt.ReadOnly = true;
            this.tProject.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tProject.SkinTxt.TabIndex = 0;
            this.tProject.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProject.SkinTxt.WaterText = "必选...";
            this.tProject.TabIndex = 1;
            this.tProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tProject.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProject.WaterText = "必选...";
            this.tProject.WordWrap = true;
            // 
            // labSuiteNO
            // 
            this.labSuiteNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSuiteNO.AutoSize = true;
            this.labSuiteNO.BackColor = System.Drawing.Color.White;
            this.labSuiteNO.BorderColor = System.Drawing.Color.White;
            this.labSuiteNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSuiteNO.Location = new System.Drawing.Point(3, 33);
            this.labSuiteNO.Name = "labSuiteNO";
            this.labSuiteNO.Size = new System.Drawing.Size(80, 17);
            this.labSuiteNO.TabIndex = 3;
            this.labSuiteNO.Text = "测试套编号：";
            // 
            // labSuiteName
            // 
            this.labSuiteName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSuiteName.AutoSize = true;
            this.labSuiteName.BackColor = System.Drawing.Color.White;
            this.labSuiteName.BorderColor = System.Drawing.Color.White;
            this.labSuiteName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSuiteName.Location = new System.Drawing.Point(730, 33);
            this.labSuiteName.Name = "labSuiteName";
            this.labSuiteName.Size = new System.Drawing.Size(80, 17);
            this.labSuiteName.TabIndex = 4;
            this.labSuiteName.Text = "测试套名称：";
            // 
            // labCaseNO
            // 
            this.labCaseNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCaseNO.AutoSize = true;
            this.labCaseNO.BackColor = System.Drawing.Color.White;
            this.labCaseNO.BorderColor = System.Drawing.Color.White;
            this.labCaseNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaseNO.Location = new System.Drawing.Point(3, 61);
            this.labCaseNO.Name = "labCaseNO";
            this.labCaseNO.Size = new System.Drawing.Size(68, 17);
            this.labCaseNO.TabIndex = 5;
            this.labCaseNO.Text = "用例编号：";
            // 
            // tSuiteNO
            // 
            this.tSuiteNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tSuiteNO.BackColor = System.Drawing.Color.Transparent;
            this.tSuiteNO.DownBack = null;
            this.tSuiteNO.Icon = null;
            this.tSuiteNO.IconIsButton = false;
            this.tSuiteNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tSuiteNO.IsPasswordChat = '\0';
            this.tSuiteNO.IsSystemPasswordChar = false;
            this.tSuiteNO.Lines = new string[0];
            this.tSuiteNO.Location = new System.Drawing.Point(95, 28);
            this.tSuiteNO.Margin = new System.Windows.Forms.Padding(0);
            this.tSuiteNO.MaxLength = 32767;
            this.tSuiteNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tSuiteNO.MouseBack = null;
            this.tSuiteNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tSuiteNO.Multiline = false;
            this.tSuiteNO.Name = "tSuiteNO";
            this.tSuiteNO.NormlBack = null;
            this.tSuiteNO.Padding = new System.Windows.Forms.Padding(5);
            this.tSuiteNO.ReadOnly = false;
            this.tSuiteNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tSuiteNO.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tSuiteNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tSuiteNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSuiteNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tSuiteNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tSuiteNO.SkinTxt.Name = "BaseText";
            this.tSuiteNO.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tSuiteNO.SkinTxt.TabIndex = 0;
            this.tSuiteNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tSuiteNO.SkinTxt.WaterText = "（产品_子系统_父模块_子模块_测试套记号）";
            this.tSuiteNO.TabIndex = 3;
            this.tSuiteNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tSuiteNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tSuiteNO.WaterText = "（产品_子系统_父模块_子模块_测试套记号）";
            this.tSuiteNO.WordWrap = true;
            this.tSuiteNO.Leave += new System.EventHandler(this.tSuiteNO_Leave);
            // 
            // tSuiteName
            // 
            this.tSuiteName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tSuiteName.BackColor = System.Drawing.Color.Transparent;
            this.tSuiteName.DownBack = null;
            this.tSuiteName.Icon = null;
            this.tSuiteName.IconIsButton = false;
            this.tSuiteName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tSuiteName.IsPasswordChat = '\0';
            this.tSuiteName.IsSystemPasswordChar = false;
            this.tSuiteName.Lines = new string[0];
            this.tSuiteName.Location = new System.Drawing.Point(817, 28);
            this.tSuiteName.Margin = new System.Windows.Forms.Padding(0);
            this.tSuiteName.MaxLength = 32767;
            this.tSuiteName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tSuiteName.MouseBack = null;
            this.tSuiteName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tSuiteName.Multiline = false;
            this.tSuiteName.Name = "tSuiteName";
            this.tSuiteName.NormlBack = null;
            this.tSuiteName.Padding = new System.Windows.Forms.Padding(5);
            this.tSuiteName.ReadOnly = false;
            this.tSuiteName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tSuiteName.Size = new System.Drawing.Size(603, 28);
            // 
            // 
            // 
            this.tSuiteName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tSuiteName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSuiteName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tSuiteName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tSuiteName.SkinTxt.Name = "BaseText";
            this.tSuiteName.SkinTxt.Size = new System.Drawing.Size(593, 18);
            this.tSuiteName.SkinTxt.TabIndex = 0;
            this.tSuiteName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tSuiteName.SkinTxt.WaterText = "必填...";
            this.tSuiteName.TabIndex = 4;
            this.tSuiteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tSuiteName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tSuiteName.WaterText = "必填...";
            this.tSuiteName.WordWrap = true;
            // 
            // tCaseNO
            // 
            this.tCaseNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tCaseNO.BackColor = System.Drawing.Color.Transparent;
            this.tCaseNO.DownBack = null;
            this.tCaseNO.Icon = null;
            this.tCaseNO.IconIsButton = false;
            this.tCaseNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCaseNO.IsPasswordChat = '\0';
            this.tCaseNO.IsSystemPasswordChar = false;
            this.tCaseNO.Lines = new string[0];
            this.tCaseNO.Location = new System.Drawing.Point(95, 56);
            this.tCaseNO.Margin = new System.Windows.Forms.Padding(0);
            this.tCaseNO.MaxLength = 32767;
            this.tCaseNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tCaseNO.MouseBack = null;
            this.tCaseNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCaseNO.Multiline = false;
            this.tCaseNO.Name = "tCaseNO";
            this.tCaseNO.NormlBack = null;
            this.tCaseNO.Padding = new System.Windows.Forms.Padding(5);
            this.tCaseNO.ReadOnly = false;
            this.tCaseNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCaseNO.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tCaseNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCaseNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCaseNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tCaseNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tCaseNO.SkinTxt.Name = "BaseText";
            this.tCaseNO.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tCaseNO.SkinTxt.TabIndex = 0;
            this.tCaseNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCaseNO.SkinTxt.WaterText = "（产品_子系统_父模块_子模块_测试套记号_用例记号）";
            this.tCaseNO.TabIndex = 5;
            this.tCaseNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tCaseNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCaseNO.WaterText = "（产品_子系统_父模块_子模块_测试套记号_用例记号）";
            this.tCaseNO.WordWrap = true;
            this.tCaseNO.Leave += new System.EventHandler(this.tCaseNO_Leave);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.Image")));
            this.btnAuthor.Location = new System.Drawing.Point(700, 3);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(24, 21);
            this.btnAuthor.TabIndex = 28;
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // labCaseName
            // 
            this.labCaseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCaseName.AutoSize = true;
            this.labCaseName.BackColor = System.Drawing.Color.White;
            this.labCaseName.BorderColor = System.Drawing.Color.White;
            this.labCaseName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaseName.Location = new System.Drawing.Point(730, 61);
            this.labCaseName.Name = "labCaseName";
            this.labCaseName.Size = new System.Drawing.Size(68, 17);
            this.labCaseName.TabIndex = 6;
            this.labCaseName.Text = "用例名称：";
            // 
            // tCaseName
            // 
            this.tCaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tCaseName.BackColor = System.Drawing.Color.Transparent;
            this.tCaseName.DownBack = null;
            this.tCaseName.Icon = null;
            this.tCaseName.IconIsButton = false;
            this.tCaseName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCaseName.IsPasswordChat = '\0';
            this.tCaseName.IsSystemPasswordChar = false;
            this.tCaseName.Lines = new string[0];
            this.tCaseName.Location = new System.Drawing.Point(817, 56);
            this.tCaseName.Margin = new System.Windows.Forms.Padding(0);
            this.tCaseName.MaxLength = 32767;
            this.tCaseName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tCaseName.MouseBack = null;
            this.tCaseName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCaseName.Multiline = false;
            this.tCaseName.Name = "tCaseName";
            this.tCaseName.NormlBack = null;
            this.tCaseName.Padding = new System.Windows.Forms.Padding(5);
            this.tCaseName.ReadOnly = false;
            this.tCaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCaseName.Size = new System.Drawing.Size(603, 28);
            // 
            // 
            // 
            this.tCaseName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCaseName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCaseName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tCaseName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tCaseName.SkinTxt.Name = "BaseText";
            this.tCaseName.SkinTxt.Size = new System.Drawing.Size(593, 18);
            this.tCaseName.SkinTxt.TabIndex = 0;
            this.tCaseName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCaseName.SkinTxt.WaterText = "必填...";
            this.tCaseName.TabIndex = 6;
            this.tCaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tCaseName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCaseName.WaterText = "必填...";
            this.tCaseName.WordWrap = true;
            // 
            // labStruct
            // 
            this.labStruct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStruct.AutoSize = true;
            this.labStruct.BackColor = System.Drawing.Color.White;
            this.labStruct.BorderColor = System.Drawing.Color.White;
            this.labStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStruct.Location = new System.Drawing.Point(730, 5);
            this.labStruct.Name = "labStruct";
            this.labStruct.Size = new System.Drawing.Size(68, 17);
            this.labStruct.TabIndex = 2;
            this.labStruct.Text = "产品架构：";
            // 
            // labCaseLevel
            // 
            this.labCaseLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCaseLevel.AutoSize = true;
            this.labCaseLevel.BackColor = System.Drawing.Color.White;
            this.labCaseLevel.BorderColor = System.Drawing.Color.White;
            this.labCaseLevel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaseLevel.Location = new System.Drawing.Point(730, 89);
            this.labCaseLevel.Name = "labCaseLevel";
            this.labCaseLevel.Size = new System.Drawing.Size(68, 17);
            this.labCaseLevel.TabIndex = 8;
            this.labCaseLevel.Text = "用例级别：";
            // 
            // cStruct
            // 
            this.cStruct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cStruct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cStruct.FormattingEnabled = true;
            this.cStruct.Location = new System.Drawing.Point(820, 3);
            this.cStruct.Name = "cStruct";
            this.cStruct.Size = new System.Drawing.Size(597, 22);
            this.cStruct.TabIndex = 2;
            this.cStruct.WaterText = "必选...";
            // 
            // cCaseLevel
            // 
            this.cCaseLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cCaseLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cCaseLevel.FormattingEnabled = true;
            this.cCaseLevel.Items.AddRange(new object[] {
            "级别1",
            "级别2",
            "级别3"});
            this.cCaseLevel.Location = new System.Drawing.Point(820, 87);
            this.cCaseLevel.Name = "cCaseLevel";
            this.cCaseLevel.Size = new System.Drawing.Size(597, 22);
            this.cCaseLevel.TabIndex = 8;
            this.cCaseLevel.Text = "级别1";
            this.cCaseLevel.WaterText = "";
            // 
            // tReqNO
            // 
            this.tReqNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tReqNO.BackColor = System.Drawing.Color.Transparent;
            this.tReqNO.DownBack = null;
            this.tReqNO.Icon = null;
            this.tReqNO.IconIsButton = false;
            this.tReqNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tReqNO.IsPasswordChat = '\0';
            this.tReqNO.IsSystemPasswordChar = false;
            this.tReqNO.Lines = new string[0];
            this.tReqNO.Location = new System.Drawing.Point(95, 84);
            this.tReqNO.Margin = new System.Windows.Forms.Padding(0);
            this.tReqNO.MaxLength = 32767;
            this.tReqNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tReqNO.MouseBack = null;
            this.tReqNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tReqNO.Multiline = false;
            this.tReqNO.Name = "tReqNO";
            this.tReqNO.NormlBack = null;
            this.tReqNO.Padding = new System.Windows.Forms.Padding(5);
            this.tReqNO.ReadOnly = false;
            this.tReqNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tReqNO.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tReqNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tReqNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tReqNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tReqNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tReqNO.SkinTxt.Name = "BaseText";
            this.tReqNO.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tReqNO.SkinTxt.TabIndex = 0;
            this.tReqNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tReqNO.SkinTxt.WaterText = "可填...";
            this.tReqNO.TabIndex = 7;
            this.tReqNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tReqNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tReqNO.WaterText = "可填...";
            this.tReqNO.WordWrap = true;
            // 
            // tAuthor
            // 
            this.tAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tAuthor.BackColor = System.Drawing.Color.Transparent;
            this.tAuthor.DownBack = null;
            this.tAuthor.Enabled = false;
            this.tAuthor.Icon = null;
            this.tAuthor.IconIsButton = false;
            this.tAuthor.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAuthor.IsPasswordChat = '\0';
            this.tAuthor.IsSystemPasswordChar = false;
            this.tAuthor.Lines = new string[0];
            this.tAuthor.Location = new System.Drawing.Point(95, 112);
            this.tAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.tAuthor.MaxLength = 32767;
            this.tAuthor.MinimumSize = new System.Drawing.Size(28, 28);
            this.tAuthor.MouseBack = null;
            this.tAuthor.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAuthor.Multiline = false;
            this.tAuthor.Name = "tAuthor";
            this.tAuthor.NormlBack = null;
            this.tAuthor.Padding = new System.Windows.Forms.Padding(5);
            this.tAuthor.ReadOnly = false;
            this.tAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tAuthor.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tAuthor.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tAuthor.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAuthor.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tAuthor.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tAuthor.SkinTxt.Name = "BaseText";
            this.tAuthor.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tAuthor.SkinTxt.TabIndex = 0;
            this.tAuthor.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAuthor.SkinTxt.WaterText = "必填...";
            this.tAuthor.TabIndex = 11;
            this.tAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAuthor.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAuthor.WaterText = "必填...";
            this.tAuthor.WordWrap = true;
            // 
            // labEditDate
            // 
            this.labEditDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labEditDate.AutoSize = true;
            this.labEditDate.BackColor = System.Drawing.Color.White;
            this.labEditDate.BorderColor = System.Drawing.Color.White;
            this.labEditDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEditDate.Location = new System.Drawing.Point(730, 117);
            this.labEditDate.Name = "labEditDate";
            this.labEditDate.Size = new System.Drawing.Size(68, 17);
            this.labEditDate.TabIndex = 12;
            this.labEditDate.Text = "编写日期：";
            // 
            // labModifyDate
            // 
            this.labModifyDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifyDate.AutoSize = true;
            this.labModifyDate.BackColor = System.Drawing.Color.White;
            this.labModifyDate.BorderColor = System.Drawing.Color.White;
            this.labModifyDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifyDate.Location = new System.Drawing.Point(730, 145);
            this.labModifyDate.Name = "labModifyDate";
            this.labModifyDate.Size = new System.Drawing.Size(68, 17);
            this.labModifyDate.TabIndex = 14;
            this.labModifyDate.Text = "修改日期：";
            // 
            // dtpModifyDate
            // 
            this.dtpModifyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpModifyDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpModifyDate.DropDownHeight = 180;
            this.dtpModifyDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpModifyDate.DropDownWidth = 120;
            this.dtpModifyDate.Enabled = false;
            this.dtpModifyDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpModifyDate.Items = null;
            this.dtpModifyDate.Location = new System.Drawing.Point(820, 143);
            this.dtpModifyDate.Name = "dtpModifyDate";
            this.dtpModifyDate.Size = new System.Drawing.Size(597, 22);
            this.dtpModifyDate.TabIndex = 14;
            this.dtpModifyDate.text = "";
            // 
            // labIfAuto
            // 
            this.labIfAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfAuto.AutoSize = true;
            this.labIfAuto.BackColor = System.Drawing.Color.White;
            this.labIfAuto.BorderColor = System.Drawing.Color.White;
            this.labIfAuto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIfAuto.Location = new System.Drawing.Point(3, 174);
            this.labIfAuto.Name = "labIfAuto";
            this.labIfAuto.Size = new System.Drawing.Size(80, 17);
            this.labIfAuto.TabIndex = 13;
            this.labIfAuto.Text = "是否自动化：";
            // 
            // cIfAuto
            // 
            this.cIfAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cIfAuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cIfAuto.FormattingEnabled = true;
            this.cIfAuto.Items.AddRange(new object[] {
            "Ture",
            "False"});
            this.cIfAuto.Location = new System.Drawing.Point(98, 172);
            this.cIfAuto.Name = "cIfAuto";
            this.cIfAuto.Size = new System.Drawing.Size(596, 22);
            this.cIfAuto.TabIndex = 13;
            this.cIfAuto.WaterText = "必填...";
            // 
            // labModifier
            // 
            this.labModifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifier.AutoSize = true;
            this.labModifier.BackColor = System.Drawing.Color.White;
            this.labModifier.BorderColor = System.Drawing.Color.White;
            this.labModifier.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifier.Location = new System.Drawing.Point(3, 145);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(68, 17);
            this.labModifier.TabIndex = 29;
            this.labModifier.Text = "修改人员：";
            // 
            // tModifier
            // 
            this.tModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tModifier.BackColor = System.Drawing.Color.Transparent;
            this.tModifier.DownBack = null;
            this.tModifier.Enabled = false;
            this.tModifier.Icon = null;
            this.tModifier.IconIsButton = false;
            this.tModifier.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tModifier.IsPasswordChat = '\0';
            this.tModifier.IsSystemPasswordChar = false;
            this.tModifier.Lines = new string[0];
            this.tModifier.Location = new System.Drawing.Point(95, 140);
            this.tModifier.Margin = new System.Windows.Forms.Padding(0);
            this.tModifier.MaxLength = 32767;
            this.tModifier.MinimumSize = new System.Drawing.Size(28, 28);
            this.tModifier.MouseBack = null;
            this.tModifier.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tModifier.Multiline = false;
            this.tModifier.Name = "tModifier";
            this.tModifier.NormlBack = null;
            this.tModifier.Padding = new System.Windows.Forms.Padding(5);
            this.tModifier.ReadOnly = false;
            this.tModifier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tModifier.Size = new System.Drawing.Size(602, 28);
            // 
            // 
            // 
            this.tModifier.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tModifier.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tModifier.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tModifier.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tModifier.SkinTxt.Name = "BaseText";
            this.tModifier.SkinTxt.Size = new System.Drawing.Size(592, 18);
            this.tModifier.SkinTxt.TabIndex = 0;
            this.tModifier.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tModifier.SkinTxt.WaterText = "必填...";
            this.tModifier.TabIndex = 30;
            this.tModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tModifier.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tModifier.WaterText = "必填...";
            this.tModifier.WordWrap = true;
            // 
            // tEditDate
            // 
            this.tEditDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tEditDate.BackColor = System.Drawing.Color.Transparent;
            this.tEditDate.DownBack = null;
            this.tEditDate.Enabled = false;
            this.tEditDate.Icon = null;
            this.tEditDate.IconIsButton = false;
            this.tEditDate.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tEditDate.IsPasswordChat = '\0';
            this.tEditDate.IsSystemPasswordChar = false;
            this.tEditDate.Lines = new string[0];
            this.tEditDate.Location = new System.Drawing.Point(817, 112);
            this.tEditDate.Margin = new System.Windows.Forms.Padding(0);
            this.tEditDate.MaxLength = 32767;
            this.tEditDate.MinimumSize = new System.Drawing.Size(28, 28);
            this.tEditDate.MouseBack = null;
            this.tEditDate.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tEditDate.Multiline = false;
            this.tEditDate.Name = "tEditDate";
            this.tEditDate.NormlBack = null;
            this.tEditDate.Padding = new System.Windows.Forms.Padding(5);
            this.tEditDate.ReadOnly = false;
            this.tEditDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tEditDate.Size = new System.Drawing.Size(603, 28);
            // 
            // 
            // 
            this.tEditDate.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tEditDate.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tEditDate.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tEditDate.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tEditDate.SkinTxt.Name = "BaseText";
            this.tEditDate.SkinTxt.Size = new System.Drawing.Size(593, 18);
            this.tEditDate.SkinTxt.TabIndex = 0;
            this.tEditDate.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tEditDate.SkinTxt.WaterText = "必填...";
            this.tEditDate.TabIndex = 31;
            this.tEditDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tEditDate.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tEditDate.WaterText = "必填...";
            this.tEditDate.WordWrap = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labPrecondition, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labSteps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labSamples, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labExcept, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rtPrecondition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtSteps, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtSamples, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtExcept, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1420, 543);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labPrecondition
            // 
            this.labPrecondition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPrecondition.AutoSize = true;
            this.labPrecondition.BackColor = System.Drawing.Color.White;
            this.labPrecondition.BorderColor = System.Drawing.Color.White;
            this.labPrecondition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPrecondition.Location = new System.Drawing.Point(3, 45);
            this.labPrecondition.Name = "labPrecondition";
            this.labPrecondition.Size = new System.Drawing.Size(68, 17);
            this.labPrecondition.TabIndex = 17;
            this.labPrecondition.Text = "预置条件：";
            // 
            // labSteps
            // 
            this.labSteps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSteps.AutoSize = true;
            this.labSteps.BackColor = System.Drawing.Color.White;
            this.labSteps.BorderColor = System.Drawing.Color.White;
            this.labSteps.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSteps.Location = new System.Drawing.Point(3, 208);
            this.labSteps.Name = "labSteps";
            this.labSteps.Size = new System.Drawing.Size(68, 17);
            this.labSteps.TabIndex = 18;
            this.labSteps.Text = "用例步骤：";
            // 
            // labSamples
            // 
            this.labSamples.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSamples.AutoSize = true;
            this.labSamples.BackColor = System.Drawing.Color.White;
            this.labSamples.BorderColor = System.Drawing.Color.White;
            this.labSamples.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSamples.Location = new System.Drawing.Point(3, 370);
            this.labSamples.Name = "labSamples";
            this.labSamples.Size = new System.Drawing.Size(56, 17);
            this.labSamples.TabIndex = 19;
            this.labSamples.Text = "样本点：";
            // 
            // labExcept
            // 
            this.labExcept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExcept.AutoSize = true;
            this.labExcept.BackColor = System.Drawing.Color.White;
            this.labExcept.BorderColor = System.Drawing.Color.White;
            this.labExcept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExcept.Location = new System.Drawing.Point(3, 479);
            this.labExcept.Name = "labExcept";
            this.labExcept.Size = new System.Drawing.Size(68, 17);
            this.labExcept.TabIndex = 20;
            this.labExcept.Text = "预期结果：";
            // 
            // rtPrecondition
            // 
            this.rtPrecondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtPrecondition.Location = new System.Drawing.Point(93, 3);
            this.rtPrecondition.Name = "rtPrecondition";
            this.rtPrecondition.SelectControl = null;
            this.rtPrecondition.SelectControlIndex = 0;
            this.rtPrecondition.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtPrecondition.Size = new System.Drawing.Size(1324, 102);
            this.rtPrecondition.TabIndex = 17;
            this.rtPrecondition.Text = "";
            // 
            // rtSteps
            // 
            this.rtSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtSteps.Location = new System.Drawing.Point(93, 111);
            this.rtSteps.Name = "rtSteps";
            this.rtSteps.SelectControl = null;
            this.rtSteps.SelectControlIndex = 0;
            this.rtSteps.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtSteps.Size = new System.Drawing.Size(1324, 211);
            this.rtSteps.TabIndex = 18;
            this.rtSteps.Text = "";
            // 
            // rtSamples
            // 
            this.rtSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtSamples.Location = new System.Drawing.Point(93, 328);
            this.rtSamples.Name = "rtSamples";
            this.rtSamples.SelectControl = null;
            this.rtSamples.SelectControlIndex = 0;
            this.rtSamples.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtSamples.Size = new System.Drawing.Size(1324, 102);
            this.rtSamples.TabIndex = 19;
            this.rtSamples.Text = "";
            // 
            // rtExcept
            // 
            this.rtExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtExcept.Location = new System.Drawing.Point(93, 436);
            this.rtExcept.Name = "rtExcept";
            this.rtExcept.SelectControl = null;
            this.rtExcept.SelectControlIndex = 0;
            this.rtExcept.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtExcept.Size = new System.Drawing.Size(1324, 104);
            this.rtExcept.TabIndex = 20;
            this.rtExcept.Text = "";
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
            this.tsbQuite});
            this.stsManager.Location = new System.Drawing.Point(0, 0);
            this.stsManager.Name = "stsManager";
            this.stsManager.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.Size = new System.Drawing.Size(1432, 25);
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
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            // ToolCaseModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMainManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolCaseModify";
            this.Text = "修改用例";
            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolCaseModify_FormClosing);
            this.Load += new System.EventHandler(this.ToolCaseModify_Load);
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

        private System.Windows.Forms.TableLayoutPanel tlpMainManager;
        private System.Windows.Forms.TableLayoutPanel tlpMainEditor;
        private System.Windows.Forms.TableLayoutPanel tlpSort;
        private CCWin.SkinControl.SkinLabel labProject;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labReqNO;
        private CCWin.SkinControl.SkinTextBox tProject;
        private CCWin.SkinControl.SkinLabel labSuiteNO;
        private CCWin.SkinControl.SkinLabel labSuiteName;
        private CCWin.SkinControl.SkinLabel labCaseNO;
        private CCWin.SkinControl.SkinTextBox tSuiteNO;
        private CCWin.SkinControl.SkinTextBox tSuiteName;
        private CCWin.SkinControl.SkinTextBox tCaseNO;
        private System.Windows.Forms.Button btnAuthor;
        private CCWin.SkinControl.SkinLabel labCaseName;
        private CCWin.SkinControl.SkinTextBox tCaseName;
        private CCWin.SkinControl.SkinLabel labStruct;
        private CCWin.SkinControl.SkinLabel labCaseLevel;
        private CCWin.SkinControl.SkinComboBox cStruct;
        private CCWin.SkinControl.SkinComboBox cCaseLevel;
        private CCWin.SkinControl.SkinTextBox tReqNO;
        private CCWin.SkinControl.SkinTextBox tAuthor;
        private CCWin.SkinControl.SkinLabel labIfAuto;
        private CCWin.SkinControl.SkinComboBox cIfAuto;
        private CCWin.SkinControl.SkinLabel labEditDate;
        private CCWin.SkinControl.SkinLabel labModifyDate;
        private CCWin.SkinControl.SkinDateTimePicker dtpModifyDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labPrecondition;
        private CCWin.SkinControl.SkinLabel labSteps;
        private CCWin.SkinControl.SkinLabel labSamples;
        private CCWin.SkinControl.SkinLabel labExcept;
        private CCWin.SkinControl.SkinChatRichTextBox rtPrecondition;
        private CCWin.SkinControl.SkinChatRichTextBox rtSteps;
        private CCWin.SkinControl.SkinChatRichTextBox rtSamples;
        private CCWin.SkinControl.SkinChatRichTextBox rtExcept;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private CCWin.SkinControl.SkinLabel labModifier;
        private CCWin.SkinControl.SkinTextBox tModifier;
        private CCWin.SkinControl.SkinTextBox tEditDate;
    }
}