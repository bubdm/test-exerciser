namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectSetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectSetName));
            this.labStatus = new System.Windows.Forms.Label();
            this.txtStruct = new CCWin.SkinControl.SkinTextBox();
            this.labStruct = new CCWin.SkinControl.SkinLabel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(40, 123);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 12);
            this.labStatus.TabIndex = 14;
            // 
            // txtStruct
            // 
            this.txtStruct.BackColor = System.Drawing.Color.Transparent;
            this.txtStruct.DownBack = null;
            this.txtStruct.Icon = null;
            this.txtStruct.IconIsButton = false;
            this.txtStruct.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtStruct.IsPasswordChat = '\0';
            this.txtStruct.IsSystemPasswordChar = false;
            this.txtStruct.Lines = new string[0];
            this.txtStruct.Location = new System.Drawing.Point(101, 76);
            this.txtStruct.Margin = new System.Windows.Forms.Padding(0);
            this.txtStruct.MaxLength = 32767;
            this.txtStruct.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtStruct.MouseBack = null;
            this.txtStruct.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtStruct.Multiline = false;
            this.txtStruct.Name = "txtStruct";
            this.txtStruct.NormlBack = null;
            this.txtStruct.Padding = new System.Windows.Forms.Padding(5);
            this.txtStruct.ReadOnly = false;
            this.txtStruct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStruct.Size = new System.Drawing.Size(275, 28);
            // 
            // 
            // 
            this.txtStruct.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStruct.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStruct.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtStruct.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtStruct.SkinTxt.Name = "BaseText";
            this.txtStruct.SkinTxt.Size = new System.Drawing.Size(265, 18);
            this.txtStruct.SkinTxt.TabIndex = 0;
            this.txtStruct.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtStruct.SkinTxt.WaterText = "1~20位中文、字母、数字";
            this.txtStruct.TabIndex = 10;
            this.txtStruct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStruct.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtStruct.WaterText = "1~20位中文、字母、数字";
            this.txtStruct.WordWrap = true;
            // 
            // labStruct
            // 
            this.labStruct.AutoSize = true;
            this.labStruct.BackColor = System.Drawing.Color.Transparent;
            this.labStruct.BorderColor = System.Drawing.Color.White;
            this.labStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStruct.Location = new System.Drawing.Point(35, 82);
            this.labStruct.Name = "labStruct";
            this.labStruct.Size = new System.Drawing.Size(68, 17);
            this.labStruct.TabIndex = 13;
            this.labStruct.Text = "架构名称：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(260, 148);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "取消新建";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(92, 148);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(111, 23);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "确定新建";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ToolProjectSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.txtStruct);
            this.Controls.Add(this.labStruct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolProjectSetName";
            this.Text = "";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStatus;
        private CCWin.SkinControl.SkinLabel labStruct;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        public CCWin.SkinControl.SkinTextBox txtStruct;

    }
}