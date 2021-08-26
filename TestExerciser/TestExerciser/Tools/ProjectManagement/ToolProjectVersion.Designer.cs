namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectVersion));
            this.labStatus = new System.Windows.Forms.Label();
            this.tv_Version = new CCWin.SkinControl.SkinTreeView();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.ts_Top = new CCWin.SkinControl.SkinToolStrip();
            this.tAdd = new System.Windows.Forms.ToolStripButton();
            this.tModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tSave = new System.Windows.Forms.ToolStripButton();
            this.myVersionImageList = new System.Windows.Forms.ImageList(this.components);
            this.tlpMain.SuspendLayout();
            this.ts_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // labStatus
            // 
            this.labStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(3, 770);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 3;
            // 
            // tv_Version
            // 
            this.tv_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Version.ImageIndex = 0;
            this.tv_Version.ImageList = this.myVersionImageList;
            this.tv_Version.LabelEdit = true;
            this.tv_Version.Location = new System.Drawing.Point(3, 33);
            this.tv_Version.Name = "tv_Version";
            this.tv_Version.SelectedImageIndex = 0;
            this.tv_Version.Size = new System.Drawing.Size(1426, 728);
            this.tv_Version.TabIndex = 2;
            this.tv_Version.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Version_NodeMouseDoubleClick);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.ts_Top, 0, 0);
            this.tlpMain.Controls.Add(this.tv_Version, 0, 1);
            this.tlpMain.Controls.Add(this.labStatus, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1432, 789);
            this.tlpMain.TabIndex = 0;
            // 
            // ts_Top
            // 
            this.ts_Top.Arrow = System.Drawing.Color.Black;
            this.ts_Top.Back = System.Drawing.Color.White;
            this.ts_Top.BackRadius = 4;
            this.ts_Top.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.ts_Top.Base = System.Drawing.Color.WhiteSmoke;
            this.ts_Top.BaseFore = System.Drawing.Color.Black;
            this.ts_Top.BaseForeAnamorphosis = false;
            this.ts_Top.BaseForeAnamorphosisBorder = 4;
            this.ts_Top.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.ts_Top.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.ts_Top.BaseHoverFore = System.Drawing.Color.Blue;
            this.ts_Top.BaseItemAnamorphosis = true;
            this.ts_Top.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemBorderShow = true;
            this.ts_Top.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("ts_Top.BaseItemDown")));
            this.ts_Top.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("ts_Top.BaseItemMouse")));
            this.ts_Top.BaseItemNorml = null;
            this.ts_Top.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemRadius = 4;
            this.ts_Top.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BindTabControl = null;
            this.ts_Top.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ts_Top.Fore = System.Drawing.Color.Black;
            this.ts_Top.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.ts_Top.HoverFore = System.Drawing.Color.Blue;
            this.ts_Top.ItemAnamorphosis = true;
            this.ts_Top.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemBorderShow = true;
            this.ts_Top.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemRadius = 4;
            this.ts_Top.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAdd,
            this.tModify,
            this.toolStripButton1,
            this.tSave});
            this.ts_Top.Location = new System.Drawing.Point(0, 0);
            this.ts_Top.Name = "ts_Top";
            this.ts_Top.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.Size = new System.Drawing.Size(1432, 25);
            this.ts_Top.SkinAllColor = true;
            this.ts_Top.TabIndex = 1;
            this.ts_Top.TitleAnamorphosis = true;
            this.ts_Top.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ts_Top.TitleRadius = 4;
            this.ts_Top.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tAdd
            // 
            this.tAdd.Image = ((System.Drawing.Image)(resources.GetObject("tAdd.Image")));
            this.tAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(76, 22);
            this.tAdd.Text = "添加版本";
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // tModify
            // 
            this.tModify.Image = ((System.Drawing.Image)(resources.GetObject("tModify.Image")));
            this.tModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tModify.Name = "tModify";
            this.tModify.Size = new System.Drawing.Size(76, 22);
            this.tModify.Text = "修改版本";
            this.tModify.Click += new System.EventHandler(this.tModify_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton1.Text = "删除版本";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSave
            // 
            this.tSave.Image = ((System.Drawing.Image)(resources.GetObject("tSave.Image")));
            this.tSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSave.Name = "tSave";
            this.tSave.Size = new System.Drawing.Size(52, 22);
            this.tSave.Text = "保存";
            this.tSave.Click += new System.EventHandler(this.tSave_Click);
            // 
            // myVersionImageList
            // 
            this.myVersionImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myVersionImageList.ImageStream")));
            this.myVersionImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myVersionImageList.Images.SetKeyName(0, "structure_tree_right.png");
            this.myVersionImageList.Images.SetKeyName(1, "conn_arrowed.png");
            // 
            // ToolProjectVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProjectVersion";
            this.Text = "产品版本";
            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolProjectVersion_FormClosing);
            this.Load += new System.EventHandler(this.ToolProjectVersion_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ts_Top.ResumeLayout(false);
            this.ts_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labStatus;
        private CCWin.SkinControl.SkinTreeView tv_Version;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private CCWin.SkinControl.SkinToolStrip ts_Top;
        private System.Windows.Forms.ToolStripButton tAdd;
        private System.Windows.Forms.ToolStripButton tSave;
        private System.Windows.Forms.ToolStripButton tModify;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList myVersionImageList;

    }
}