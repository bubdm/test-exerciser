namespace TestExerciser.Tools.BugManagement
{
    partial class ToolBugComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBugComment));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.labStatus = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.labNotice = new CCWin.SkinControl.SkinLabel();
            this.tlpMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpButton, 0, 2);
            this.tlpMain.Controls.Add(this.labStatus, 0, 3);
            this.tlpMain.Controls.Add(this.rtbComment, 0, 0);
            this.tlpMain.Controls.Add(this.labNotice, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpMain.Size = new System.Drawing.Size(433, 314);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 4;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButton.Controls.Add(this.btnSave, 1, 0);
            this.tlpButton.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 269);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpButton.Size = new System.Drawing.Size(427, 30);
            this.tlpButton.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Location = new System.Drawing.Point(109, 4);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(100, 22);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(215, 4);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(100, 22);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labStatus
            // 
            this.labStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(3, 302);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 2;
            // 
            // rtbComment
            // 
            this.rtbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComment.Location = new System.Drawing.Point(3, 3);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(427, 230);
            this.rtbComment.TabIndex = 3;
            this.rtbComment.Text = "";
            this.rtbComment.TextChanged += new System.EventHandler(this.rtbComment_TextChanged);
            // 
            // labNotice
            // 
            this.labNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNotice.AutoSize = true;
            this.labNotice.BackColor = System.Drawing.Color.Transparent;
            this.labNotice.BorderColor = System.Drawing.Color.White;
            this.labNotice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNotice.Location = new System.Drawing.Point(3, 242);
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(0, 17);
            this.labNotice.TabIndex = 4;
            // 
            // ToolBugComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 350);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolBugComment";
            this.Text = "发表评论";
            this.Load += new System.EventHandler(this.ToolBugComment_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinButton btnCancel;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.RichTextBox rtbComment;
        private CCWin.SkinControl.SkinLabel labNotice;
    }
}