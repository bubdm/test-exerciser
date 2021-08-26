namespace TestExerciser.Tools.CaseManagement
{
    partial class ToolSelectModeForCaseReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelectModeForCaseReview));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.rdbReviewFromExcel = new CCWin.SkinControl.SkinRadioButton();
            this.rdbReviewDirect = new CCWin.SkinControl.SkinRadioButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 190);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消选择";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbReviewFromExcel
            // 
            this.rdbReviewFromExcel.AutoSize = true;
            this.rdbReviewFromExcel.BackColor = System.Drawing.Color.Transparent;
            this.rdbReviewFromExcel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdbReviewFromExcel.DownBack = null;
            this.rdbReviewFromExcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbReviewFromExcel.Location = new System.Drawing.Point(71, 110);
            this.rdbReviewFromExcel.MouseBack = null;
            this.rdbReviewFromExcel.Name = "rdbReviewFromExcel";
            this.rdbReviewFromExcel.NormlBack = null;
            this.rdbReviewFromExcel.SelectedDownBack = null;
            this.rdbReviewFromExcel.SelectedMouseBack = null;
            this.rdbReviewFromExcel.SelectedNormlBack = null;
            this.rdbReviewFromExcel.Size = new System.Drawing.Size(240, 21);
            this.rdbReviewFromExcel.TabIndex = 12;
            this.rdbReviewFromExcel.TabStop = true;
            this.rdbReviewFromExcel.Text = "Excel用例评审（评审对象为Excel文档）";
            this.rdbReviewFromExcel.UseVisualStyleBackColor = false;
            // 
            // rdbReviewDirect
            // 
            this.rdbReviewDirect.AutoSize = true;
            this.rdbReviewDirect.BackColor = System.Drawing.Color.Transparent;
            this.rdbReviewDirect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdbReviewDirect.DownBack = null;
            this.rdbReviewDirect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbReviewDirect.Location = new System.Drawing.Point(71, 70);
            this.rdbReviewDirect.MouseBack = null;
            this.rdbReviewDirect.Name = "rdbReviewDirect";
            this.rdbReviewDirect.NormlBack = null;
            this.rdbReviewDirect.SelectedDownBack = null;
            this.rdbReviewDirect.SelectedMouseBack = null;
            this.rdbReviewDirect.SelectedNormlBack = null;
            this.rdbReviewDirect.Size = new System.Drawing.Size(254, 21);
            this.rdbReviewDirect.TabIndex = 13;
            this.rdbReviewDirect.TabStop = true;
            this.rdbReviewDirect.Text = "用例评审（对当前用户新建用例直接评审）";
            this.rdbReviewDirect.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 190);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定选择";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ToolSelectModeForCaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 254);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdbReviewDirect);
            this.Controls.Add(this.rdbReviewFromExcel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolSelectModeForCaseReview";
            this.Text = "选择评审方式";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinRadioButton rdbReviewFromExcel;
        private CCWin.SkinControl.SkinRadioButton rdbReviewDirect;
        private CCWin.SkinControl.SkinButton btnOK;
    }
}