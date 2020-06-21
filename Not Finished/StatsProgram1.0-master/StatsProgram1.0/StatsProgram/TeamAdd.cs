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
            Information.Team.teamName = txtbxTeamName.Text;
            Information.Team.teamNickName = txtbxTeamNick.Text;
            Information.Team.teamAbb = txtbxTeamAbb.Text;
            Information.Team.teamColors = txtbxSchColor.Text;
            Information.Coaches.teamHC = txtbxHeadCoach.Text;
            Information.Coaches.teamAC = txtbxAstCoach.Text;
            Information.Team.RosterName = txtbxRosterName.Text;


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
