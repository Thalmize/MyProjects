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
    public partial class TeamManagement : Form
    {
       
        public static int i;
        
        int c = 0;

        public TeamManagement()
        {
            InitializeComponent();
        }

        double ResetTime = 15;
        double currTime;

        public bool AddTeam;
        public bool DeleteTeam;
        public bool AddRoster;
        public bool DeleteRoster;

        private void RosterManagement_Load(object sender, EventArgs e)
        {
           
            //on Load
            PageTimer.Enabled = true;
            currTime = ResetTime;

            // set bool to false
            AddTeam = false;
            DeleteTeam = false;
            AddRoster = false;
            DeleteRoster = false;

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {//starts team add function
            TeamAdd teamadd = new TeamAdd();
            teamadd.ShowDialog();

            AddTeam = true;
        }

        private void btnOpenTeam_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.OpenTeam();
        }

        private void btnOpenRoster_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.OpenPlayers();

        }

        private void btnAddRoster_Click(object sender, EventArgs e)
        {
            //starts player function
            PlayerCore PC = new PlayerCore();
            PC.Show();

            AddRoster = true;
        }
       
       
        private void UpdateInformation()
        {
            c = 0;
            txtbxTeam.Text = Information.Team.teamName + " " + Information.Team.teamNickName + " - " + Information.Team.RosterName;

            txtbxPlayerRoster.Clear();
          
            while (c < Information.Team.RosterCount)
            {
                txtbxPlayerRoster.AppendText(Information.Players.FirstName[c] + " " + Information.Players.LastName[c] + " " + Information.Players.PlayerGrade[c] + " " + Information.Players.PlayerNum[c] + " " + Information.Players.PlayerPos[c]);
                txtbxPlayerRoster.AppendText(Environment.NewLine);
                c++;
            }
           
        }
        private void PageTimer_Tick(object sender, EventArgs e)
        {
            TimerShowBottom.Text = currTime--.ToString();
            
            if (currTime <= 0)
            {
                UpdateInformation();
                currTime = ResetTime;
            }
        }
    }
}
