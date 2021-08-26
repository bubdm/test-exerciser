namespace TestExerciser.Tools.Control
{
    partial class ControlSearch
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSearch));
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.myTextBox.Location = new System.Drawing.Point(0, 2);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(238, 21);
            this.myTextBox.TabIndex = 0;
            // 
            // myBtn
            // 
            this.myBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.myBtn.Image = ((System.Drawing.Image)(resources.GetObject("myBtn.Image")));
            this.myBtn.Location = new System.Drawing.Point(238, 1);
            this.myBtn.Name = "myBtn";
            this.myBtn.Size = new System.Drawing.Size(23, 23);
            this.myBtn.TabIndex = 1;
            this.myBtn.UseVisualStyleBackColor = true;
            this.myBtn.Click += new System.EventHandler(this.myBtn_Click);
            // 
            // ControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myBtn);
            this.Controls.Add(this.myTextBox);
            this.Name = "ControlSearch";
            this.Size = new System.Drawing.Size(261, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button myBtn;
    }
}
