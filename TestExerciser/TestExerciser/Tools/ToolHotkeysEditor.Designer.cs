namespace TestExerciser.Tools
{
    partial class ToolHotkeysEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btResore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbModifiers = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbKey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbAction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btResore
            // 
            this.btResore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btResore.Location = new System.Drawing.Point(155, 318);
            this.btResore.Name = "btResore";
            this.btResore.Size = new System.Drawing.Size(63, 21);
            this.btResore.TabIndex = 13;
            this.btResore.Text = "恢复默认";
            this.btResore.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "快捷键映射关系";
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemove.Location = new System.Drawing.Point(86, 318);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(57, 21);
            this.btRemove.TabIndex = 9;
            this.btRemove.Text = "删除";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.Location = new System.Drawing.Point(24, 318);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 21);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbModifiers,
            this.cbKey,
            this.cbAction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(20, 47);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(525, 257);
            this.dgv.TabIndex = 7;
            // 
            // cbModifiers
            // 
            this.cbModifiers.DataPropertyName = "Modifiers";
            this.cbModifiers.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbModifiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModifiers.HeaderText = "修改项";
            this.cbModifiers.Name = "cbModifiers";
            // 
            // cbKey
            // 
            this.cbKey.DataPropertyName = "Key";
            this.cbKey.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKey.HeaderText = "快捷键";
            this.cbKey.Name = "cbKey";
            this.cbKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbKey.Width = 120;
            // 
            // cbAction
            // 
            this.cbAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbAction.DataPropertyName = "Action";
            this.cbAction.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAction.HeaderText = "操作";
            this.cbAction.Name = "cbAction";
            // 
            // ToolHotkeysEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btResore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgv);
            this.Name = "ToolHotkeysEditor";
            this.Size = new System.Drawing.Size(565, 369);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btResore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbModifiers;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbKey;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbAction;
    }
}
