using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace StatsProgram
{
    public partial class TeamAdd : Form
    {
        //declared variables


        int i = 0;
        public TeamAdd()
        {
            InitializeComponent();
        }

        private void Roster_Load(object sender, EventArgs e)
        {
           //hidden label until shown
            lblTeamPlayer.Visible = false;


        }

        private void btnSaveTeam_Click(object sender, EventArgs e)
        {
           //on click label is visible
            lblTeamPlayer.Visible = true;
            //saves team to file
            ReportTxtArea RTA = new ReportTxtArea();
            RTA.SaveTeam();

            
           Close();

        
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
        
            //closes Team Add
            Close();

        }
    }
}
