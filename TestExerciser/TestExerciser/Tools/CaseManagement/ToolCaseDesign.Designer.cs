namespace TestExerciser
{
    partial class ToolCaseDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolCaseDesign));
            this.splitContainer_SideTab = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new DesignTE.View.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SideTab)).BeginInit();
            this.splitContainer_SideTab.Panel2.SuspendLayout();
            this.splitContainer_SideTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_SideTab
            // 
            this.splitContainer_SideTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_SideTab.Location = new System.Drawing.Point(4, 32);
            this.splitContainer_SideTab.Name = "splitContainer_SideTab";
            // 
            // splitContainer_SideTab.Panel2
            // 
            this.splitContainer_SideTab.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer_SideTab.Size = new System.Drawing.Size(1432, 789);
            this.splitContainer_SideTab.SplitterDistance = 1047;
            this.splitContainer_SideTab.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 767);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(381, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolCaseDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.splitContainer_SideTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolCaseDesign";
            this.Text = "用例设计";
            
            this.Load += new System.EventHandler(this.MainCaseDesign_Load);
            this.splitContainer_SideTab.Panel2.ResumeLayout(false);
            this.splitContainer_SideTab.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SideTab)).EndInit();
            this.splitContainer_SideTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_SideTab;
        public DesignTE.View.StatusBar statusStrip1;
    }
}