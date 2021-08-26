namespace TestExerciser.Tools.TaskManagement
{
    partial class ToolTaskNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolTaskNew));
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.cbProjectStruct = new CCWin.SkinControl.SkinComboBox();
            this.cbAssignTO = new CCWin.SkinControl.SkinComboBox();
            this.btnSelectCases = new System.Windows.Forms.Button();
            this.labTasktName = new CCWin.SkinControl.SkinLabel();
            this.labSelectCases = new CCWin.SkinControl.SkinLabel();
            this.labProjectVersion = new CCWin.SkinControl.SkinLabel();
            this.labTaskPriority = new CCWin.SkinControl.SkinLabel();
            this.tbTaskName = new CCWin.SkinControl.SkinTextBox();
            this.labProjectName = new CCWin.SkinControl.SkinLabel();
            this.labProjectStruct = new CCWin.SkinControl.SkinLabel();
            this.labAssignTo = new CCWin.SkinControl.SkinLabel();
            this.labSetUpTime = new CCWin.SkinControl.SkinLabel();
            this.labClosedTime = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labBuildTime = new CCWin.SkinControl.SkinLabel();
            this.tbAuthor = new CCWin.SkinControl.SkinTextBox();
            this.cbProjectVersion = new CCWin.SkinControl.SkinComboBox();
            this.cbTaskPriority = new CCWin.SkinControl.SkinComboBox();
            this.dtp_SetUpDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_ClosedDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_EditDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.tlpProject = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectProject = new System.Windows.Forms.Button();
            this.tbProjectName = new CCWin.SkinControl.SkinTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labDescribe = new CCWin.SkinControl.SkinLabel();
            this.rtDescribe = new CCWin.SkinControl.SkinChatRichTextBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbQuite = new System.Windows.Forms.ToolStripButton();
            this.tlpMainManager.SuspendLayout();
            this.tlpMainEditor.SuspendLayout();
            this.tlpSort.SuspendLayout();
            this.tlpProject.SuspendLayout();
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
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1426, 753);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 2;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSort.Controls.Add(this.cbProjectStruct, 1, 2);
            this.tlpSort.Controls.Add(this.cbAssignTO, 1, 6);
            this.tlpSort.Controls.Add(this.btnSelectCases, 1, 5);
            this.tlpSort.Controls.Add(this.labTasktName, 0, 0);
            this.tlpSort.Controls.Add(this.labSelectCases, 0, 5);
            this.tlpSort.Controls.Add(this.labProjectVersion, 0, 3);
            this.tlpSort.Controls.Add(this.labTaskPriority, 0, 4);
            this.tlpSort.Controls.Add(this.tbTaskName, 1, 0);
            this.tlpSort.Controls.Add(this.labProjectName, 0, 1);
            this.tlpSort.Controls.Add(this.labProjectStruct, 0, 2);
            this.tlpSort.Controls.Add(this.labAssignTo, 0, 6);
            this.tlpSort.Controls.Add(this.labSetUpTime, 0, 7);
            this.tlpSort.Controls.Add(this.labClosedTime, 0, 8);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 9);
            this.tlpSort.Controls.Add(this.labBuildTime, 0, 10);
            this.tlpSort.Controls.Add(this.tbAuthor, 1, 9);
            this.tlpSort.Controls.Add(this.cbProjectVersion, 1, 3);
            this.tlpSort.Controls.Add(this.cbTaskPriority, 1, 4);
            this.tlpSort.Controls.Add(this.dtp_SetUpDate, 1, 7);
            this.tlpSort.Controls.Add(this.dtp_ClosedDate, 1, 8);
            this.tlpSort.Controls.Add(this.dtp_EditDate, 1, 10);
            this.tlpSort.Controls.Add(this.tlpProject, 1, 1);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 3);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 11;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSort.Size = new System.Drawing.Size(1420, 379);
            this.tlpSort.TabIndex = 2;
            // 
            // cbProjectStruct
            // 
            this.cbProjectStruct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjectStruct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProjectStruct.FormattingEnabled = true;
            this.cbProjectStruct.ItemBorderColor = System.Drawing.Color.Transparent;
            this.cbProjectStruct.Items.AddRange(new object[] {
            "软件研发瀑布模型",
            "软件研发迭代模型"});
            this.cbProjectStruct.Location = new System.Drawing.Point(107, 74);
            this.cbProjectStruct.Name = "cbProjectStruct";
            this.cbProjectStruct.Size = new System.Drawing.Size(1310, 22);
            this.cbProjectStruct.TabIndex = 42;
            this.cbProjectStruct.WaterText = "必填...";
            // 
            // cbAssignTO
            // 
            this.cbAssignTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAssignTO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAssignTO.FormattingEnabled = true;
            this.cbAssignTO.ItemBorderColor = System.Drawing.Color.Transparent;
            this.cbAssignTO.Items.AddRange(new object[] {
            "软件研发瀑布模型",
            "软件研发迭代模型"});
            this.cbAssignTO.Location = new System.Drawing.Point(107, 210);
            this.cbAssignTO.Name = "cbAssignTO";
            this.cbAssignTO.Size = new System.Drawing.Size(1310, 22);
            this.cbAssignTO.TabIndex = 41;
            this.cbAssignTO.WaterText = "必填...";
            // 
            // btnSelectCases
            // 
            this.btnSelectCases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectCases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSelectCases.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCases.Image")));
            this.btnSelectCases.Location = new System.Drawing.Point(107, 176);
            this.btnSelectCases.Name = "btnSelectCases";
            this.btnSelectCases.Size = new System.Drawing.Size(24, 21);
            this.btnSelectCases.TabIndex = 40;
            this.btnSelectCases.UseVisualStyleBackColor = false;
            this.btnSelectCases.Click += new System.EventHandler(this.btnSelectCases_Click);
            // 
            // labTasktName
            // 
            this.labTasktName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTasktName.AutoSize = true;
            this.labTasktName.BackColor = System.Drawing.Color.White;
            this.labTasktName.BorderColor = System.Drawing.Color.White;
            this.labTasktName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTasktName.Location = new System.Drawing.Point(3, 8);
            this.labTasktName.Name = "labTasktName";
            this.labTasktName.Size = new System.Drawing.Size(68, 17);
            this.labTasktName.TabIndex = 1;
            this.labTasktName.Text = "任务名称：";
            // 
            // labSelectCases
            // 
            this.labSelectCases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSelectCases.AutoSize = true;
            this.labSelectCases.BackColor = System.Drawing.Color.White;
            this.labSelectCases.BorderColor = System.Drawing.Color.White;
            this.labSelectCases.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelectCases.Location = new System.Drawing.Point(3, 178);
            this.labSelectCases.Name = "labSelectCases";
            this.labSelectCases.Size = new System.Drawing.Size(68, 17);
            this.labSelectCases.TabIndex = 11;
            this.labSelectCases.Text = "选择用例：";
            // 
            // labProjectVersion
            // 
            this.labProjectVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectVersion.AutoSize = true;
            this.labProjectVersion.BackColor = System.Drawing.Color.White;
            this.labProjectVersion.BorderColor = System.Drawing.Color.White;
            this.labProjectVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectVersion.Location = new System.Drawing.Point(3, 110);
            this.labProjectVersion.Name = "labProjectVersion";
            this.labProjectVersion.Size = new System.Drawing.Size(68, 17);
            this.labProjectVersion.TabIndex = 7;
            this.labProjectVersion.Text = "产品版本：";
            // 
            // labTaskPriority
            // 
            this.labTaskPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTaskPriority.AutoSize = true;
            this.labTaskPriority.BackColor = System.Drawing.Color.White;
            this.labTaskPriority.BorderColor = System.Drawing.Color.White;
            this.labTaskPriority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTaskPriority.Location = new System.Drawing.Point(3, 144);
            this.labTaskPriority.Name = "labTaskPriority";
            this.labTaskPriority.Size = new System.Drawing.Size(56, 17);
            this.labTaskPriority.TabIndex = 9;
            this.labTaskPriority.Text = "优先级：";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTaskName.BackColor = System.Drawing.Color.Transparent;
            this.tbTaskName.DownBack = null;
            this.tbTaskName.Icon = null;
            this.tbTaskName.IconIsButton = false;
            this.tbTaskName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbTaskName.IsPasswordChat = '\0';
            this.tbTaskName.IsSystemPasswordChar = false;
            this.tbTaskName.Lines = new string[0];
            this.tbTaskName.Location = new System.Drawing.Point(104, 3);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.tbTaskName.MaxLength = 32767;
            this.tbTaskName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbTaskName.MouseBack = null;
            this.tbTaskName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbTaskName.Multiline = false;
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.NormlBack = null;
            this.tbTaskName.Padding = new System.Windows.Forms.Padding(5);
            this.tbTaskName.ReadOnly = false;
            this.tbTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTaskName.Size = new System.Drawing.Size(1316, 28);
            // 
            // 
            // 
            this.tbTaskName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTaskName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaskName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbTaskName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbTaskName.SkinTxt.Name = "BaseText";
            this.tbTaskName.SkinTxt.Size = new System.Drawing.Size(1306, 18);
            this.tbTaskName.SkinTxt.TabIndex = 0;
            this.tbTaskName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbTaskName.SkinTxt.WaterText = "必填...";
            this.tbTaskName.TabIndex = 1;
            this.tbTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTaskName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbTaskName.WaterText = "必填...";
            this.tbTaskName.WordWrap = true;
            // 
            // labProjectName
            // 
            this.labProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectName.AutoSize = true;
            this.labProjectName.BackColor = System.Drawing.Color.White;
            this.labProjectName.BorderColor = System.Drawing.Color.White;
            this.labProjectName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectName.Location = new System.Drawing.Point(3, 42);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(68, 17);
            this.labProjectName.TabIndex = 3;
            this.labProjectName.Text = "项目名称：";
            // 
            // labProjectStruct
            // 
            this.labProjectStruct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectStruct.AutoSize = true;
            this.labProjectStruct.BackColor = System.Drawing.Color.White;
            this.labProjectStruct.BorderColor = System.Drawing.Color.White;
            this.labProjectStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectStruct.Location = new System.Drawing.Point(3, 76);
            this.labProjectStruct.Name = "labProjectStruct";
            this.labProjectStruct.Size = new System.Drawing.Size(68, 17);
            this.labProjectStruct.TabIndex = 5;
            this.labProjectStruct.Text = "产品架构：";
            // 
            // labAssignTo
            // 
            this.labAssignTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAssignTo.AutoSize = true;
            this.labAssignTo.BackColor = System.Drawing.Color.White;
            this.labAssignTo.BorderColor = System.Drawing.Color.White;
            this.labAssignTo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAssignTo.Location = new System.Drawing.Point(3, 212);
            this.labAssignTo.Name = "labAssignTo";
            this.labAssignTo.Size = new System.Drawing.Size(56, 17);
            this.labAssignTo.TabIndex = 13;
            this.labAssignTo.Text = "分派给：";
            // 
            // labSetUpTime
            // 
            this.labSetUpTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSetUpTime.AutoSize = true;
            this.labSetUpTime.BackColor = System.Drawing.Color.White;
            this.labSetUpTime.BorderColor = System.Drawing.Color.White;
            this.labSetUpTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSetUpTime.Location = new System.Drawing.Point(3, 246);
            this.labSetUpTime.Name = "labSetUpTime";
            this.labSetUpTime.Size = new System.Drawing.Size(92, 17);
            this.labSetUpTime.TabIndex = 15;
            this.labSetUpTime.Text = "计划启动日期：";
            // 
            // labClosedTime
            // 
            this.labClosedTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labClosedTime.AutoSize = true;
            this.labClosedTime.BackColor = System.Drawing.Color.White;
            this.labClosedTime.BorderColor = System.Drawing.Color.White;
            this.labClosedTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClosedTime.Location = new System.Drawing.Point(3, 280);
            this.labClosedTime.Name = "labClosedTime";
            this.labClosedTime.Size = new System.Drawing.Size(92, 17);
            this.labClosedTime.TabIndex = 17;
            this.labClosedTime.Text = "计划关闭日期：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.White;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 314);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(56, 17);
            this.labAuthor.TabIndex = 20;
            this.labAuthor.Text = "创建人：";
            // 
            // labBuildTime
            // 
            this.labBuildTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labBuildTime.AutoSize = true;
            this.labBuildTime.BackColor = System.Drawing.Color.White;
            this.labBuildTime.BorderColor = System.Drawing.Color.White;
            this.labBuildTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBuildTime.Location = new System.Drawing.Point(3, 351);
            this.labBuildTime.Name = "labBuildTime";
            this.labBuildTime.Size = new System.Drawing.Size(68, 17);
            this.labBuildTime.TabIndex = 21;
            this.labBuildTime.Text = "创建时间：";
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
            this.tbAuthor.Location = new System.Drawing.Point(104, 309);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.tbAuthor.MaxLength = 32767;
            this.tbAuthor.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbAuthor.MouseBack = null;
            this.tbAuthor.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbAuthor.Multiline = false;
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.NormlBack = null;
            this.tbAuthor.Padding = new System.Windows.Forms.Padding(5);
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAuthor.Size = new System.Drawing.Size(1316, 28);
            // 
            // 
            // 
            this.tbAuthor.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthor.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuthor.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbAuthor.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbAuthor.SkinTxt.Name = "BaseText";
            this.tbAuthor.SkinTxt.ReadOnly = true;
            this.tbAuthor.SkinTxt.Size = new System.Drawing.Size(1306, 18);
            this.tbAuthor.SkinTxt.TabIndex = 0;
            this.tbAuthor.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbAuthor.SkinTxt.WaterText = "必填...";
            this.tbAuthor.TabIndex = 30;
            this.tbAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAuthor.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbAuthor.WaterText = "必填...";
            this.tbAuthor.WordWrap = true;
            // 
            // cbProjectVersion
            // 
            this.cbProjectVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjectVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProjectVersion.FormattingEnabled = true;
            this.cbProjectVersion.ItemBorderColor = System.Drawing.Color.Transparent;
            this.cbProjectVersion.Items.AddRange(new object[] {
            "软件研发瀑布模型",
            "软件研发迭代模型"});
            this.cbProjectVersion.Location = new System.Drawing.Point(107, 108);
            this.cbProjectVersion.Name = "cbProjectVersion";
            this.cbProjectVersion.Size = new System.Drawing.Size(1310, 22);
            this.cbProjectVersion.TabIndex = 34;
            this.cbProjectVersion.WaterText = "必填...";
            // 
            // cbTaskPriority
            // 
            this.cbTaskPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaskPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTaskPriority.FormattingEnabled = true;
            this.cbTaskPriority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.cbTaskPriority.Location = new System.Drawing.Point(107, 142);
            this.cbTaskPriority.Name = "cbTaskPriority";
            this.cbTaskPriority.Size = new System.Drawing.Size(1310, 22);
            this.cbTaskPriority.TabIndex = 35;
            this.cbTaskPriority.WaterText = "必填...";
            // 
            // dtp_SetUpDate
            // 
            this.dtp_SetUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_SetUpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_SetUpDate.DropDownHeight = 180;
            this.dtp_SetUpDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_SetUpDate.DropDownWidth = 120;
            this.dtp_SetUpDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_SetUpDate.Items = null;
            this.dtp_SetUpDate.Location = new System.Drawing.Point(107, 244);
            this.dtp_SetUpDate.Name = "dtp_SetUpDate";
            this.dtp_SetUpDate.Size = new System.Drawing.Size(1310, 21);
            this.dtp_SetUpDate.TabIndex = 36;
            this.dtp_SetUpDate.text = "";
            // 
            // dtp_ClosedDate
            // 
            this.dtp_ClosedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ClosedDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ClosedDate.DropDownHeight = 180;
            this.dtp_ClosedDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_ClosedDate.DropDownWidth = 120;
            this.dtp_ClosedDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_ClosedDate.Items = null;
            this.dtp_ClosedDate.Location = new System.Drawing.Point(107, 278);
            this.dtp_ClosedDate.Name = "dtp_ClosedDate";
            this.dtp_ClosedDate.Size = new System.Drawing.Size(1310, 21);
            this.dtp_ClosedDate.TabIndex = 37;
            this.dtp_ClosedDate.text = "";
            // 
            // dtp_EditDate
            // 
            this.dtp_EditDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_EditDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_EditDate.DropDownHeight = 180;
            this.dtp_EditDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_EditDate.DropDownWidth = 120;
            this.dtp_EditDate.Enabled = false;
            this.dtp_EditDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_EditDate.Items = null;
            this.dtp_EditDate.Location = new System.Drawing.Point(107, 348);
            this.dtp_EditDate.Name = "dtp_EditDate";
            this.dtp_EditDate.Size = new System.Drawing.Size(1310, 23);
            this.dtp_EditDate.TabIndex = 38;
            this.dtp_EditDate.text = "";
            // 
            // tlpProject
            // 
            this.tlpProject.ColumnCount = 2;
            this.tlpProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProject.Controls.Add(this.btnSelectProject, 1, 0);
            this.tlpProject.Controls.Add(this.tbProjectName, 0, 0);
            this.tlpProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProject.Location = new System.Drawing.Point(107, 37);
            this.tlpProject.Name = "tlpProject";
            this.tlpProject.RowCount = 1;
            this.tlpProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpProject.Size = new System.Drawing.Size(1310, 28);
            this.tlpProject.TabIndex = 39;
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnSelectProject.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectProject.Image")));
            this.btnSelectProject.Location = new System.Drawing.Point(1283, 3);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(24, 21);
            this.btnSelectProject.TabIndex = 29;
            this.btnSelectProject.UseVisualStyleBackColor = false;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectName.BackColor = System.Drawing.Color.Transparent;
            this.tbProjectName.DownBack = null;
            this.tbProjectName.Icon = null;
            this.tbProjectName.IconIsButton = false;
            this.tbProjectName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbProjectName.IsPasswordChat = '\0';
            this.tbProjectName.IsSystemPasswordChar = false;
            this.tbProjectName.Lines = new string[0];
            this.tbProjectName.Location = new System.Drawing.Point(0, 0);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.tbProjectName.MaxLength = 32767;
            this.tbProjectName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbProjectName.MouseBack = null;
            this.tbProjectName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbProjectName.Multiline = false;
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.NormlBack = null;
            this.tbProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.tbProjectName.ReadOnly = false;
            this.tbProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProjectName.Size = new System.Drawing.Size(1280, 28);
            // 
            // 
            // 
            this.tbProjectName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProjectName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbProjectName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbProjectName.SkinTxt.Name = "BaseText";
            this.tbProjectName.SkinTxt.Size = new System.Drawing.Size(1270, 18);
            this.tbProjectName.SkinTxt.TabIndex = 0;
            this.tbProjectName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbProjectName.SkinTxt.WaterText = "";
            this.tbProjectName.TabIndex = 0;
            this.tbProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbProjectName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbProjectName.WaterText = "";
            this.tbProjectName.WordWrap = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labDescribe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtDescribe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1420, 362);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labDescribe
            // 
            this.labDescribe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDescribe.AutoSize = true;
            this.labDescribe.BackColor = System.Drawing.Color.White;
            this.labDescribe.BorderColor = System.Drawing.Color.White;
            this.labDescribe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDescribe.Location = new System.Drawing.Point(3, 172);
            this.labDescribe.Name = "labDescribe";
            this.labDescribe.Size = new System.Drawing.Size(44, 17);
            this.labDescribe.TabIndex = 24;
            this.labDescribe.Text = "描述：";
            // 
            // rtDescribe
            // 
            this.rtDescribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtDescribe.Location = new System.Drawing.Point(107, 3);
            this.rtDescribe.Name = "rtDescribe";
            this.rtDescribe.SelectControl = null;
            this.rtDescribe.SelectControlIndex = 0;
            this.rtDescribe.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtDescribe.Size = new System.Drawing.Size(1310, 356);
            this.rtDescribe.TabIndex = 25;
            this.rtDescribe.Text = "";
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
            this.tsbSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbQuite
            // 
            this.tsbQuite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuite.Name = "tsbQuite";
            this.tsbQuite.Size = new System.Drawing.Size(36, 22);
            this.tsbQuite.Text = "取消";
            this.tsbQuite.Click += new System.EventHandler(this.tsbQuite_Click);
            // 
            // ToolTaskNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMainManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolTaskNew";
            this.Text = "新建任务";
            
            this.Load += new System.EventHandler(this.ToolTaskNew_Load);
            this.tlpMainManager.ResumeLayout(false);
            this.tlpMainManager.PerformLayout();
            this.tlpMainEditor.ResumeLayout(false);
            this.tlpSort.ResumeLayout(false);
            this.tlpSort.PerformLayout();
            this.tlpProject.ResumeLayout(false);
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
        private CCWin.SkinControl.SkinLabel labTasktName;
        private CCWin.SkinControl.SkinLabel labSelectCases;
        private CCWin.SkinControl.SkinLabel labProjectVersion;
        private CCWin.SkinControl.SkinLabel labTaskPriority;
        private CCWin.SkinControl.SkinTextBox tbTaskName;
        private CCWin.SkinControl.SkinLabel labProjectName;
        private CCWin.SkinControl.SkinLabel labProjectStruct;
        private CCWin.SkinControl.SkinLabel labAssignTo;
        private CCWin.SkinControl.SkinLabel labSetUpTime;
        private CCWin.SkinControl.SkinLabel labClosedTime;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labBuildTime;
        private CCWin.SkinControl.SkinTextBox tbAuthor;
        private CCWin.SkinControl.SkinComboBox cbProjectVersion;
        private CCWin.SkinControl.SkinComboBox cbTaskPriority;
        private CCWin.SkinControl.SkinDateTimePicker dtp_SetUpDate;
        private CCWin.SkinControl.SkinDateTimePicker dtp_ClosedDate;
        private CCWin.SkinControl.SkinDateTimePicker dtp_EditDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labDescribe;
        private CCWin.SkinControl.SkinChatRichTextBox rtDescribe;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private System.Windows.Forms.TableLayoutPanel tlpProject;
        private CCWin.SkinControl.SkinTextBox tbProjectName;
        private System.Windows.Forms.Button btnSelectProject;
        private CCWin.SkinControl.SkinComboBox cbAssignTO;
        private System.Windows.Forms.Button btnSelectCases;
        private CCWin.SkinControl.SkinComboBox cbProjectStruct;
    }
}