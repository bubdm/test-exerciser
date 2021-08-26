namespace TestExerciser.User
{
    partial class UserSelectDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSelectDB));
            this.stbServerDBPath = new CCWin.SkinControl.SkinTextBox();
            this.rdbLocal = new CCWin.SkinControl.SkinRadioButton();
            this.rdbServer = new CCWin.SkinControl.SkinRadioButton();
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // stbServerDBPath
            // 
            this.stbServerDBPath.BackColor = System.Drawing.Color.Transparent;
            this.stbServerDBPath.DownBack = null;
            this.stbServerDBPath.Icon = null;
            this.stbServerDBPath.IconIsButton = false;
            this.stbServerDBPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbServerDBPath.IsPasswordChat = '\0';
            this.stbServerDBPath.IsSystemPasswordChar = false;
            this.stbServerDBPath.Lines = new string[0];
            this.stbServerDBPath.Location = new System.Drawing.Point(61, 127);
            this.stbServerDBPath.Margin = new System.Windows.Forms.Padding(0);
            this.stbServerDBPath.MaxLength = 32767;
            this.stbServerDBPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.stbServerDBPath.MouseBack = null;
            this.stbServerDBPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbServerDBPath.Multiline = false;
            this.stbServerDBPath.Name = "stbServerDBPath";
            this.stbServerDBPath.NormlBack = null;
            this.stbServerDBPath.Padding = new System.Windows.Forms.Padding(5);
            this.stbServerDBPath.ReadOnly = false;
            this.stbServerDBPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbServerDBPath.Size = new System.Drawing.Size(251, 28);
            // 
            // 
            // 
            this.stbServerDBPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbServerDBPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbServerDBPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbServerDBPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stbServerDBPath.SkinTxt.Name = "BaseText";
            this.stbServerDBPath.SkinTxt.Size = new System.Drawing.Size(241, 18);
            this.stbServerDBPath.SkinTxt.TabIndex = 0;
            this.stbServerDBPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbServerDBPath.SkinTxt.WaterText = "172.20.32.147";
            this.stbServerDBPath.TabIndex = 1;
            this.stbServerDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbServerDBPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbServerDBPath.WaterText = "172.20.32.147";
            this.stbServerDBPath.WordWrap = true;
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.BackColor = System.Drawing.Color.Transparent;
            this.rdbLocal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdbLocal.DownBack = null;
            this.rdbLocal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbLocal.Location = new System.Drawing.Point(65, 56);
            this.rdbLocal.MouseBack = null;
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.NormlBack = null;
            this.rdbLocal.SelectedDownBack = null;
            this.rdbLocal.SelectedMouseBack = null;
            this.rdbLocal.SelectedNormlBack = null;
            this.rdbLocal.Size = new System.Drawing.Size(193, 21);
            this.rdbLocal.TabIndex = 2;
            this.rdbLocal.TabStop = true;
            this.rdbLocal.Text = "本地（需本地配置SQL数据库）";
            this.rdbLocal.UseVisualStyleBackColor = false;
            this.rdbLocal.CheckedChanged += new System.EventHandler(this.rdbLocal_CheckedChanged);
            // 
            // rdbServer
            // 
            this.rdbServer.AutoSize = true;
            this.rdbServer.BackColor = System.Drawing.Color.Transparent;
            this.rdbServer.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdbServer.DownBack = null;
            this.rdbServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbServer.Location = new System.Drawing.Point(65, 94);
            this.rdbServer.MouseBack = null;
            this.rdbServer.Name = "rdbServer";
            this.rdbServer.NormlBack = null;
            this.rdbServer.SelectedDownBack = null;
            this.rdbServer.SelectedMouseBack = null;
            this.rdbServer.SelectedNormlBack = null;
            this.rdbServer.Size = new System.Drawing.Size(193, 21);
            this.rdbServer.TabIndex = 3;
            this.rdbServer.TabStop = true;
            this.rdbServer.Text = "远程服务器（服务器IP或名称）";
            this.rdbServer.UseVisualStyleBackColor = false;
            this.rdbServer.CheckedChanged += new System.EventHandler(this.rdbServer_CheckedChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(25, 171);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(214, 205);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消选择";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(61, 205);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定选择";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // UserSelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 254);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdbServer);
            this.Controls.Add(this.rdbLocal);
            this.Controls.Add(this.stbServerDBPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserSelectDB";
            this.Text = "选择服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSelectDB_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserSelectDB_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox stbServerDBPath;
        private CCWin.SkinControl.SkinRadioButton rdbLocal;
        private CCWin.SkinControl.SkinRadioButton rdbServer;
        private System.Windows.Forms.Label txtStatus;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;


    }
}