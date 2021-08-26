using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TestExerciser.Tools
{
    public class ToolBalloon : Form
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBalloon));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.richMeg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // richMeg
            // 
            this.richMeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richMeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richMeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richMeg.Enabled = false;
            this.richMeg.ForeColor = System.Drawing.Color.Navy;
            this.richMeg.Location = new System.Drawing.Point(4, 32);
            this.richMeg.Name = "richMeg";
            this.richMeg.ReadOnly = true;
            this.richMeg.Size = new System.Drawing.Size(230, 72);
            this.richMeg.TabIndex = 0;
            this.richMeg.Text = "弹出消息提示信息";
            // 
            // ToolBalloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(238, 108);
            this.Controls.Add(this.richMeg);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolBalloon";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "消息提示：";
            
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BalloonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;

        public int StayTime = 5000;

        private int heightMax, widthMax;
        private RichTextBox richMeg;

        public string BalloonText
        {
            get { return this.richMeg.Text; }
            set { this.richMeg.Text = value; }
        }

        public Color BalloonBackColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color BalloonForeColor
        {
            get { return this.richMeg.ForeColor; }
            set { this.richMeg.ForeColor = value; }
        }


        public ToolBalloon()
        {
            InitializeComponent();

            this.HeightMax = 120;//窗体滚动的高度
            this.WidthMax = 200;//窗体滚动的宽度
            this.ScrollShow();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScrollUp();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ScrollDown();

        }

        public int HeightMax
        {
            set
            {
                heightMax = value;
            }
            get
            {
                return heightMax;
            }
        }

        public int WidthMax
        {
            set
            {
                widthMax = value;
            }
            get
            {
                return widthMax;
            }
        }
        public void ScrollShow()
        {
            this.Width = widthMax;
            this.Height = 0;
            this.Show();
            this.timer1.Enabled = true;
        }
        private void ScrollUp()
        {
            if (Height < heightMax)
            {
                this.Height += 3;
                this.Location = new Point(this.Location.X, this.Location.Y - 3);
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = true;
            }
        }

        private void ScrollDown()
        {
            if (Height > 3)
            {
                this.Height -= 3;
                this.Location = new Point(this.Location.X, this.Location.Y + 3);
            }
            else
            {
                this.timer3.Enabled = false;
                this.Close();
            }
        }

        private void BalloonForm_Load(object sender, EventArgs e)
        {

            Screen screen = Screen.PrimaryScreen; ;//获取屏幕变量
            this.Location = new Point(screen.WorkingArea.Width - widthMax - 20, screen.WorkingArea.Height - 34);//WorkingArea为Windows桌面的工作区
            this.timer2.Interval = StayTime;

        }

    }
}
