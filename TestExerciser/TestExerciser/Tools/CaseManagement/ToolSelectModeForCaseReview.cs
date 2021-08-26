using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolSelectModeForCaseReview : Form
    {
        public ToolSelectModeForCaseReview()
        {
            InitializeComponent();
        }

        private void myOKFunc()
        {
            if (this.rdbReviewFromExcel.Checked == true)
            {
                ToolCaseReviewFromExcel myToolCaseReview = new ToolCaseReviewFromExcel();
                myToolCaseReview.Show();
                this.Visible = false;
                this.Close();
            }
            else if (this.rdbReviewDirect.Checked == true)
            {
                ToolCaseReviewDirect myToolCaseReviewDirect = new ToolCaseReviewDirect();
                myToolCaseReviewDirect.Show();
                this.Visible = false;
                this.Close();
            }
        }

        private void myCancelFunc()
        {
            this.Visible = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            myOKFunc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myCancelFunc();
        }
    }
}
