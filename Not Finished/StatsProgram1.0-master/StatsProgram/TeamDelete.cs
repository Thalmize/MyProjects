using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsProgram
{
    public partial class TeamDelete : Form
    {
        public TeamDelete()
        {
            InitializeComponent();
        }

        

        private void TeamDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {// closes team delete
            Close();
        }
    }
}
