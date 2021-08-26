using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser.Tools.BugManagement
{
    public delegate void SetBugComment();

    public partial class ToolBugComment : Form
    {
        static int inputCountMax = 120;
        int inputCountRemain = inputCountMax;
        bool isOutRange = false;
        public static string retext = "";
        public event SetBugComment AddBugComment;
        public ToolBugComment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isOutRange)
            {
                if (this.rtbComment.Text != "")
                {
                    retext = this.rtbComment.Text;
                    this.Close();
                    this.AddBugComment();

                }
                else
                {
                    ToolBalloon tb = new ToolBalloon();
                    tb.BalloonText = "请将必填项填写完整!";
                    tb.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void ToolBugComment_Load(object sender, EventArgs e)
        {
            this.showNotice(inputCountMax);
        }

        private void rtbComment_TextChanged(object sender, EventArgs e)
        {
            int intputCount =  this.GetRemainInputCount(this.rtbComment.Text);
            inputCountRemain = inputCountMax - intputCount;
            this.showNotice(inputCountRemain);
        }

        private int GetRemainInputCount(string str)
        {
            if (str == null || str.Length == 0) { return 0; }

            int strLength = str.Length;
            int realLen = strLength;

            #region 计算长度
            int clen = 0;//当前长度
            while (clen < strLength)
            {
                //每遇到一个中文，则将实际长度加一。
                if ((int)str[clen] > 128) { realLen++; }
                clen++;
            }
            #endregion

            return realLen;
        }

        private void showNotice(int remainCount)
        {
            this.labNotice.Text = "注：最多输入" + inputCountMax + "个字符，您当前可再输入" + remainCount.ToString() + "个字符!";
            if (remainCount >= 0)
            {
                this.labNotice.ForeColor = Color.Green;
                isOutRange = false;
            }
            else
            {
                this.labNotice.ForeColor = Color.Red;
                isOutRange = true;
            }
        }
    }
}
