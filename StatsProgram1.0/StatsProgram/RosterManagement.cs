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
    public partial class RosterManagement : Form
    {
        string[] gfc = new string[1000];
        string[] plynum = new string[1000];
        string[] fstnme = new string[1000];
        string[] lstnme = new string[1000];
        string[] plygde = new string[1000];

        int i = 0;
        int b = 0;

        public string teamName;
        public string teamNickName;
        public string teamAbb;
        public string teamColors;
        public string teamHC;
        public string teamAC;
        public string RosterName;

        string[] line;
        int linecount;
        public RosterManagement()
        {
            InitializeComponent();
        }




        private void RosterManagement_Load(object sender, EventArgs e)
        {
            //on Load
           

           
        }

    




       

        private void btnAddTeam_Click(object sender, EventArgs e)
        {//starts team add function
            TeamAdd teamadd = new TeamAdd();
            teamadd.ShowDialog();
        }

       

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            //starts team delete function

            TeamDelete teamdelete = new TeamDelete();
            teamdelete.ShowDialog();

        }

        private void btnDeleteRoster_Click(object sender, EventArgs e)
        {//starts roster delete function
            RosterDelete rosterdelete = new RosterDelete();
            rosterdelete.ShowDialog();
        }

        private void btnModifyPlayer_Click(object sender, EventArgs e)
        {//starts player function
            Player player = new Player();
            player.ShowDialog();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {//starts player core function

            PlayerCore playercore = new PlayerCore();
            playercore.ShowDialog();

        }
        private void LoadTeam()
        {
            //opens team information
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                Title = "Team"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        string filename = openFileDialog1.FileName;
                        linecount = File.ReadAllLines(filename).Count();
                        var line = File.ReadAllLines(filename);

                        teamName = line[0];
                        teamNickName = line[1];
                        teamAbb = line[2];
                        teamColors = line[3];
                        teamHC = line[4];
                        teamAC = line[5];
                        RosterName = line[6];

                        txtbxSelRoster.Text = RosterName;
                        txtbxSelTeam.Text = teamName;




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            
        }
        
        private void btnlbclear_Click(object sender, EventArgs e)
        {//clears roster out and resets counts
            lbTeamRoster.Items.Clear();
            linecount = 0;
            i = 0;
        }

        private void btnShowTeam_Click(object sender, EventArgs e)
        {//loads team 
            LoadTeam();
            

            
            

            
        }

        private void OpenTeamPlayers()
        {
            // opens roster
            OpenFileDialog openFileDialog2 = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                Title = "Team Roster"
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog2.OpenFile()) != null)
                    {
                        string filename = openFileDialog2.FileName;
                        linecount = File.ReadAllLines(filename).Count();
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            while (reader.Peek() >= 0)
                            {
                                var line = reader.ReadLine();

                                var parts = line.Split('|');

                                plynum[i] = parts[0];
                                gfc[i] = parts[1];
                                fstnme[i] = parts[2];
                                lstnme[i] = parts[3];
                                plygde[i] = parts[4];

                                //adds player information to the listbox

                                lbTeamRoster.Items.Add(plynum[i] + " " + gfc[i] + " " + fstnme[i] + " " + lstnme[i]);
                                i++;
                            } 
                           
                        }
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void btnShowRoster_Click(object sender, EventArgs e)
        {//Opens team players

            OpenTeamPlayers();
        }
    }
}
