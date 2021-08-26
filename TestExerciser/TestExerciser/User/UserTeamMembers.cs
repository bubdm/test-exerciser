using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestExerciser.Logic;

namespace TestExerciser.User
{
    public partial class UserTeamMembers : Form
    {
        ManageDB myManageDB = new ManageDB();
        DataTable myDTCase = new DataTable();

        public UserTeamMembers()
        {
            InitializeComponent();
        }     
    }
}
