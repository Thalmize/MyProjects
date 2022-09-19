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
    public partial class RosterDelete : Form
    {
        public RosterDelete()
        {
            InitializeComponent();
        }

        private void RosterDelete_Load(object sender, EventArgs e)
        {
           

        }

        private void btnDeleteRoster_Click(object sender, EventArgs e)
        {//closes roster delete
            Close();
        }
    }
}
