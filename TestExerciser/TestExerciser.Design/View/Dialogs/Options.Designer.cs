namespace DesignTE.View.Dialogs
{
    partial class Options
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMapEditorBackColor = new System.Windows.Forms.Label();
            this.lblNoteEditorBackColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(184, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Map Background Color:";
            // 
            // lblMapEditorBackColor
            // 
            this.lblMapEditorBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMapEditorBackColor.Location = new System.Drawing.Point(179, 17);
            this.lblMapEditorBackColor.Name = "lblMapEditorBackColor";
            this.lblMapEditorBackColor.Size = new System.Drawing.Size(70, 14);
            this.lblMapEditorBackColor.TabIndex = 5;
            this.lblMapEditorBackColor.Click += new System.EventHandler(this.lblMapEditorBackColor_Click);
            // 
            // lblNoteEditorBackColor
            // 
            this.lblNoteEditorBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoteEditorBackColor.Location = new System.Drawing.Point(179, 40);
            this.lblNoteEditorBackColor.Name = "lblNoteEditorBackColor";
            this.lblNoteEditorBackColor.Size = new System.Drawing.Size(70, 14);
            this.lblNoteEditorBackColor.TabIndex = 7;
            this.lblNoteEditorBackColor.Click += new System.EventHandler(this.lblNoteEditorBackColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note Background Color:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 205);
            this.Controls.Add(this.lblNoteEditorBackColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMapEditorBackColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选项设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMapEditorBackColor;
        private System.Windows.Forms.Label lblNoteEditorBackColor;
        private System.Windows.Forms.Label label3;
    }
}