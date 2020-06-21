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
    public partial class AddGame : Form
    {
        //Declares Variable

        public AddGame()
        {
            InitializeComponent();
           

        }
        // List of variables needed for txt files
          // used for player information adding to get to next player
        int rostercount = 0;
        //timer
        double UpdateLimit = 30;
        double updatetics;
        double CurrentTiming;
        ReportTxtArea RTA = new ReportTxtArea();


        int a = 0;//repeating variable used with players adding 
        int z = 0;//used once a game
        public void AddGame_Load(object sender, EventArgs e)
        {  //timer initiate
            UpdateTimer.Enabled = true;
            updatetics = UpdateLimit;
            // player information
          //  OpenFiles();
            a = 0;
            z = 0;
            txtbxW.Text = Stats.GameInformation.TeamWin.ToString();
            txtbxL.Text = Stats.GameInformation.TeamLoss.ToString();
            Stats.GameInformation.GameNumber = 1;
            txtbxGameNum.Text = Stats.GameInformation.GameNumber.ToString();
            txtbxTeamRoster.Text = Information.Team.RosterName;
            txtbxPlayer.Text = Information.Players.FirstName[a] + " " + Information.Players.LastName[a];
            txtbxNumber.Text = Information.Players.PlayerNum[a];
            
        }
        #region OpenTeam&Players
        private void OpenFiles()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true, 
                Title = "Team Information"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        string filename = openFileDialog1.FileName;

                        var line = File.ReadAllLines(filename);
                        {


                            Information.Team.teamName = line[0];
                            Information.Team.teamNickName = line[1];
                            Information.Team.teamAbb = line[2];
                            Information.Team.teamColors = line[3];
                            Information.Coaches.teamHC = line[4];
                            Information.Coaches.teamAC = line[5];
                            Information.Team.RosterName = line[6];

                           
                        }

                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
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
                        rostercount = File.ReadAllLines(filename).Count();
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            while (reader.Peek() >= 0)
                            {
                                var line = reader.ReadLine();

                                //splits line into 5 parts
                                var parts = line.Split('|');

                                Information.Players.PlayerNum[a] = parts[0];//Number
                                Information.Players.PlayerPos[a] = parts[1];//Position
                                Information.Players.FirstName[a] = parts[2];//First Name
                                Information.Players.LastName[a] = parts[3];//Last Name
                                Information.Players.PlayerGrade[a] = parts[4];//Grade
                                a++;
                                //adds player information to the listbox


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
        #endregion
        
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            z++;
            a = 0;
            Stats.GameInformation.GameNumber++;
            txtbxGameNum.Text = Stats.GameInformation.GameNumber.ToString();
            txtbxPlayer.Text = Information.Players.FirstName[a] + " " + Information.Players.LastName[a];
            txtbxNumber.Text = Information.Players.PlayerNum[a];

            Resettxtboxes();
              
        }
        #region Reset Text Boxes

        private void Resettxtboxes()
        {
            //clears out txtbxs
            txtbxFouls.Text = "0";
            txtbxTwos.Text = "0";
            txtbxThree.Text = "0";
            txtbxFTM.Text = "0";
            txtbxFTA.Text = "0";
            txtbxTotal.Text = "0";
            txtbxAway1Q.Text = "0";
            txtbxAway2Q.Text = "0";
            txtbxAway3Q.Text = "0";
            txtbxAway4Q.Text = "0";
            txtbxAwayTotal.Text = "0";
            txtbxHome1Q.Text = "0";
            txtbxHome2Q.Text = "0";
            txtbxHome3Q.Text = "0";
            txtbxHome4Q.Text = "0";
            txtbxHomeTotal.Text = "0";
            txtbxResultAwayTeam.Clear();
            txtbxResultHomeTeam.Clear();
            txtbxDoG.Clear();
            txtbxGL.Clear();
            txtbxAwayTeamName.Clear();
        }

        #endregion

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            
            RTA.AddPlayersFile();
            a++;
            txtbxPlayer.Text = Information.Players.FirstName[a] + " " + Information.Players.LastName[a];
            txtbxNumber.Text = Information.Players.PlayerNum[a];
            //clears out txtbxs
            txtbxFouls.Text = "0";
            txtbxTwos.Text = "0";
            txtbxThree.Text = "0";
            txtbxFTM.Text = "0";
            txtbxFTA.Text = "0";
            txtbxTotal.Text = "0";
            if (checkDNP.Checked == true)
            {
                checkDNP.Checked = false;
            }

           
        }

        
        #region Updating Variables
        public void UpdatingVariables()
        {
            //player line-update to variable
            if (checkDNP.Checked == false)
            {
                txtbxFouls.Enabled = true;
                txtbxTwos.Enabled = true;
                txtbxThree.Enabled = true;
                txtbxFTM.Enabled = true;
                txtbxFTA.Enabled = true;
                txtbxTotal.Enabled = true;
                txtbxDReb.Enabled = true;
                txtbxOReb.Enabled = true;
                txtbxTReb.Enabled = true;
                txtbxTO.Enabled = true;
                txtbxSTL.Enabled = true;
                txtbxBLK.Enabled = true;
                //PlayerStats[a, 0] = PlayerStats[a, 0] + 1;//GP

            }
            if (checkDNP.Checked == true)
            {
                txtbxFouls.Enabled = false;
                txtbxTwos.Enabled = false;
                txtbxThree.Enabled = false;
                txtbxFTM.Enabled = false;
                txtbxFTA.Enabled = false;
                txtbxTotal.Enabled = false;
                txtbxDReb.Enabled = false;
                txtbxOReb.Enabled = false;
                txtbxTReb.Enabled = false;
                txtbxTO.Enabled = false;
                txtbxSTL.Enabled = false;
                txtbxBLK.Enabled = false;

            }
            //offense
            Stats.Plyer_TtlStats.PlayerStats[a, 1] = Convert.ToDouble(txtbxFouls.Text); //fouls
            Stats.Plyer_TtlStats.PlayerStats[a, 2] = Convert.ToDouble(txtbxTwos.Text);//twos
            Stats.Plyer_TtlStats.PlayerStats[a, 3] = Convert.ToDouble(txtbxThree.Text);//three
            Stats.Plyer_TtlStats.PlayerStats[a, 4] = Convert.ToDouble(txtbxFTM.Text);//ftm
            Stats.Plyer_TtlStats.PlayerStats[a, 5] = Convert.ToDouble(txtbxFTA.Text);//fta
            Stats.Plyer_TtlStats.PlayerStats[a, 6] = ((Stats.Plyer_TtlStats.PlayerStats[a, 2] * 2) + (Stats.Plyer_TtlStats.PlayerStats[a, 3] * 3) + (Stats.Plyer_TtlStats.PlayerStats[a, 4] * 1));//total
            txtbxTotal.Text = Stats.Plyer_TtlStats.PlayerStats[a, 6].ToString();//updates player total
            //defense
            Stats.Plyer_TtlStats.PlayerStats[a, 7] = Convert.ToDouble(txtbxDReb.Text); // def. rebounds
            Stats.Plyer_TtlStats.PlayerStats[a, 8] = Convert.ToDouble(txtbxOReb.Text); // off. rebounds
            Stats.Plyer_TtlStats.PlayerStats[a, 9] = (Stats.Plyer_TtlStats.PlayerStats[a, 7] + Stats.Plyer_TtlStats.PlayerStats[a, 8]); // total rebounds
            txtbxTReb.Text = Stats.Plyer_TtlStats.PlayerStats[a, 9].ToString(); // updates total rebounds
            Stats.Plyer_TtlStats.PlayerStats[a, 10] = Convert.ToDouble(txtbxTO.Text); // turnovers
            Stats.Plyer_TtlStats.PlayerStats[a, 11] = Convert.ToDouble(txtbxSTL.Text); // steals
            Stats.Plyer_TtlStats.PlayerStats[a, 12] = Convert.ToDouble(txtbxBLK.Text);// blocks

            //end of year player stats
            Stats.EOY_Stats.EOYPlayerStats[a, 0] = Stats.EOY_Stats.EOYPlayerStats[a, 0] + Stats.Plyer_TtlStats.PlayerStats[a, 0];//GP
            Stats.EOY_Stats.EOYPlayerStats[a, 1] = Stats.EOY_Stats.EOYPlayerStats[a, 1] + Stats.Plyer_TtlStats.PlayerStats[a, 1];//fouls
            Stats.EOY_Stats.EOYPlayerStats[a, 2] = Stats.EOY_Stats.EOYPlayerStats[a, 2] + Stats.Plyer_TtlStats.PlayerStats[a, 2];//twos
            Stats.EOY_Stats.EOYPlayerStats[a, 3] = Stats.EOY_Stats.EOYPlayerStats[a, 3] + Stats.Plyer_TtlStats.PlayerStats[a, 3];//threes
            Stats.EOY_Stats.EOYPlayerStats[a, 4] = Stats.EOY_Stats.EOYPlayerStats[a, 4] + Stats.Plyer_TtlStats.PlayerStats[a, 4];//FM
            Stats.EOY_Stats.EOYPlayerStats[a, 5] = Stats.EOY_Stats.EOYPlayerStats[a, 5] + Stats.Plyer_TtlStats.PlayerStats[a, 5];//FA
            Stats.EOY_Stats.EOYPlayerStats[a, 6] = Stats.EOY_Stats.EOYPlayerStats[a, 6] + Stats.Plyer_TtlStats.PlayerStats[a, 6];//Total

            //end of year player percentages
            Stats.EOY_Stats.EOYPlayerStats[a, 7] = Stats.EOY_Stats.EOYPlayerStats[a, 1] / Stats.GameInformation.GameNumber;//fouls%
            Stats.EOY_Stats.EOYPlayerStats[a, 8] = Stats.EOY_Stats.EOYPlayerStats[a, 2] / Stats.GameInformation.GameNumber;//twos%
            Stats.EOY_Stats.EOYPlayerStats[a, 9] = Stats.EOY_Stats.EOYPlayerStats[a, 3] / Stats.GameInformation.GameNumber;//threes%
            Stats.EOY_Stats.EOYPlayerStats[a, 10] = Stats.EOY_Stats.EOYPlayerStats[a, 4] / Stats.GameInformation.GameNumber;//FM%
            Stats.EOY_Stats.EOYPlayerStats[a, 11] = Stats.EOY_Stats.EOYPlayerStats[a, 5] / Stats.GameInformation.GameNumber;//FA%
            Stats.EOY_Stats.EOYPlayerStats[a, 12] = Stats.EOY_Stats.EOYPlayerStats[a, 4] / Stats.EOY_Stats.EOYPlayerStats[a, 5];//FT%
            Stats.EOY_Stats.EOYPlayerStats[a, 13] = Stats.EOY_Stats.EOYPlayerStats[a, 6] / Stats.GameInformation.GameNumber;//PPG

            //total stats 
            Stats.Plyer_TtlStats.TotalStats[z, 0] = Stats.Plyer_TtlStats.TotalStats[z, 0] + Stats.Plyer_TtlStats.PlayerStats[a, 1];//fouls
            Stats.Plyer_TtlStats.TotalStats[z, 1] = Stats.Plyer_TtlStats.TotalStats[z, 1] + Stats.Plyer_TtlStats.PlayerStats[a, 2];//twos
            Stats.Plyer_TtlStats.TotalStats[z, 2] = Stats.Plyer_TtlStats.TotalStats[z, 2] + Stats.Plyer_TtlStats.PlayerStats[a, 3];//three
            Stats.Plyer_TtlStats.TotalStats[z, 3] = Stats.Plyer_TtlStats.TotalStats[z, 3] + Stats.Plyer_TtlStats.PlayerStats[a, 4];//ftm
            Stats.Plyer_TtlStats.TotalStats[z, 4] = Stats.Plyer_TtlStats.TotalStats[z, 4] + Stats.Plyer_TtlStats.PlayerStats[a, 5];//fta
            Stats.Plyer_TtlStats.TotalStats[z, 5] = Stats.Plyer_TtlStats.TotalStats[z, 5] + Stats.Plyer_TtlStats.PlayerStats[a, 6];//Total

           

            //team win/loss
            txtbxW.Text = Stats.GameInformation.TeamWin.ToString();
            txtbxL.Text = Stats.GameInformation.TeamLoss.ToString();
            //team stats-quarters
            //away w/ updating team total txtbx
            Stats.AwayTeam.AwayPoints[z, 0] = Convert.ToDouble(txtbxAway1Q.Text);
            Stats.AwayTeam.AwayPoints[z, 1] = Convert.ToDouble(txtbxAway2Q.Text);
            Stats.AwayTeam.AwayPoints[z, 2] = Convert.ToDouble(txtbxAway3Q.Text);
            Stats.AwayTeam.AwayPoints[z, 3] = Convert.ToDouble(txtbxAway4Q.Text);
            Stats.AwayTeam.AwayPointsTotal[z] = Stats.AwayTeam.AwayPoints[z, 0] + Stats.AwayTeam.AwayPoints[z, 1] + Stats.AwayTeam.AwayPoints[z, 2] + Stats.AwayTeam.AwayPoints[z, 3];
            txtbxAwayTotal.Text = Stats.AwayTeam.AwayPointsTotal[z].ToString();

            //home w/ updating team total txtbx
            Stats.HomeTeam.HomePoints[z, 0] = Convert.ToDouble(txtbxHome1Q.Text);
            Stats.HomeTeam.HomePoints[z, 1] = Convert.ToDouble(txtbxHome2Q.Text);
            Stats.HomeTeam.HomePoints[z, 2] = Convert.ToDouble(txtbxHome3Q.Text);
            Stats.HomeTeam.HomePoints[z, 3] = Convert.ToDouble(txtbxHome4Q.Text);
            Stats.HomeTeam.HomePointsTotal[z] = Stats.HomeTeam.HomePoints[z, 0] + Stats.HomeTeam.HomePoints[z, 1] + Stats.HomeTeam.HomePoints[z, 2] + Stats.HomeTeam.HomePoints[z, 3];
            txtbxHomeTotal.Text = Stats.HomeTeam.HomePointsTotal[z].ToString();

            Stats.GameInformation.PointDifferential[z] = Stats.HomeTeam.HomePointsTotal[z] - Stats.AwayTeam.AwayPointsTotal[z];

            //W/L txtbx
            if (Stats.HomeTeam.HomePointsTotal[z] < Stats.AwayTeam.AwayPointsTotal[z])
            {
                txtbxResultAwayTeam.Text = "W";
                Stats.GameInformation.AwayResult = txtbxResultAwayTeam.Text;
                txtbxResultHomeTeam.Text = "L";
                Stats.GameInformation.HomeResult = txtbxResultHomeTeam.Text;

            }

            if (Stats.HomeTeam.HomePointsTotal[z] > Stats.AwayTeam.AwayPointsTotal[z])
            {
                txtbxResultHomeTeam.Text = "W";
                Stats.GameInformation.HomeResult = txtbxResultHomeTeam.Text;
                txtbxResultAwayTeam.Text = "L";
                Stats.GameInformation.AwayResult = txtbxResultAwayTeam.Text;
            }

            //game location and DOG & awayteamname
            Stats.GameInformation.GameLocation[z] = txtbxGL.Text;
            Stats.GameInformation.DateofGame[z] = txtbxDoG.Text;
            Information.Team.AwayTeamName[z] = txtbxAwayTeamName.Text;
        }
        #endregion



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatetics = UpdateLimit;
            UpdatingVariables();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
          RTA.AddTeamFile();
          RTA.FinalSavetoFile(z);
            

        }

        private void btnGameInfo_Click(object sender, EventArgs e)
        {
            RTA.AddGameInfo(txtbxW.Text, txtbxL.Text, z);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            CurrentTiming = updatetics--;
            TimerShowBottom.Text = CurrentTiming.ToString();

            if (CurrentTiming == 0)
            {
                UpdatingVariables();
                updatetics = UpdateLimit;
            }
        }
    }

    
    
}