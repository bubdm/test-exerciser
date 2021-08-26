using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestExerciser.Tools.TaskManagement;

namespace TestExerciser
{
    public partial class MainTaskManager : Form
    {
        public MainTaskManager()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolTaskNew myToolTaskNew = new ToolTaskNew();
            myToolTaskNew.Show();
        }

        private void MainTaskManager_Load(object sender, EventArgs e)
        {

        }
    }
}
