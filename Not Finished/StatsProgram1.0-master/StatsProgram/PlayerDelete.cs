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
    public partial class PlayerDelete : Form
    {
        public PlayerDelete()
        {
            InitializeComponent();
        }

        private void PlayerDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {//closes player delete
            Close();

        }
    }
}
