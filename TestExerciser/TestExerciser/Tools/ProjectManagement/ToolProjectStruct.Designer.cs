namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectStruct
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectStruct));
            this.myStructImageList = new System.Windows.Forms.ImageList(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.ts_Top = new CCWin.SkinControl.SkinToolStrip();
            this.tAdd = new System.Windows.Forms.ToolStripButton();
            this.tModify = new System.Windows.Forms.ToolStripButton();
            this.tDelete = new System.Windows.Forms.ToolStripButton();
            this.tSave = new System.Windows.Forms.ToolStripButton();
            this.tv_Struct = new CCWin.SkinControl.SkinTreeView();
            this.labStatus = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.ts_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // myStructImageList
            // 
            this.myStructImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myStructImageList.ImageStream")));
            this.myStructImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myStructImageList.Images.SetKeyName(0, "afchgorg.gif");
            this.myStructImageList.Images.SetKeyName(1, "3.png");
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.ts_Top, 0, 0);
            this.tlpMain.Controls.Add(this.tv_Struct, 0, 1);
            this.tlpMain.Controls.Add(this.labStatus, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.Size = new System.Drawing.Size(1432, 789);
            this.tlpMain.TabIndex = 1;
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
            this.tDelete,
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
            this.tAdd.Size = new System.Drawing.Size(100, 22);
            this.tAdd.Text = "添加架构节点";
            this.tAdd.Click += new System.EventHandler(this.tAdd_Click);
            // 
            // tModify
            // 
            this.tModify.Image = ((System.Drawing.Image)(resources.GetObject("tModify.Image")));
            this.tModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tModify.Name = "tModify";
            this.tModify.Size = new System.Drawing.Size(100, 22);
            this.tModify.Text = "修改架构节点";
            this.tModify.Click += new System.EventHandler(this.tModify_Click);
            // 
            // tDelete
            // 
            this.tDelete.Image = ((System.Drawing.Image)(resources.GetObject("tDelete.Image")));
            this.tDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(100, 22);
            this.tDelete.Text = "删除架构节点";
            this.tDelete.Click += new System.EventHandler(this.tDelete_Click);
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
            // tv_Struct
            // 
            this.tv_Struct.BackColor = System.Drawing.Color.White;
            this.tv_Struct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Struct.ImageIndex = 0;
            this.tv_Struct.ImageList = this.myStructImageList;
            this.tv_Struct.LabelEdit = true;
            this.tv_Struct.Location = new System.Drawing.Point(3, 33);
            this.tv_Struct.Name = "tv_Struct";
            this.tv_Struct.SelectedImageIndex = 0;
            this.tv_Struct.Size = new System.Drawing.Size(1426, 728);
            this.tv_Struct.TabIndex = 2;
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
            // ToolProjectStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProjectStruct";
            this.Text = "产品架构";
            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolProjectStruct_FormClosing);
            this.Load += new System.EventHandler(this.ToolProjectStruct_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ts_Top.ResumeLayout(false);
            this.ts_Top.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ImageList myStructImageList;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private CCWin.SkinControl.SkinToolStrip ts_Top;
        private System.Windows.Forms.ToolStripButton tAdd;
        private System.Windows.Forms.ToolStripButton tSave;
        private CCWin.SkinControl.SkinTreeView tv_Struct;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.ToolStripButton tModify;
        private System.Windows.Forms.ToolStripButton tDelete;
    }
}