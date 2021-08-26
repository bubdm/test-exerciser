namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectModify));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.labProjectName = new CCWin.SkinControl.SkinLabel();
            this.labDepartment = new CCWin.SkinControl.SkinLabel();
            this.labType = new CCWin.SkinControl.SkinLabel();
            this.labPriority = new CCWin.SkinControl.SkinLabel();
            this.tProjectName = new CCWin.SkinControl.SkinTextBox();
            this.labShortName = new CCWin.SkinControl.SkinLabel();
            this.labProjectNO = new CCWin.SkinControl.SkinLabel();
            this.tShortName = new CCWin.SkinControl.SkinTextBox();
            this.tProjectNO = new CCWin.SkinControl.SkinTextBox();
            this.tDepartment = new CCWin.SkinControl.SkinTextBox();
            this.labManager = new CCWin.SkinControl.SkinLabel();
            this.labAssistant = new CCWin.SkinControl.SkinLabel();
            this.labSetUpTime = new CCWin.SkinControl.SkinLabel();
            this.labClosedTime = new CCWin.SkinControl.SkinLabel();
            this.labCustomer = new CCWin.SkinControl.SkinLabel();
            this.labDevelopmentSite = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labBuildTime = new CCWin.SkinControl.SkinLabel();
            this.labModifier = new CCWin.SkinControl.SkinLabel();
            this.labModifyTime = new CCWin.SkinControl.SkinLabel();
            this.tAssistant = new CCWin.SkinControl.SkinTextBox();
            this.tCustomer = new CCWin.SkinControl.SkinTextBox();
            this.tDevelopmentSite = new CCWin.SkinControl.SkinTextBox();
            this.tAuthor = new CCWin.SkinControl.SkinTextBox();
            this.tModifier = new CCWin.SkinControl.SkinTextBox();
            this.cType = new CCWin.SkinControl.SkinComboBox();
            this.cPriority = new CCWin.SkinControl.SkinComboBox();
            this.dtp_SetUpDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_ClosedDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_BuildDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_ModifyDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.cbManager = new CCWin.SkinControl.SkinComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labDescribe = new CCWin.SkinControl.SkinLabel();
            this.rtDescribe = new CCWin.SkinControl.SkinChatRichTextBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
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
            this.tlpMainManager.TabIndex = 1;
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
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 487F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1420, 747);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 2;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSort.Controls.Add(this.labProjectName, 0, 0);
            this.tlpSort.Controls.Add(this.labDepartment, 0, 5);
            this.tlpSort.Controls.Add(this.labType, 0, 3);
            this.tlpSort.Controls.Add(this.labPriority, 0, 4);
            this.tlpSort.Controls.Add(this.tProjectName, 1, 0);
            this.tlpSort.Controls.Add(this.labShortName, 0, 1);
            this.tlpSort.Controls.Add(this.labProjectNO, 0, 2);
            this.tlpSort.Controls.Add(this.tShortName, 1, 1);
            this.tlpSort.Controls.Add(this.tProjectNO, 1, 2);
            this.tlpSort.Controls.Add(this.tDepartment, 1, 5);
            this.tlpSort.Controls.Add(this.labManager, 0, 6);
            this.tlpSort.Controls.Add(this.labAssistant, 0, 7);
            this.tlpSort.Controls.Add(this.labSetUpTime, 0, 8);
            this.tlpSort.Controls.Add(this.labClosedTime, 0, 9);
            this.tlpSort.Controls.Add(this.labCustomer, 0, 10);
            this.tlpSort.Controls.Add(this.labDevelopmentSite, 0, 11);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 12);
            this.tlpSort.Controls.Add(this.labBuildTime, 0, 13);
            this.tlpSort.Controls.Add(this.labModifier, 0, 14);
            this.tlpSort.Controls.Add(this.labModifyTime, 0, 15);
            this.tlpSort.Controls.Add(this.tAssistant, 1, 7);
            this.tlpSort.Controls.Add(this.tCustomer, 1, 10);
            this.tlpSort.Controls.Add(this.tDevelopmentSite, 1, 11);
            this.tlpSort.Controls.Add(this.tAuthor, 1, 12);
            this.tlpSort.Controls.Add(this.tModifier, 1, 14);
            this.tlpSort.Controls.Add(this.cType, 1, 3);
            this.tlpSort.Controls.Add(this.cPriority, 1, 4);
            this.tlpSort.Controls.Add(this.dtp_SetUpDate, 1, 8);
            this.tlpSort.Controls.Add(this.dtp_ClosedDate, 1, 9);
            this.tlpSort.Controls.Add(this.dtp_BuildDate, 1, 13);
            this.tlpSort.Controls.Add(this.dtp_ModifyDate, 1, 15);
            this.tlpSort.Controls.Add(this.cbManager, 1, 6);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 3);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 16;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.652807F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.029106F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSort.Size = new System.Drawing.Size(1414, 481);
            this.tlpSort.TabIndex = 2;
            // 
            // labProjectName
            // 
            this.labProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectName.AutoSize = true;
            this.labProjectName.BackColor = System.Drawing.Color.White;
            this.labProjectName.BorderColor = System.Drawing.Color.White;
            this.labProjectName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectName.Location = new System.Drawing.Point(3, 6);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(68, 17);
            this.labProjectName.TabIndex = 1;
            this.labProjectName.Text = "项目名称：";
            // 
            // labDepartment
            // 
            this.labDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDepartment.AutoSize = true;
            this.labDepartment.BackColor = System.Drawing.Color.White;
            this.labDepartment.BorderColor = System.Drawing.Color.White;
            this.labDepartment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDepartment.Location = new System.Drawing.Point(3, 156);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(68, 17);
            this.labDepartment.TabIndex = 11;
            this.labDepartment.Text = "所属部门：";
            // 
            // labType
            // 
            this.labType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labType.AutoSize = true;
            this.labType.BackColor = System.Drawing.Color.White;
            this.labType.BorderColor = System.Drawing.Color.White;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(3, 96);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(68, 17);
            this.labType.TabIndex = 7;
            this.labType.Text = "项目类型：";
            // 
            // labPriority
            // 
            this.labPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPriority.AutoSize = true;
            this.labPriority.BackColor = System.Drawing.Color.White;
            this.labPriority.BorderColor = System.Drawing.Color.White;
            this.labPriority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPriority.Location = new System.Drawing.Point(3, 126);
            this.labPriority.Name = "labPriority";
            this.labPriority.Size = new System.Drawing.Size(56, 17);
            this.labPriority.TabIndex = 9;
            this.labPriority.Text = "优先级：";
            // 
            // tProjectName
            // 
            this.tProjectName.BackColor = System.Drawing.Color.Transparent;
            this.tProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tProjectName.DownBack = null;
            this.tProjectName.Icon = null;
            this.tProjectName.IconIsButton = false;
            this.tProjectName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProjectName.IsPasswordChat = '\0';
            this.tProjectName.IsSystemPasswordChar = false;
            this.tProjectName.Lines = new string[0];
            this.tProjectName.Location = new System.Drawing.Point(104, 0);
            this.tProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.tProjectName.MaxLength = 32767;
            this.tProjectName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tProjectName.MouseBack = null;
            this.tProjectName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProjectName.Multiline = true;
            this.tProjectName.Name = "tProjectName";
            this.tProjectName.NormlBack = null;
            this.tProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.tProjectName.ReadOnly = false;
            this.tProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tProjectName.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tProjectName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tProjectName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tProjectName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tProjectName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tProjectName.SkinTxt.Multiline = true;
            this.tProjectName.SkinTxt.Name = "BaseText";
            this.tProjectName.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tProjectName.SkinTxt.TabIndex = 0;
            this.tProjectName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProjectName.SkinTxt.WaterText = "必填...";
            this.tProjectName.TabIndex = 1;
            this.tProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tProjectName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProjectName.WaterText = "必填...";
            this.tProjectName.WordWrap = true;
            // 
            // labShortName
            // 
            this.labShortName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labShortName.AutoSize = true;
            this.labShortName.BackColor = System.Drawing.Color.White;
            this.labShortName.BorderColor = System.Drawing.Color.White;
            this.labShortName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labShortName.Location = new System.Drawing.Point(3, 36);
            this.labShortName.Name = "labShortName";
            this.labShortName.Size = new System.Drawing.Size(68, 17);
            this.labShortName.TabIndex = 3;
            this.labShortName.Text = "项目简称：";
            // 
            // labProjectNO
            // 
            this.labProjectNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectNO.AutoSize = true;
            this.labProjectNO.BackColor = System.Drawing.Color.White;
            this.labProjectNO.BorderColor = System.Drawing.Color.White;
            this.labProjectNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectNO.Location = new System.Drawing.Point(3, 66);
            this.labProjectNO.Name = "labProjectNO";
            this.labProjectNO.Size = new System.Drawing.Size(68, 17);
            this.labProjectNO.TabIndex = 5;
            this.labProjectNO.Text = "项目编号：";
            // 
            // tShortName
            // 
            this.tShortName.BackColor = System.Drawing.Color.Transparent;
            this.tShortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tShortName.DownBack = null;
            this.tShortName.Icon = null;
            this.tShortName.IconIsButton = false;
            this.tShortName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tShortName.IsPasswordChat = '\0';
            this.tShortName.IsSystemPasswordChar = false;
            this.tShortName.Lines = new string[0];
            this.tShortName.Location = new System.Drawing.Point(104, 30);
            this.tShortName.Margin = new System.Windows.Forms.Padding(0);
            this.tShortName.MaxLength = 32767;
            this.tShortName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tShortName.MouseBack = null;
            this.tShortName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tShortName.Multiline = true;
            this.tShortName.Name = "tShortName";
            this.tShortName.NormlBack = null;
            this.tShortName.Padding = new System.Windows.Forms.Padding(5);
            this.tShortName.ReadOnly = false;
            this.tShortName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tShortName.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tShortName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tShortName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tShortName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tShortName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tShortName.SkinTxt.Multiline = true;
            this.tShortName.SkinTxt.Name = "BaseText";
            this.tShortName.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tShortName.SkinTxt.TabIndex = 0;
            this.tShortName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tShortName.SkinTxt.WaterText = "可填...";
            this.tShortName.TabIndex = 3;
            this.tShortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tShortName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tShortName.WaterText = "可填...";
            this.tShortName.WordWrap = true;
            // 
            // tProjectNO
            // 
            this.tProjectNO.BackColor = System.Drawing.Color.Transparent;
            this.tProjectNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tProjectNO.DownBack = null;
            this.tProjectNO.Icon = null;
            this.tProjectNO.IconIsButton = false;
            this.tProjectNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProjectNO.IsPasswordChat = '\0';
            this.tProjectNO.IsSystemPasswordChar = false;
            this.tProjectNO.Lines = new string[0];
            this.tProjectNO.Location = new System.Drawing.Point(104, 60);
            this.tProjectNO.Margin = new System.Windows.Forms.Padding(0);
            this.tProjectNO.MaxLength = 32767;
            this.tProjectNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tProjectNO.MouseBack = null;
            this.tProjectNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tProjectNO.Multiline = true;
            this.tProjectNO.Name = "tProjectNO";
            this.tProjectNO.NormlBack = null;
            this.tProjectNO.Padding = new System.Windows.Forms.Padding(5);
            this.tProjectNO.ReadOnly = false;
            this.tProjectNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tProjectNO.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tProjectNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tProjectNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tProjectNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tProjectNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tProjectNO.SkinTxt.Multiline = true;
            this.tProjectNO.SkinTxt.Name = "BaseText";
            this.tProjectNO.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tProjectNO.SkinTxt.TabIndex = 0;
            this.tProjectNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProjectNO.SkinTxt.WaterText = "必填...";
            this.tProjectNO.TabIndex = 5;
            this.tProjectNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tProjectNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tProjectNO.WaterText = "必填...";
            this.tProjectNO.WordWrap = true;
            // 
            // tDepartment
            // 
            this.tDepartment.BackColor = System.Drawing.Color.Transparent;
            this.tDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDepartment.DownBack = null;
            this.tDepartment.Icon = null;
            this.tDepartment.IconIsButton = false;
            this.tDepartment.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tDepartment.IsPasswordChat = '\0';
            this.tDepartment.IsSystemPasswordChar = false;
            this.tDepartment.Lines = new string[0];
            this.tDepartment.Location = new System.Drawing.Point(104, 150);
            this.tDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.tDepartment.MaxLength = 32767;
            this.tDepartment.MinimumSize = new System.Drawing.Size(28, 28);
            this.tDepartment.MouseBack = null;
            this.tDepartment.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tDepartment.Multiline = true;
            this.tDepartment.Name = "tDepartment";
            this.tDepartment.NormlBack = null;
            this.tDepartment.Padding = new System.Windows.Forms.Padding(5);
            this.tDepartment.ReadOnly = false;
            this.tDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tDepartment.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tDepartment.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDepartment.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDepartment.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tDepartment.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tDepartment.SkinTxt.Multiline = true;
            this.tDepartment.SkinTxt.Name = "BaseText";
            this.tDepartment.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tDepartment.SkinTxt.TabIndex = 0;
            this.tDepartment.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tDepartment.SkinTxt.WaterText = "必填...";
            this.tDepartment.TabIndex = 11;
            this.tDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tDepartment.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tDepartment.WaterText = "必填...";
            this.tDepartment.WordWrap = true;
            // 
            // labManager
            // 
            this.labManager.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labManager.AutoSize = true;
            this.labManager.BackColor = System.Drawing.Color.White;
            this.labManager.BorderColor = System.Drawing.Color.White;
            this.labManager.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labManager.Location = new System.Drawing.Point(3, 186);
            this.labManager.Name = "labManager";
            this.labManager.Size = new System.Drawing.Size(68, 17);
            this.labManager.TabIndex = 13;
            this.labManager.Text = "项目经理：";
            // 
            // labAssistant
            // 
            this.labAssistant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAssistant.AutoSize = true;
            this.labAssistant.BackColor = System.Drawing.Color.White;
            this.labAssistant.BorderColor = System.Drawing.Color.White;
            this.labAssistant.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAssistant.Location = new System.Drawing.Point(3, 216);
            this.labAssistant.Name = "labAssistant";
            this.labAssistant.Size = new System.Drawing.Size(68, 17);
            this.labAssistant.TabIndex = 14;
            this.labAssistant.Text = "项目助理：";
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
            this.labClosedTime.Location = new System.Drawing.Point(3, 276);
            this.labClosedTime.Name = "labClosedTime";
            this.labClosedTime.Size = new System.Drawing.Size(92, 17);
            this.labClosedTime.TabIndex = 17;
            this.labClosedTime.Text = "计划关闭日期：";
            // 
            // labCustomer
            // 
            this.labCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCustomer.AutoSize = true;
            this.labCustomer.BackColor = System.Drawing.Color.White;
            this.labCustomer.BorderColor = System.Drawing.Color.White;
            this.labCustomer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCustomer.Location = new System.Drawing.Point(3, 306);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(68, 17);
            this.labCustomer.TabIndex = 18;
            this.labCustomer.Text = "客户名称：";
            // 
            // labDevelopmentSite
            // 
            this.labDevelopmentSite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDevelopmentSite.AutoSize = true;
            this.labDevelopmentSite.BackColor = System.Drawing.Color.White;
            this.labDevelopmentSite.BorderColor = System.Drawing.Color.White;
            this.labDevelopmentSite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDevelopmentSite.Location = new System.Drawing.Point(3, 336);
            this.labDevelopmentSite.Name = "labDevelopmentSite";
            this.labDevelopmentSite.Size = new System.Drawing.Size(68, 17);
            this.labDevelopmentSite.TabIndex = 19;
            this.labDevelopmentSite.Text = "开发地点：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.White;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 366);
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
            this.labBuildTime.Location = new System.Drawing.Point(3, 396);
            this.labBuildTime.Name = "labBuildTime";
            this.labBuildTime.Size = new System.Drawing.Size(68, 17);
            this.labBuildTime.TabIndex = 21;
            this.labBuildTime.Text = "创建时间：";
            // 
            // labModifier
            // 
            this.labModifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifier.AutoSize = true;
            this.labModifier.BackColor = System.Drawing.Color.White;
            this.labModifier.BorderColor = System.Drawing.Color.White;
            this.labModifier.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifier.Location = new System.Drawing.Point(3, 427);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(56, 17);
            this.labModifier.TabIndex = 22;
            this.labModifier.Text = "修改人：";
            // 
            // labModifyTime
            // 
            this.labModifyTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifyTime.AutoSize = true;
            this.labModifyTime.BackColor = System.Drawing.Color.White;
            this.labModifyTime.BorderColor = System.Drawing.Color.White;
            this.labModifyTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifyTime.Location = new System.Drawing.Point(3, 457);
            this.labModifyTime.Name = "labModifyTime";
            this.labModifyTime.Size = new System.Drawing.Size(68, 17);
            this.labModifyTime.TabIndex = 23;
            this.labModifyTime.Text = "修改时间：";
            // 
            // tAssistant
            // 
            this.tAssistant.BackColor = System.Drawing.Color.Transparent;
            this.tAssistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAssistant.DownBack = null;
            this.tAssistant.Icon = null;
            this.tAssistant.IconIsButton = false;
            this.tAssistant.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAssistant.IsPasswordChat = '\0';
            this.tAssistant.IsSystemPasswordChar = false;
            this.tAssistant.Lines = new string[0];
            this.tAssistant.Location = new System.Drawing.Point(104, 210);
            this.tAssistant.Margin = new System.Windows.Forms.Padding(0);
            this.tAssistant.MaxLength = 32767;
            this.tAssistant.MinimumSize = new System.Drawing.Size(28, 28);
            this.tAssistant.MouseBack = null;
            this.tAssistant.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAssistant.Multiline = true;
            this.tAssistant.Name = "tAssistant";
            this.tAssistant.NormlBack = null;
            this.tAssistant.Padding = new System.Windows.Forms.Padding(5);
            this.tAssistant.ReadOnly = false;
            this.tAssistant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tAssistant.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tAssistant.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tAssistant.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAssistant.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tAssistant.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tAssistant.SkinTxt.Multiline = true;
            this.tAssistant.SkinTxt.Name = "BaseText";
            this.tAssistant.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tAssistant.SkinTxt.TabIndex = 0;
            this.tAssistant.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAssistant.SkinTxt.WaterText = "可填...";
            this.tAssistant.TabIndex = 25;
            this.tAssistant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAssistant.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAssistant.WaterText = "可填...";
            this.tAssistant.WordWrap = true;
            // 
            // tCustomer
            // 
            this.tCustomer.BackColor = System.Drawing.Color.Transparent;
            this.tCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCustomer.DownBack = null;
            this.tCustomer.Icon = null;
            this.tCustomer.IconIsButton = false;
            this.tCustomer.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCustomer.IsPasswordChat = '\0';
            this.tCustomer.IsSystemPasswordChar = false;
            this.tCustomer.Lines = new string[0];
            this.tCustomer.Location = new System.Drawing.Point(104, 300);
            this.tCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.tCustomer.MaxLength = 32767;
            this.tCustomer.MinimumSize = new System.Drawing.Size(28, 28);
            this.tCustomer.MouseBack = null;
            this.tCustomer.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tCustomer.Multiline = true;
            this.tCustomer.Name = "tCustomer";
            this.tCustomer.NormlBack = null;
            this.tCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.tCustomer.ReadOnly = false;
            this.tCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCustomer.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tCustomer.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCustomer.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCustomer.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tCustomer.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tCustomer.SkinTxt.Multiline = true;
            this.tCustomer.SkinTxt.Name = "BaseText";
            this.tCustomer.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tCustomer.SkinTxt.TabIndex = 0;
            this.tCustomer.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCustomer.SkinTxt.WaterText = "可填...";
            this.tCustomer.TabIndex = 28;
            this.tCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tCustomer.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tCustomer.WaterText = "可填...";
            this.tCustomer.WordWrap = true;
            // 
            // tDevelopmentSite
            // 
            this.tDevelopmentSite.BackColor = System.Drawing.Color.Transparent;
            this.tDevelopmentSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDevelopmentSite.DownBack = null;
            this.tDevelopmentSite.Icon = null;
            this.tDevelopmentSite.IconIsButton = false;
            this.tDevelopmentSite.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tDevelopmentSite.IsPasswordChat = '\0';
            this.tDevelopmentSite.IsSystemPasswordChar = false;
            this.tDevelopmentSite.Lines = new string[0];
            this.tDevelopmentSite.Location = new System.Drawing.Point(104, 330);
            this.tDevelopmentSite.Margin = new System.Windows.Forms.Padding(0);
            this.tDevelopmentSite.MaxLength = 32767;
            this.tDevelopmentSite.MinimumSize = new System.Drawing.Size(28, 28);
            this.tDevelopmentSite.MouseBack = null;
            this.tDevelopmentSite.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tDevelopmentSite.Multiline = true;
            this.tDevelopmentSite.Name = "tDevelopmentSite";
            this.tDevelopmentSite.NormlBack = null;
            this.tDevelopmentSite.Padding = new System.Windows.Forms.Padding(5);
            this.tDevelopmentSite.ReadOnly = false;
            this.tDevelopmentSite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tDevelopmentSite.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tDevelopmentSite.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDevelopmentSite.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDevelopmentSite.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tDevelopmentSite.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tDevelopmentSite.SkinTxt.Multiline = true;
            this.tDevelopmentSite.SkinTxt.Name = "BaseText";
            this.tDevelopmentSite.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tDevelopmentSite.SkinTxt.TabIndex = 0;
            this.tDevelopmentSite.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tDevelopmentSite.SkinTxt.WaterText = "可填...";
            this.tDevelopmentSite.TabIndex = 29;
            this.tDevelopmentSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tDevelopmentSite.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tDevelopmentSite.WaterText = "可填...";
            this.tDevelopmentSite.WordWrap = true;
            // 
            // tAuthor
            // 
            this.tAuthor.BackColor = System.Drawing.Color.Transparent;
            this.tAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAuthor.DownBack = null;
            this.tAuthor.Enabled = false;
            this.tAuthor.Icon = null;
            this.tAuthor.IconIsButton = false;
            this.tAuthor.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAuthor.IsPasswordChat = '\0';
            this.tAuthor.IsSystemPasswordChar = false;
            this.tAuthor.Lines = new string[0];
            this.tAuthor.Location = new System.Drawing.Point(104, 360);
            this.tAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.tAuthor.MaxLength = 32767;
            this.tAuthor.MinimumSize = new System.Drawing.Size(28, 28);
            this.tAuthor.MouseBack = null;
            this.tAuthor.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tAuthor.Multiline = true;
            this.tAuthor.Name = "tAuthor";
            this.tAuthor.NormlBack = null;
            this.tAuthor.Padding = new System.Windows.Forms.Padding(5);
            this.tAuthor.ReadOnly = false;
            this.tAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tAuthor.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tAuthor.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tAuthor.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAuthor.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tAuthor.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tAuthor.SkinTxt.Multiline = true;
            this.tAuthor.SkinTxt.Name = "BaseText";
            this.tAuthor.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tAuthor.SkinTxt.TabIndex = 0;
            this.tAuthor.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAuthor.SkinTxt.WaterText = "必填...";
            this.tAuthor.TabIndex = 30;
            this.tAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tAuthor.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tAuthor.WaterText = "必填...";
            this.tAuthor.WordWrap = true;
            // 
            // tModifier
            // 
            this.tModifier.BackColor = System.Drawing.Color.Transparent;
            this.tModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tModifier.DownBack = null;
            this.tModifier.Enabled = false;
            this.tModifier.Icon = null;
            this.tModifier.IconIsButton = false;
            this.tModifier.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tModifier.IsPasswordChat = '\0';
            this.tModifier.IsSystemPasswordChar = false;
            this.tModifier.Lines = new string[0];
            this.tModifier.Location = new System.Drawing.Point(104, 420);
            this.tModifier.Margin = new System.Windows.Forms.Padding(0);
            this.tModifier.MaxLength = 32767;
            this.tModifier.MinimumSize = new System.Drawing.Size(28, 28);
            this.tModifier.MouseBack = null;
            this.tModifier.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tModifier.Multiline = true;
            this.tModifier.Name = "tModifier";
            this.tModifier.NormlBack = null;
            this.tModifier.Padding = new System.Windows.Forms.Padding(5);
            this.tModifier.ReadOnly = false;
            this.tModifier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tModifier.Size = new System.Drawing.Size(1310, 31);
            // 
            // 
            // 
            this.tModifier.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tModifier.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tModifier.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tModifier.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tModifier.SkinTxt.Multiline = true;
            this.tModifier.SkinTxt.Name = "BaseText";
            this.tModifier.SkinTxt.Size = new System.Drawing.Size(1300, 21);
            this.tModifier.SkinTxt.TabIndex = 0;
            this.tModifier.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tModifier.SkinTxt.WaterText = "可填...";
            this.tModifier.TabIndex = 32;
            this.tModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tModifier.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tModifier.WaterText = "可填...";
            this.tModifier.WordWrap = true;
            // 
            // cType
            // 
            this.cType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cType.FormattingEnabled = true;
            this.cType.ItemBorderColor = System.Drawing.Color.Transparent;
            this.cType.Items.AddRange(new object[] {
            "软件研发瀑布模型",
            "软件研发迭代模型"});
            this.cType.Location = new System.Drawing.Point(107, 93);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(1304, 22);
            this.cType.TabIndex = 34;
            this.cType.WaterText = "必填...";
            // 
            // cPriority
            // 
            this.cPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cPriority.FormattingEnabled = true;
            this.cPriority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.cPriority.Location = new System.Drawing.Point(107, 123);
            this.cPriority.Name = "cPriority";
            this.cPriority.Size = new System.Drawing.Size(1304, 22);
            this.cPriority.TabIndex = 35;
            this.cPriority.WaterText = "必填...";
            // 
            // dtp_SetUpDate
            // 
            this.dtp_SetUpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_SetUpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_SetUpDate.DropDownHeight = 180;
            this.dtp_SetUpDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_SetUpDate.DropDownWidth = 120;
            this.dtp_SetUpDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_SetUpDate.Items = null;
            this.dtp_SetUpDate.Location = new System.Drawing.Point(107, 243);
            this.dtp_SetUpDate.Name = "dtp_SetUpDate";
            this.dtp_SetUpDate.Size = new System.Drawing.Size(1304, 24);
            this.dtp_SetUpDate.TabIndex = 36;
            this.dtp_SetUpDate.text = "";
            // 
            // dtp_ClosedDate
            // 
            this.dtp_ClosedDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ClosedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ClosedDate.DropDownHeight = 180;
            this.dtp_ClosedDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_ClosedDate.DropDownWidth = 120;
            this.dtp_ClosedDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_ClosedDate.Items = null;
            this.dtp_ClosedDate.Location = new System.Drawing.Point(107, 273);
            this.dtp_ClosedDate.Name = "dtp_ClosedDate";
            this.dtp_ClosedDate.Size = new System.Drawing.Size(1304, 24);
            this.dtp_ClosedDate.TabIndex = 37;
            this.dtp_ClosedDate.text = "";
            // 
            // dtp_BuildDate
            // 
            this.dtp_BuildDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_BuildDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_BuildDate.DropDownHeight = 180;
            this.dtp_BuildDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_BuildDate.DropDownWidth = 120;
            this.dtp_BuildDate.Enabled = false;
            this.dtp_BuildDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_BuildDate.Items = null;
            this.dtp_BuildDate.Location = new System.Drawing.Point(107, 393);
            this.dtp_BuildDate.Name = "dtp_BuildDate";
            this.dtp_BuildDate.Size = new System.Drawing.Size(1304, 24);
            this.dtp_BuildDate.TabIndex = 38;
            this.dtp_BuildDate.text = "";
            // 
            // dtp_ModifyDate
            // 
            this.dtp_ModifyDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ModifyDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ModifyDate.DropDownHeight = 180;
            this.dtp_ModifyDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_ModifyDate.DropDownWidth = 120;
            this.dtp_ModifyDate.Enabled = false;
            this.dtp_ModifyDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_ModifyDate.Items = null;
            this.dtp_ModifyDate.Location = new System.Drawing.Point(107, 454);
            this.dtp_ModifyDate.Name = "dtp_ModifyDate";
            this.dtp_ModifyDate.Size = new System.Drawing.Size(1304, 24);
            this.dtp_ModifyDate.TabIndex = 39;
            this.dtp_ModifyDate.text = "";
            // 
            // cbManager
            // 
            this.cbManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbManager.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(107, 184);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(1304, 22);
            this.cbManager.TabIndex = 40;
            this.cbManager.WaterText = "";
            this.cbManager.DropDown += new System.EventHandler(this.cbManager_DropDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labDescribe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtDescribe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 490);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 254);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labDescribe
            // 
            this.labDescribe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDescribe.AutoSize = true;
            this.labDescribe.BackColor = System.Drawing.Color.White;
            this.labDescribe.BorderColor = System.Drawing.Color.White;
            this.labDescribe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDescribe.Location = new System.Drawing.Point(3, 118);
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
            this.rtDescribe.Size = new System.Drawing.Size(1304, 248);
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
            // ToolProjectModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProjectModify";
            this.Text = "修改项目";
            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolProjectModify_FormClosing);
            this.Load += new System.EventHandler(this.ToolProjectModify_Load);
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
        private CCWin.SkinControl.SkinLabel labProjectName;
        private CCWin.SkinControl.SkinLabel labDepartment;
        private CCWin.SkinControl.SkinLabel labType;
        private CCWin.SkinControl.SkinLabel labPriority;
        private CCWin.SkinControl.SkinTextBox tProjectName;
        private CCWin.SkinControl.SkinLabel labShortName;
        private CCWin.SkinControl.SkinLabel labProjectNO;
        private CCWin.SkinControl.SkinTextBox tShortName;
        private CCWin.SkinControl.SkinTextBox tProjectNO;
        private CCWin.SkinControl.SkinTextBox tDepartment;
        private CCWin.SkinControl.SkinLabel labManager;
        private CCWin.SkinControl.SkinLabel labAssistant;
        private CCWin.SkinControl.SkinLabel labSetUpTime;
        private CCWin.SkinControl.SkinLabel labClosedTime;
        private CCWin.SkinControl.SkinLabel labCustomer;
        private CCWin.SkinControl.SkinLabel labDevelopmentSite;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labBuildTime;
        private CCWin.SkinControl.SkinLabel labModifier;
        private CCWin.SkinControl.SkinLabel labModifyTime;
        private CCWin.SkinControl.SkinTextBox tAssistant;
        private CCWin.SkinControl.SkinTextBox tCustomer;
        private CCWin.SkinControl.SkinTextBox tDevelopmentSite;
        private CCWin.SkinControl.SkinTextBox tAuthor;
        private CCWin.SkinControl.SkinTextBox tModifier;
        private CCWin.SkinControl.SkinComboBox cType;
        private CCWin.SkinControl.SkinComboBox cPriority;
        private CCWin.SkinControl.SkinDateTimePicker dtp_SetUpDate;
        private CCWin.SkinControl.SkinDateTimePicker dtp_ClosedDate;
        private CCWin.SkinControl.SkinDateTimePicker dtp_BuildDate;
        private CCWin.SkinControl.SkinDateTimePicker dtp_ModifyDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labDescribe;
        private CCWin.SkinControl.SkinChatRichTextBox rtDescribe;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private CCWin.SkinControl.SkinComboBox cbManager;
    }
}