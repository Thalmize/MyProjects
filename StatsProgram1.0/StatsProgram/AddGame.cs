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
        //timer

        double UpdateLimit = 15;
        double updatetics;
        double CurrentTiming;
        ReportTxtArea RTA = new ReportTxtArea();

       
        
        public void AddGame_Load(object sender, EventArgs e)
        {
            
            btnNewGame.Enabled = false;

            //timer initiate
            UpdateTimer.Enabled = true;
            updatetics = UpdateLimit;
            // player information

            Information info = new Information();
              info.OpenTeam();
            info.OpenPlayers();
            Stats.Variable.a = 0;
            Stats.Variable.z = 0;
            txtbxHomeTeamName.Text = Information.Team.teamName + " " + Information.Team.teamNickName;

            txtbxW.Text = Stats.GameInformation.TeamWin.ToString();
            txtbxL.Text = Stats.GameInformation.TeamLoss.ToString();
            Stats.GameInformation.GameNumber = 1;
            txtbxGameNum.Text = Stats.GameInformation.GameNumber.ToString();
            txtbxTeamRoster.Text = Information.Team.RosterName;
            txtbxPlayer.Text = Information.Players.FirstName[Stats.Variable.a] + " " + Information.Players.LastName[Stats.Variable.a];
            txtbxNumber.Text = Information.Players.PlayerNum[Stats.Variable.a];
            
        }
        
        
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Stats.Variable.z++;
            Stats.Variable.a = 0;
            Stats.GameInformation.GameNumber++;
            txtbxGameNum.Text = Stats.GameInformation.GameNumber.ToString();
            txtbxPlayer.Text = Information.Players.FirstName[Stats.Variable.a] + " " + Information.Players.LastName[Stats.Variable.a];
            txtbxNumber.Text = Information.Players.PlayerNum[Stats.Variable.a];

            ResetboxesNewGame();
            btnGameInfo.Enabled = true;
            btnNewGame.Enabled = false;
        }

        #region Reset Text Boxes

        private void ResetboxesNewGame()
        {
            //clears out txtbxs
            txtbxFouls.Text = "0";
            txtbxTwos.Text = "0";
            txtbxThree.Text = "0";
            txtbxFTM.Text = "0";
            txtbxFTA.Text = "0";
            txtbxTotal.Text = "0";
            txtbxDReb.Text = "0";
            txtbxOReb.Text = "0";
            txtbxTReb.Text = "0";
            txtbxTO.Text = "0";
            txtbxSTL.Text = "0";
            txtbxBLK.Text = "0";
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

        public void ResetBoxesNewPlayer()
        {
            //clears out txtbxs
            txtbxFouls.Text = "0";
            txtbxTwos.Text = "0";
            txtbxThree.Text = "0";
            txtbxFTM.Text = "0";
            txtbxFTA.Text = "0";
            txtbxTotal.Text = "0";
            txtbxDReb.Text = "0";
            txtbxOReb.Text = "0";
            txtbxTReb.Text = "0";
            txtbxTO.Text = "0";
            txtbxSTL.Text = "0";
            txtbxBLK.Text = "0";
        }
        #endregion

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Stats.Variable.a++;

            ResetBoxesNewPlayer();
            txtbxPlayer.Text = Information.Players.FirstName[Stats.Variable.a] + " " + Information.Players.LastName[Stats.Variable.a];
            txtbxNumber.Text = Information.Players.PlayerNum[Stats.Variable.a];
           

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
                Stats.Plyer_TtlStats.DidYouPlay = true;

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
                Stats.Plyer_TtlStats.DidYouPlay = false;
            }
           
            //team win/loss
            txtbxW.Text = Stats.GameInformation.TeamWin.ToString();
            txtbxL.Text = Stats.GameInformation.TeamLoss.ToString();
            //team stats-quarters

            StoringStats.TeamGame(txtbxAway1Q.Text, txtbxAway2Q.Text, txtbxAway3Q.Text, txtbxAway4Q.Text, txtbxAwayTotal.Text, txtbxHome1Q.Text, txtbxHome2Q.Text, txtbxHome3Q.Text, txtbxHome4Q.Text, txtbxHomeTotal.Text);

            StoringStats.PlayerGame(txtbxFouls.Text, txtbxTwos.Text, txtbxThree.Text, txtbxFTM.Text, txtbxFTA.Text, txtbxTotal.Text, txtbxDReb.Text, txtbxOReb.Text, txtbxTReb.Text, txtbxTO.Text, txtbxSTL.Text, txtbxBLK.Text);

            txtbxTotal.Text = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 6].ToString();
            txtbxTReb.Text = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 9].ToString();

            txtbxAwayTotal.Text = Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z].ToString();
            txtbxHomeTotal.Text = Stats.HomeTeam.HomePointsTotal[Stats.Variable.z].ToString();

            StoringStats.PlayerTotalGame();
            StoringStats.PlayerEOY();
            StoringStats.PlayerPercentages();
            StoringStats.TeamEOY();

            Stats.GameInformation.PointDifferential[Stats.Variable.z] = Stats.HomeTeam.HomePointsTotal[Stats.Variable.z] - Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z];

            //W/L txtbx
            if (Stats.HomeTeam.HomePointsTotal[Stats.Variable.z] < Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z])
            {
                txtbxResultAwayTeam.Text = "W";
                Stats.GameInformation.AwayResult = txtbxResultAwayTeam.Text;
                txtbxResultHomeTeam.Text = "L";
                Stats.GameInformation.HomeResult = txtbxResultHomeTeam.Text;

            }

            if (Stats.HomeTeam.HomePointsTotal[Stats.Variable.z] > Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z])
            {
                txtbxResultHomeTeam.Text = "W";
                Stats.GameInformation.HomeResult = txtbxResultHomeTeam.Text;
                txtbxResultAwayTeam.Text = "L";
                Stats.GameInformation.AwayResult = txtbxResultAwayTeam.Text;
            }

            //game location and DOG & awayteamname
            Stats.GameInformation.GameLocation[Stats.Variable.z] = txtbxGL.Text;
            Stats.GameInformation.DateofGame[Stats.Variable.z] = txtbxDoG.Text;
            Information.Team.AwayTeamName[Stats.Variable.z] = txtbxAwayTeamName.Text;
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
          btnNewGame.Enabled = true;
        }

        private void btnGameInfo_Click(object sender, EventArgs e)
        {
            btnGameInfo.Enabled = false;
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