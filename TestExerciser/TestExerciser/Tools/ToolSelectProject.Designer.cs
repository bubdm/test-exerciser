namespace TestExerciser.Tools
{
    partial class ToolSelectProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelectProject));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Button = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnFlush = new CCWin.SkinControl.SkinButton();
            this.tlp_Select = new System.Windows.Forms.TableLayoutPanel();
            this.labProjectName = new CCWin.SkinControl.SkinLabel();
            this.labProjectNO = new CCWin.SkinControl.SkinLabel();
            this.btnSearch = new CCWin.SkinControl.SkinButton();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectNO = new System.Windows.Forms.TextBox();
            this.dgvSelectProject = new CCWin.SkinControl.SkinDataGridView();
            this.dgvPager = new TestExerciser.Tools.DGVPager();
            this.txtStatus = new System.Windows.Forms.Label();
            this.tlp_Main.SuspendLayout();
            this.tlp_Button.SuspendLayout();
            this.tlp_Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectProject)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.tlp_Button, 0, 3);
            this.tlp_Main.Controls.Add(this.tlp_Select, 0, 0);
            this.tlp_Main.Controls.Add(this.dgvSelectProject, 0, 1);
            this.tlp_Main.Controls.Add(this.dgvPager, 0, 2);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Main.Location = new System.Drawing.Point(4, 32);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 4;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Main.Size = new System.Drawing.Size(602, 459);
            this.tlp_Main.TabIndex = 0;
            // 
            // tlp_Button
            // 
            this.tlp_Button.ColumnCount = 5;
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Button.Controls.Add(this.btnOK, 1, 0);
            this.tlp_Button.Controls.Add(this.btnCancel, 3, 0);
            this.tlp_Button.Controls.Add(this.btnFlush, 2, 0);
            this.tlp_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Button.Location = new System.Drawing.Point(3, 422);
            this.tlp_Button.Name = "tlp_Button";
            this.tlp_Button.RowCount = 1;
            this.tlp_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Button.Size = new System.Drawing.Size(596, 34);
            this.tlp_Button.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(134, 5);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(372, 5);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFlush
            // 
            this.btnFlush.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFlush.BackColor = System.Drawing.Color.Transparent;
            this.btnFlush.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFlush.DownBack = null;
            this.btnFlush.Location = new System.Drawing.Point(253, 5);
            this.btnFlush.MouseBack = null;
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.NormlBack = null;
            this.btnFlush.Size = new System.Drawing.Size(89, 23);
            this.btnFlush.TabIndex = 1;
            this.btnFlush.Text = "清空";
            this.btnFlush.UseVisualStyleBackColor = false;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // tlp_Select
            // 
            this.tlp_Select.ColumnCount = 3;
            this.tlp_Select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.93159F));
            this.tlp_Select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.06841F));
            this.tlp_Select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlp_Select.Controls.Add(this.labProjectName, 0, 0);
            this.tlp_Select.Controls.Add(this.labProjectNO, 0, 1);
            this.tlp_Select.Controls.Add(this.btnSearch, 2, 1);
            this.tlp_Select.Controls.Add(this.txtProjectName, 1, 0);
            this.tlp_Select.Controls.Add(this.txtProjectNO, 1, 1);
            this.tlp_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Select.Location = new System.Drawing.Point(3, 3);
            this.tlp_Select.Name = "tlp_Select";
            this.tlp_Select.RowCount = 2;
            this.tlp_Select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Select.Size = new System.Drawing.Size(596, 54);
            this.tlp_Select.TabIndex = 1;
            // 
            // labProjectName
            // 
            this.labProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labProjectName.AutoSize = true;
            this.labProjectName.BackColor = System.Drawing.Color.White;
            this.labProjectName.BorderColor = System.Drawing.Color.White;
            this.labProjectName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectName.Location = new System.Drawing.Point(13, 5);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(68, 17);
            this.labProjectName.TabIndex = 0;
            this.labProjectName.Text = "项目名称：";
            // 
            // labProjectNO
            // 
            this.labProjectNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labProjectNO.AutoSize = true;
            this.labProjectNO.BackColor = System.Drawing.Color.White;
            this.labProjectNO.BorderColor = System.Drawing.Color.White;
            this.labProjectNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectNO.Location = new System.Drawing.Point(13, 32);
            this.labProjectNO.Name = "labProjectNO";
            this.labProjectNO.Size = new System.Drawing.Size(68, 17);
            this.labProjectNO.TabIndex = 1;
            this.labProjectNO.Text = "项目编号：";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.Location = new System.Drawing.Point(469, 30);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(89, 21);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProjectName.Location = new System.Drawing.Point(97, 3);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(331, 21);
            this.txtProjectName.TabIndex = 5;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            // 
            // txtProjectNO
            // 
            this.txtProjectNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProjectNO.Location = new System.Drawing.Point(97, 30);
            this.txtProjectNO.Name = "txtProjectNO";
            this.txtProjectNO.Size = new System.Drawing.Size(331, 21);
            this.txtProjectNO.TabIndex = 6;
            this.txtProjectNO.TextChanged += new System.EventHandler(this.txtProjectNO_TextChanged);
            // 
            // dgvSelectProject
            // 
            this.dgvSelectProject.AllowUserToAddRows = false;
            this.dgvSelectProject.AllowUserToDeleteRows = false;
            this.dgvSelectProject.AllowUserToResizeColumns = false;
            this.dgvSelectProject.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvSelectProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectProject.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSelectProject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSelectProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelectProject.ColumnFont = null;
            this.dgvSelectProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectProject.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectProject.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelectProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectProject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSelectProject.EnableHeadersVisualStyles = false;
            this.dgvSelectProject.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSelectProject.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvSelectProject.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.dgvSelectProject.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSelectProject.Location = new System.Drawing.Point(3, 63);
            this.dgvSelectProject.MultiSelect = false;
            this.dgvSelectProject.Name = "dgvSelectProject";
            this.dgvSelectProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSelectProject.RowHeadersVisible = false;
            this.dgvSelectProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSelectProject.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelectProject.RowTemplate.Height = 23;
            this.dgvSelectProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectProject.Size = new System.Drawing.Size(596, 323);
            this.dgvSelectProject.TabIndex = 2;
            this.dgvSelectProject.TitleBack = null;
            this.dgvSelectProject.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvSelectProject.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvSelectProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectProject_CellClick);
            // 
            // dgvPager
            // 
            this.dgvPager.Location = new System.Drawing.Point(3, 392);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.PageIndex = 1;
            this.dgvPager.PageSize = 20;
            this.dgvPager.RecordCount = 0;
            this.dgvPager.Size = new System.Drawing.Size(547, 24);
            this.dgvPager.TabIndex = 3;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(29, 496);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 9;
            // 
            // ToolSelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 520);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSelectProject";
            this.Text = "选择项目";
            
            this.Load += new System.EventHandler(this.ToolSelectProject_Load);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Button.ResumeLayout(false);
            this.tlp_Select.ResumeLayout(false);
            this.tlp_Select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Button;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnFlush;
        private System.Windows.Forms.TableLayoutPanel tlp_Select;
        private CCWin.SkinControl.SkinLabel labProjectName;
        private CCWin.SkinControl.SkinLabel labProjectNO;
        private CCWin.SkinControl.SkinButton btnSearch;
        private CCWin.SkinControl.SkinDataGridView dgvSelectProject;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectNO;
        private System.Windows.Forms.Label txtStatus;
        private DGVPager dgvPager;
    }
}