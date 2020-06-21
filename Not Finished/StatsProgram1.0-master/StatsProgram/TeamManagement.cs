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
        int b = 0;
        int c = 0;

        public TeamManagement()
        {
            InitializeComponent();
        }

        double ResetTime = 30;
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

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            //starts team delete function

            TeamDelete teamdelete = new TeamDelete();
            teamdelete.ShowDialog();

            DeleteTeam = true;

        }

        private void btnDeleteRoster_Click(object sender, EventArgs e)
        {//starts roster delete function
            RosterDelete rosterdelete = new RosterDelete();
            rosterdelete.ShowDialog();

            DeleteRoster = true;
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

          
            while (c < 20)
            {
                txtbxPlayerRoster.AppendText(Information.Players.FirstName[c] + " " + Information.Players.LastName[c]);
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
