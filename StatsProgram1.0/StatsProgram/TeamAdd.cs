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
using StatsProgram.Data;

namespace StatsProgram
{
    public partial class TeamAdd : Form
    {
        //declared variables

        public static StoredInformation SI = new StoredInformation();
      
        public TeamAdd()
        {
            InitializeComponent();
        }

        private void Roster_Load(object sender, EventArgs e)
        {
           //hidden label until shown
            lblTeamPlayer.Visible = false;


        }

        public void UpdateTeam()
        {
            
            StoredInformation.Team.teamName = txtbxTeamName.Text;
            StoredInformation.Team.teamNickName = txtbxTeamNick.Text;
            StoredInformation.Team.teamAbb = txtbxTeamAbb.Text;
            StoredInformation.Team.teamColors = txtbxSchColorPrimary.Text;
            StoredInformation.Coaches.teamHC = txtbxHeadCoach.Text;
            StoredInformation.Coaches.teamAC = txtbxAstCoach.Text;
            StoredInformation.Team.RosterName = txtbxRosterName.Text;


           


        }
        private void btnSaveTeam_Click(object sender, EventArgs e)
        {
            UpdateTeam();

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
