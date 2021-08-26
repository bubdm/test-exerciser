namespace TestExerciser.Tools
{
    partial class DGVPager
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLast = new System.Windows.Forms.Button();
            this.linkFirst = new System.Windows.Forms.Button();
            this.linkPrevious = new System.Windows.Forms.Button();
            this.linkNext = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblSept = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(196, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 264;
            this.label5.Text = "条记录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 263;
            this.label3.Text = "当前页：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(145, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 261;
            this.label1.Text = "共";
            // 
            // linkLast
            // 
            this.linkLast.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLast.Location = new System.Drawing.Point(410, 1);
            this.linkLast.Name = "linkLast";
            this.linkLast.Size = new System.Drawing.Size(44, 23);
            this.linkLast.TabIndex = 260;
            this.linkLast.Text = ">>|";
            this.linkLast.UseVisualStyleBackColor = true;
            this.linkLast.Click += new System.EventHandler(this.linkLast_Click);
            // 
            // linkFirst
            // 
            this.linkFirst.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkFirst.Location = new System.Drawing.Point(255, 1);
            this.linkFirst.Name = "linkFirst";
            this.linkFirst.Size = new System.Drawing.Size(44, 23);
            this.linkFirst.TabIndex = 259;
            this.linkFirst.Text = "|<<";
            this.linkFirst.UseVisualStyleBackColor = true;
            this.linkFirst.Click += new System.EventHandler(this.linkFirst_Click);
            // 
            // linkPrevious
            // 
            this.linkPrevious.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkPrevious.Location = new System.Drawing.Point(312, 1);
            this.linkPrevious.Name = "linkPrevious";
            this.linkPrevious.Size = new System.Drawing.Size(34, 23);
            this.linkPrevious.TabIndex = 258;
            this.linkPrevious.Text = "<";
            this.linkPrevious.UseVisualStyleBackColor = true;
            this.linkPrevious.ClientSizeChanged += new System.EventHandler(this.linkPrevious_Click);
            this.linkPrevious.Click += new System.EventHandler(this.linkPrevious_Click);
            // 
            // linkNext
            // 
            this.linkNext.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkNext.Location = new System.Drawing.Point(361, 1);
            this.linkNext.Name = "linkNext";
            this.linkNext.Size = new System.Drawing.Size(34, 23);
            this.linkNext.TabIndex = 257;
            this.linkNext.Text = ">";
            this.linkNext.UseVisualStyleBackColor = true;
            this.linkNext.Click += new System.EventHandler(this.linkNext_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.ForeColor = System.Drawing.Color.Red;
            this.lblPageCount.Location = new System.Drawing.Point(108, 7);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(11, 12);
            this.lblPageCount.TabIndex = 256;
            this.lblPageCount.Text = "1";
            // 
            // lblSept
            // 
            this.lblSept.AutoSize = true;
            this.lblSept.Location = new System.Drawing.Point(91, 8);
            this.lblSept.Name = "lblSept";
            this.lblSept.Size = new System.Drawing.Size(11, 12);
            this.lblSept.TabIndex = 255;
            this.lblSept.Text = "/";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCount.Location = new System.Drawing.Point(168, 7);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(23, 12);
            this.lblTotalCount.TabIndex = 254;
            this.lblTotalCount.Text = "100";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentPage.Location = new System.Drawing.Point(74, 7);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(11, 12);
            this.lblCurrentPage.TabIndex = 253;
            this.lblCurrentPage.Text = "1";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(500, 1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 23);
            this.btnGo.TabIndex = 252;
            this.btnGo.Text = "跳转";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPageNum
            // 
            this.txtPageNum.Location = new System.Drawing.Point(465, 2);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(29, 21);
            this.txtPageNum.TabIndex = 251;
            this.txtPageNum.TextChanged += new System.EventHandler(this.txtPageNum_TextChanged);
            this.txtPageNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNum_KeyPress);
            // 
            // DGVPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLast);
            this.Controls.Add(this.linkFirst);
            this.Controls.Add(this.linkPrevious);
            this.Controls.Add(this.linkNext);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblSept);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPageNum);
            this.Name = "DGVPager";
            this.Size = new System.Drawing.Size(547, 25);
            this.Load += new System.EventHandler(this.DGVPager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button linkLast;
        private System.Windows.Forms.Button linkFirst;
        private System.Windows.Forms.Button linkPrevious;
        private System.Windows.Forms.Button linkNext;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblSept;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPageNum;
    }
}
