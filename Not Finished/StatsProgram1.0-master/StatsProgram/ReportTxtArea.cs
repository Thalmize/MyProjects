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
    public partial class ReportTxtArea : Form
    {
        public ReportTxtArea()
        {
            InitializeComponent();
        }
        public static int a;

        private void ReportTxtArea_Load(object sender, EventArgs e)
        {

        }

        private void ClearTxtboxes()
        {
            txtOutputIndGame.Clear();
            txtOutputIndOverall.Clear();
            txtOutputTeam.Clear();
            txtOutputTeambyGame.Clear();
            txtOutputTeamOverall.Clear();
        }

        #region AddPlayersToFile
        public void AddPlayersFile()
        {
            
            
            txtOutputIndGame.AppendText(" ");
            txtOutputIndGame.AppendText(Information.Players.PlayerPos[a] + "   " + Information.Players.PlayerNum[a] + "    ");
            string playername = Information.Players.FirstName[a] + " " + Information.Players.LastName[a];
            int len = 0;
            int x = 0;
            len = playername.Length;

            while (x < len)
            {
                var temp = playername.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("   ");

            //player numbers
            //fouls
            if (Stats.Plyer_TtlStats.PlayerStats[a, 1] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 1].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 1].ToString());
            txtOutputIndGame.AppendText("   ");
            //twos
            if (Stats.Plyer_TtlStats.PlayerStats[a, 2] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 2].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 2].ToString());
            txtOutputIndGame.AppendText("   ");
            //threes
            if (Stats.Plyer_TtlStats.PlayerStats[a, 3] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 3].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 3].ToString());
            txtOutputIndGame.AppendText("   ");
            //FM
            if (Stats.Plyer_TtlStats.PlayerStats[a, 4] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 4].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 4].ToString());
            txtOutputIndGame.AppendText(" - ");
            //FA
            if (Stats.Plyer_TtlStats.PlayerStats[a, 5] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 5].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 5].ToString());
            txtOutputIndGame.AppendText("      ");
            //Total
            if (Stats.Plyer_TtlStats.PlayerStats[a, 6] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.PlayerStats[a, 6].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.PlayerStats[a, 6].ToString());

            txtOutputIndGame.AppendText(Environment.NewLine);

        }
        #endregion

        #region AddTeamToFile
        public void AddTeamFile()
        {
            int b = 0;
            int gamenum = 1;
            //txtoutputTeambygame
            while (b < Stats.GameInformation.GameNumber)
            {
                if (gamenum <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + gamenum.ToString());
                }
                else txtOutputTeambyGame.AppendText(gamenum.ToString());
                txtOutputTeambyGame.AppendText("   ");

                string team = Information.Team.AwayTeamName[b];
                int len = 0;
                int x = 0;
                len = team.Length;

                while (x < len)
                {
                    var temp = team.ToCharArray();
                    txtOutputTeambyGame.AppendText(temp[x].ToString());
                    x++;
                }
                while (len < 30)
                {
                    txtOutputTeambyGame.AppendText(" ");
                    len++;
                }

                txtOutputTeambyGame.AppendText("   ");

                //fouls
                if (Stats.Plyer_TtlStats.TotalStats[b, 0] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 0].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 0].ToString());
                txtOutputTeambyGame.AppendText("   ");

                //twos
                if (Stats.Plyer_TtlStats.TotalStats[b, 1] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 1].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 1].ToString());
                txtOutputTeambyGame.AppendText("   ");

                //threes
                if (Stats.Plyer_TtlStats.TotalStats[b, 2] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 2].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 2].ToString());
                txtOutputTeambyGame.AppendText("   ");

                //FM
                if (Stats.Plyer_TtlStats.TotalStats[b, 3] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 3].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 3].ToString());
                txtOutputTeambyGame.AppendText(" - ");

                //FA
                if (Stats.Plyer_TtlStats.TotalStats[b, 4] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 4].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 4].ToString());
                txtOutputTeambyGame.AppendText("     ");

                //Total
                if (Stats.Plyer_TtlStats.TotalStats[b, 5] <= 9)
                {
                    txtOutputTeambyGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[b, 5].ToString());
                }
                else txtOutputTeambyGame.AppendText(Stats.Plyer_TtlStats.TotalStats[b, 5].ToString());


                txtOutputTeambyGame.AppendText(Environment.NewLine);
                b++;
                gamenum++;
            }
        }
        #endregion

        #region AddGameInfo
        public void AddGameInfo(string win, string loss, int z)
        {
            //adding to record W/L
            if (Stats.HomeTeam.HomePointsTotal[z] < Stats.AwayTeam.AwayPointsTotal[z])
            {
                Stats.GameInformation.TeamLoss++;
            }

            if (Stats.HomeTeam.HomePointsTotal[z] > Stats.AwayTeam.AwayPointsTotal[z])
            {
                Stats.GameInformation.TeamWin++;
            }
            win = Stats.GameInformation.TeamWin.ToString();
            loss = Stats.GameInformation.TeamLoss.ToString();
            //txtoutputindgame
            //line 1
            txtOutputIndGame.AppendText("                          ");
            txtOutputIndGame.AppendText("Official Game Stats- Single Game");
            txtOutputIndGame.AppendText(Environment.NewLine);

            //line 2
            txtOutputIndGame.AppendText("                        ");
            txtOutputIndGame.AppendText(Information.Team.teamName + " " + Information.Team.teamNickName + " - " + Information.Team.RosterName);
            txtOutputIndGame.AppendText(Environment.NewLine);

            //line 3
            txtOutputIndGame.AppendText("                           ");
            txtOutputIndGame.AppendText("Game #: " + Stats.GameInformation.GameNumber + "   " + "Record: " + Stats.GameInformation.TeamWin.ToString() + "-" + Stats.GameInformation.TeamLoss.ToString());
            txtOutputIndGame.AppendText(Environment.NewLine);

            //line 4
            txtOutputIndGame.AppendText("              ");
            txtOutputIndGame.AppendText("Date of Game: " + Stats.GameInformation.DateofGame[z] + "   " + "Game Location: " + Stats.GameInformation.GameLocation[z]);
            txtOutputIndGame.AppendText(Environment.NewLine);

            //line 5
            txtOutputIndGame.AppendText("Team Stats");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText(Environment.NewLine);

            // team Header
            txtOutputIndGame.AppendText("---------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("W/L" + "   ");

            string teamlbl = "Team Name";
            int len = 0;
            len = teamlbl.Length;
            int x = 0;
            while (x < len)
            {
                var temp = teamlbl.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("    " + "Q1" + "     " + "Q2" + "     " + "Q3" + "     " + "Q4" + "       " + "Total");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("---------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);

            txtOutputIndGame.AppendText(" " + Stats.GameInformation.AwayResult + "    ");

            string AT = Information.Team.AwayTeamName[z];
            len = 0;
            x = 0;
            len = AT.Length;

            while (x < len)
            {
                var temp = AT.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("    ");

            //away team qtrs & total
            //q1
            if (Stats.AwayTeam.AwayPoints[z, 0] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.AwayTeam.AwayPoints[z, 0].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.AwayTeam.AwayPoints[z, 0].ToString());
            txtOutputIndGame.AppendText("     ");
            //q2
            if (Stats.AwayTeam.AwayPoints[z, 1] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.AwayTeam.AwayPoints[z, 1].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.AwayTeam.AwayPoints[z, 1].ToString());
            txtOutputIndGame.AppendText("     ");
            //q3
            if (Stats.AwayTeam.AwayPoints[z, 2] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.AwayTeam.AwayPoints[z, 2].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.AwayTeam.AwayPoints[z, 2].ToString());
            txtOutputIndGame.AppendText("     ");
            //q4
            if (Stats.AwayTeam.AwayPoints[z, 3] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.AwayTeam.AwayPoints[z, 3].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.AwayTeam.AwayPoints[z, 3].ToString());
            txtOutputIndGame.AppendText("        ");
            //total
            if (Stats.AwayTeam.AwayPointsTotal[z] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.AwayTeam.AwayPointsTotal[z].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.AwayTeam.AwayPointsTotal[z].ToString());

            txtOutputIndGame.AppendText(Environment.NewLine);

            //home team
            txtOutputIndGame.AppendText(" " + Stats.GameInformation.HomeResult + "    ");

            string HT = Information.Team.HomeTeamName;
            len = 0;
            x = 0;
            len = HT.Length;

            while (x < len)
            {
                var temp = HT.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("    ");
            //home team qtrs & total
            //q1
            if (Stats.HomeTeam.HomePoints[z, 0] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.HomeTeam.HomePoints[z, 0].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.HomeTeam.HomePoints[z, 0].ToString());
            txtOutputIndGame.AppendText("     ");
            //q2
            if (Stats.HomeTeam.HomePoints[z, 1] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.HomeTeam.HomePoints[z, 1].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.HomeTeam.HomePoints[z, 1].ToString());
            txtOutputIndGame.AppendText("     ");
            //q3
            if (Stats.HomeTeam.HomePoints[z, 2] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.HomeTeam.HomePoints[z, 2].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.HomeTeam.HomePoints[z, 2].ToString());
            txtOutputIndGame.AppendText("     ");
            //q4
            if (Stats.HomeTeam.HomePoints[z, 3] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.HomeTeam.HomePoints[z, 3].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.HomeTeam.HomePoints[z, 3].ToString());
            txtOutputIndGame.AppendText("        ");
            //total
            if (Stats.HomeTeam.HomePointsTotal[z] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.HomeTeam.HomePointsTotal[z].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.HomeTeam.HomePointsTotal[z].ToString());

            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("---------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText(Environment.NewLine);

            //player header
            txtOutputIndGame.AppendText("Player Stats");
            txtOutputIndGame.AppendText(Environment.NewLine);

            txtOutputIndGame.AppendText("----------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);

            txtOutputIndGame.AppendText("Pos" + "   " + "##" + "   ");

            string playerlbl = "Player";
            len = 0;
            x = 0;
            len = playerlbl.Length;

            while (x < len)
            {
                var temp = playerlbl.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("   ");
            txtOutputIndGame.AppendText("PF" + "   " + "2s" + "   " + "3s" + "   " + "FM" + " - " + "FA" + "     " + "Total");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("----------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);

            //txtoutTeamIndGame
            //line 1

            txtOutputTeambyGame.AppendText("                          ");
            txtOutputTeambyGame.AppendText("Official Game Stats- Team by Game");
            txtOutputTeambyGame.AppendText(Environment.NewLine);

            //line 2
            txtOutputTeambyGame.AppendText("                        ");
            txtOutputTeambyGame.AppendText(Information.Team.teamName + " " + Information.Team.teamNickName + " - " + Information.Team.RosterName);
            txtOutputTeambyGame.AppendText(Environment.NewLine);

            //line 3
            txtOutputTeambyGame.AppendText("                           ");
            txtOutputTeambyGame.AppendText("Games Played: " + Stats.GameInformation.GameNumber + "   " + "Record: " + Stats.GameInformation.TeamWin + "-" + Stats.GameInformation.TeamLoss);
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            //line 4
            txtOutputTeambyGame.AppendText("Stats by Game");
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            txtOutputTeambyGame.AppendText("-----------------------------------------------------------------------");
            txtOutputTeambyGame.AppendText(Environment.NewLine);

            //team header txtoutputeambygame

            txtOutputTeambyGame.AppendText("G#" + "   ");

            string lblteam = "Team";
            len = 0;
            x = 0;
            len = lblteam.Length;

            while (x < len)
            {
                var temp = lblteam.ToCharArray();
                txtOutputTeambyGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeambyGame.AppendText(" ");
                len++;
            }
            txtOutputTeambyGame.AppendText("   ");

            txtOutputTeambyGame.AppendText("PF" + "   " + "2s" + "   " + "3s" + "   " + "FM" + " - " + "FA" + "    " + "Total");
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            txtOutputTeambyGame.AppendText("-----------------------------------------------------------------------");
            txtOutputTeambyGame.AppendText(Environment.NewLine);

            // loop of games
            //see addplayertofile



        }
        #endregion

        #region FinalSave

        public void FinalSavetoFile(int z)
        {
            //end of year stats
            Stats.EOY_Stats.EOYTeamStats[0] = Stats.EOY_Stats.EOYTeamStats[0] + Stats.Plyer_TtlStats.TotalStats[z, 0];//fouls
            Stats.EOY_Stats.EOYTeamStats[1] = Stats.EOY_Stats.EOYTeamStats[1] + Stats.Plyer_TtlStats.TotalStats[z, 1];//twos
            Stats.EOY_Stats.EOYTeamStats[2] = Stats.EOY_Stats.EOYTeamStats[2] + Stats.Plyer_TtlStats.TotalStats[z, 2];//three
            Stats.EOY_Stats.EOYTeamStats[3] = Stats.EOY_Stats.EOYTeamStats[3] + Stats.Plyer_TtlStats.TotalStats[z, 3];//ftm
            Stats.EOY_Stats.EOYTeamStats[4] = Stats.EOY_Stats.EOYTeamStats[4] + Stats.Plyer_TtlStats.TotalStats[z, 4];//fta
            Stats.EOY_Stats.EOYTeamStats[5] = Stats.EOY_Stats.EOYTeamStats[5] + Stats.Plyer_TtlStats.TotalStats[z, 5];//total
            Stats.EOY_Stats.EOYTeamStats[6] = Stats.EOY_Stats.EOYTeamStats[0] / Stats.GameInformation.GameNumber;//fouls%
            Stats.EOY_Stats.EOYTeamStats[7] = Stats.EOY_Stats.EOYTeamStats[1] / Stats.GameInformation.GameNumber;//twos%
            Stats.EOY_Stats.EOYTeamStats[8] = Stats.EOY_Stats.EOYTeamStats[2] / Stats.GameInformation.GameNumber;//three%
            Stats.EOY_Stats.EOYTeamStats[9] = Stats.EOY_Stats.EOYTeamStats[4] / Stats.GameInformation.GameNumber;//ftm%
            Stats.EOY_Stats.EOYTeamStats[10] = Stats.EOY_Stats.EOYTeamStats[5] / Stats.GameInformation.GameNumber;//fta%
            Stats.EOY_Stats.EOYTeamStats[11] = ((Stats.EOY_Stats.EOYTeamStats[3] / Stats.EOY_Stats.EOYTeamStats[4]) * 100);//FT%

            //end of year qtrs & total away
            Stats.EOY_Stats.EOYAwayPoints[0] = Stats.EOY_Stats.EOYAwayPoints[0] + Stats.AwayTeam.AwayPoints[z, 0];//Q1
            Stats.EOY_Stats.EOYAwayPoints[1] = Stats.EOY_Stats.EOYAwayPoints[1] + Stats.AwayTeam.AwayPoints[z, 1];//Q2
            Stats.EOY_Stats.EOYAwayPoints[2] = Stats.EOY_Stats.EOYAwayPoints[2] + Stats.AwayTeam.AwayPoints[z, 2];//Q3
            Stats.EOY_Stats.EOYAwayPoints[3] = Stats.EOY_Stats.EOYAwayPoints[3] + Stats.AwayTeam.AwayPoints[z, 3];//Q4
            Stats.EOY_Stats.EOYAwayPoints[4] = Stats.EOY_Stats.EOYAwayPoints[4] + Stats.AwayTeam.AwayPointsTotal[z];//Total
            Stats.EOY_Stats.EOYAwayPoints[5] = Stats.EOY_Stats.EOYAwayPoints[0] / Stats.GameInformation.GameNumber;//Q1%
            Stats.EOY_Stats.EOYAwayPoints[6] = Stats.EOY_Stats.EOYAwayPoints[1] / Stats.GameInformation.GameNumber;//Q2%
            Stats.EOY_Stats.EOYAwayPoints[7] = Stats.EOY_Stats.EOYAwayPoints[2] / Stats.GameInformation.GameNumber;//Q3%
            Stats.EOY_Stats.EOYAwayPoints[8] = Stats.EOY_Stats.EOYAwayPoints[3] / Stats.GameInformation.GameNumber;//Q4%
            Stats.EOY_Stats.EOYAwayPoints[9] = Stats.EOY_Stats.EOYAwayPoints[4] / Stats.GameInformation.GameNumber;//Total%
                                                                                                                   //end of year qtrs & total Home
            Stats.EOY_Stats.EOYHomePoints[0] = Stats.EOY_Stats.EOYHomePoints[0] + Stats.HomeTeam.HomePoints[z, 0];//Q1
            Stats.EOY_Stats.EOYHomePoints[1] = Stats.EOY_Stats.EOYHomePoints[1] + Stats.HomeTeam.HomePoints[z, 1];//Q2
            Stats.EOY_Stats.EOYHomePoints[2] = Stats.EOY_Stats.EOYHomePoints[2] + Stats.HomeTeam.HomePoints[z, 2];//Q3
            Stats.EOY_Stats.EOYHomePoints[3] = Stats.EOY_Stats.EOYHomePoints[3] + Stats.HomeTeam.HomePoints[z, 3];//Q4
            Stats.EOY_Stats.EOYHomePoints[4] = Stats.EOY_Stats.EOYHomePoints[4] + Stats.HomeTeam.HomePointsTotal[z];//Total
            Stats.EOY_Stats.EOYHomePoints[5] = Stats.EOY_Stats.EOYHomePoints[0] / Stats.GameInformation.GameNumber;//Q1%
            Stats.EOY_Stats.EOYHomePoints[6] = Stats.EOY_Stats.EOYHomePoints[1] / Stats.GameInformation.GameNumber;//Q2%
            Stats.EOY_Stats.EOYHomePoints[7] = Stats.EOY_Stats.EOYHomePoints[2] / Stats.GameInformation.GameNumber;//Q3%
            Stats.EOY_Stats.EOYHomePoints[8] = Stats.EOY_Stats.EOYHomePoints[3] / Stats.GameInformation.GameNumber;//Q4%
            Stats.EOY_Stats.EOYHomePoints[9] = Stats.EOY_Stats.EOYHomePoints[4] / Stats.GameInformation.GameNumber;//total%


            //txtoutputindgame total
            txtOutputIndGame.AppendText("----------------------------------------------------------------------------");
            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("           ");

            string Totallbll = "Total";
            int len = 0;
            int x = 0;
            len = Totallbll.Length;

            while (x < len)
            {
                var temp = Totallbll.ToCharArray();
                txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }

            while (len < 30)
            {
                txtOutputIndGame.AppendText(" ");
                len++;
            }
            txtOutputIndGame.AppendText("   ");
            //fouls
            if (Stats.Plyer_TtlStats.TotalStats[z, 0] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 0].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 0].ToString());
            txtOutputIndGame.AppendText("   ");

            //2s
            if (Stats.Plyer_TtlStats.TotalStats[z, 1] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 1].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 1].ToString());
            txtOutputIndGame.AppendText("   ");

            //3s
            if (Stats.Plyer_TtlStats.TotalStats[z, 2] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 2].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 2].ToString());
            txtOutputIndGame.AppendText("   ");

            //FM
            if (Stats.Plyer_TtlStats.TotalStats[z, 3] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 3].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 3].ToString());
            txtOutputIndGame.AppendText(" - ");

            //FA
            if (Stats.Plyer_TtlStats.TotalStats[z, 4] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 4].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 4].ToString());
            txtOutputIndGame.AppendText("      ");

            //Total
            if (Stats.Plyer_TtlStats.TotalStats[z, 5] <= 9)
            {
                txtOutputIndGame.AppendText("0" + Stats.Plyer_TtlStats.TotalStats[z, 5].ToString());
            }
            else txtOutputIndGame.AppendText(Stats.Plyer_TtlStats.TotalStats[z, 5].ToString());

            txtOutputIndGame.AppendText(Environment.NewLine);
            txtOutputIndGame.AppendText("----------------------------------------------------------------------------");

            //txtoutputteambygame


            txtOutputTeambyGame.AppendText("-----------------------------------------------------------------------");
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            txtOutputTeambyGame.AppendText("     ");

            string lbl = "Total";
            len = 0;
            x = 0;
            len = lbl.Length;

            while (x < len)
            {
                var temp = lbl.ToCharArray();
                txtOutputTeambyGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeambyGame.AppendText(" ");
                len++;
            }

            txtOutputTeambyGame.AppendText("   ");

            //fouls
            if (Stats.EOY_Stats.EOYTeamStats[0] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[0].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[0].ToString());
            txtOutputTeambyGame.AppendText("   ");

            //twos
            if (Stats.EOY_Stats.EOYTeamStats[1] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[1].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[1].ToString());
            txtOutputTeambyGame.AppendText("   ");

            //three
            if (Stats.EOY_Stats.EOYTeamStats[2] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[2].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[2].ToString());
            txtOutputTeambyGame.AppendText("   ");

            //FM
            if (Stats.EOY_Stats.EOYTeamStats[3] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[3].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[3].ToString());
            txtOutputTeambyGame.AppendText(" - ");

            //FA
            if (Stats.EOY_Stats.EOYTeamStats[4] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[4].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[4].ToString());
            txtOutputTeambyGame.AppendText("     ");

            //Total
            if (Stats.EOY_Stats.EOYTeamStats[5] <= 9)
            {
                txtOutputTeambyGame.AppendText("0" + Stats.EOY_Stats.EOYTeamStats[5].ToString());
            }
            else txtOutputTeambyGame.AppendText(Stats.EOY_Stats.EOYTeamStats[5].ToString());
            txtOutputTeambyGame.AppendText(Environment.NewLine);
            txtOutputTeambyGame.AppendText("-----------------------------------------------------------------------");
            txtOutputTeambyGame.AppendText(Environment.NewLine);

            //txtoutputteamoverall
            //line1
            txtOutputTeamOverall.AppendText("                          ");
            txtOutputTeamOverall.AppendText("Official Game Stats- Team Overall");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //line 2
            txtOutputTeamOverall.AppendText("                        ");
            txtOutputTeamOverall.AppendText(Information.Team.teamName + " " + Information.Team.teamNickName + " - " + Information.Team.RosterName);
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //line 3
            txtOutputTeamOverall.AppendText("                           ");
            txtOutputTeamOverall.AppendText("Games Played: " + Stats.GameInformation.GameNumber + "   " + "Record: " + Stats.GameInformation.TeamWin + "-" + Stats.GameInformation.TeamLoss);
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            //team overall header
            //team scoring by quarter
            txtOutputTeamOverall.AppendText("Team Scoring by Quarter");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("----------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //team qtrs and percentages
            txtOutputTeamOverall.AppendText("          ");
            txtOutputTeamOverall.AppendText("Q1" + "    " + "Q2" + "    " + "Q3" + "    " + "Q4" + "    " + "Total" + "   ");
            txtOutputTeamOverall.AppendText("Q1%" + "    " + "Q2%" + "    " + "Q3%" + "    " + "Q4%" + "    " + "Total%");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            string TSUS = "OGW";
            len = 0;
            x = 0;
            len = TSUS.Length;

            while (x < len)
            {
                var temp = TSUS.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 6)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }

            txtOutputTeamOverall.AppendText("    ");

            // Q1
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYHomePoints[0]));
            txtOutputTeamOverall.AppendText("    ");
            //Q2
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYHomePoints[1]));
            txtOutputTeamOverall.AppendText("    ");
            //Q3
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYHomePoints[2]));
            txtOutputTeamOverall.AppendText("    ");
            //Q4
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYHomePoints[3]));
            txtOutputTeamOverall.AppendText("     ");
            //Total
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYHomePoints[4]));
            txtOutputTeamOverall.AppendText("     ");
            //Q1%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.##}", Stats.EOY_Stats.EOYHomePoints[5]));
            txtOutputTeamOverall.AppendText("    ");
            //Q2%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.##}", Stats.EOY_Stats.EOYHomePoints[6]));
            txtOutputTeamOverall.AppendText("    ");
            //Q3%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.##}", Stats.EOY_Stats.EOYHomePoints[7]));
            txtOutputTeamOverall.AppendText("    ");
            //Q4%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.##}", Stats.EOY_Stats.EOYHomePoints[8]));
            txtOutputTeamOverall.AppendText("    ");
            //Total%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.##}", Stats.EOY_Stats.EOYHomePoints[9]));
            txtOutputTeamOverall.AppendText("    ");

            txtOutputTeamOverall.AppendText(Environment.NewLine);
            string notus = "Field";
            len = 0;
            x = 0;
            len = notus.Length;

            while (x < len)
            {
                var temp = notus.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 6)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }

            txtOutputTeamOverall.AppendText("    ");

            //Q1
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYAwayPoints[0]));
            txtOutputTeamOverall.AppendText("    ");
            //Q2
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYAwayPoints[1]));
            txtOutputTeamOverall.AppendText("    ");
            //Q3
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYAwayPoints[2]));
            txtOutputTeamOverall.AppendText("    ");
            //Q4
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYAwayPoints[3]));
            txtOutputTeamOverall.AppendText("     ");
            //Total
            txtOutputTeamOverall.AppendText(String.Format("{0:###}", Stats.EOY_Stats.EOYAwayPoints[4]));
            txtOutputTeamOverall.AppendText("     ");
            //Q1%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYAwayPoints[5]));
            txtOutputTeamOverall.AppendText("    ");
            //Q2%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYAwayPoints[6]));
            txtOutputTeamOverall.AppendText("    ");
            //Q3%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYAwayPoints[7]));
            txtOutputTeamOverall.AppendText("    ");
            //Q4%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYAwayPoints[8]));
            txtOutputTeamOverall.AppendText("     ");
            //Total%
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYAwayPoints[9]));
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //team stats breakdown
            txtOutputTeamOverall.AppendText("Team Stats Breakdown");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-----------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            string templbl = "Team";
            x = 0;
            len = 0;

            len = templbl.Length;
            while (x < len)
            {
                var temp = templbl.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }
            txtOutputTeamOverall.AppendText("   ");

            txtOutputTeamOverall.AppendText("GP" + "   " + "PF" + "   " + "2s" + "   " + "3s" + "   " + "FM" + " - " + "FA" + "   " + "Total");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-----------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            // Your team   

            string YT = Information.Team.teamName;
            x = 0;
            len = 0;
            len = YT.Length;

            while (x < len)
            {
                var temp = YT.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }
            txtOutputTeamOverall.AppendText("   ");

            txtOutputTeamOverall.AppendText(Stats.GameInformation.GameNumber.ToString());
            txtOutputTeamOverall.AppendText("   ");

            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[0].ToString());
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[1].ToString());
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[2].ToString());
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[3].ToString());
            txtOutputTeamOverall.AppendText(" - ");
            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[4].ToString());
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(Stats.EOY_Stats.EOYTeamStats[5].ToString());
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-----------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //team stats breakdown-Percentage
            txtOutputTeamOverall.AppendText("Team Stats Breakdown-Percentage");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            string lblteam = "Team";
            len = 0;
            x = 0;

            len = lblteam.Length;
            while (x < len)
            {
                var temp = lblteam.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }
            txtOutputTeamOverall.AppendText("   ");

            txtOutputTeamOverall.AppendText("GP" + "   " + "PF%" + "   " + "2s%" + "   " + "3s%" + "   " + "FM%" + " - " + "FA%" + "   " + "FT%" + "   " + "Total");
            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            string US = Information.Team.teamName;
            len = 0;
            x = 0;
            len = US.Length;

            while (x < len)
            {
                var temp = US.ToCharArray();
                txtOutputTeamOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputTeamOverall.AppendText(" ");
                len++;
            }
            txtOutputTeamOverall.AppendText("   ");

            txtOutputTeamOverall.AppendText(Stats.GameInformation.GameNumber.ToString()); //GP
            txtOutputTeamOverall.AppendText("    ");

            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[6]));//fouls
            txtOutputTeamOverall.AppendText("    ");
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[7]));//2s
            txtOutputTeamOverall.AppendText("    ");
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[8]));//3s
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[9]));//ftm
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[10]));//fta
            txtOutputTeamOverall.AppendText("   ");
            txtOutputTeamOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYTeamStats[11]));//ft%

            txtOutputTeamOverall.AppendText(Environment.NewLine);
            txtOutputTeamOverall.AppendText("-------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            //txtoutputindoverall
            txtOutputIndOverall.AppendText("                        ");
            txtOutputIndOverall.AppendText("Official Game Stats-Final Individual Stats");
            txtOutputIndOverall.AppendText(Environment.NewLine);

            //line 2
            txtOutputIndOverall.AppendText("                           ");
            txtOutputIndOverall.AppendText("Games Played: " + Stats.GameInformation.GameNumber);
            txtOutputIndOverall.AppendText("   " + "Record: " + Stats.GameInformation.TeamWin.ToString() + "-" + Stats.GameInformation.TeamLoss.ToString());
            txtOutputIndOverall.AppendText(Environment.NewLine);

            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText("Player Stats-Overall");
            txtOutputIndOverall.AppendText(Environment.NewLine);

            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------");
            txtOutputIndOverall.AppendText(Environment.NewLine);

            txtOutputIndOverall.AppendText("Pos" + "   " + "##" + "   ");

            string playerlbl = "Player";
            len = 0;
            x = 0;
            len = playerlbl.Length;

            while (x < len)
            {
                var temp = playerlbl.ToCharArray();
                txtOutputIndOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndOverall.AppendText(" ");
                len++;
            }

            txtOutputIndOverall.AppendText("   ");

            txtOutputIndOverall.AppendText("GP" + "   " + "PF" + "   " + "2s" + "   " + "3s" + "   " + "FM" + " - " + "FA" + "     " + "Total");
            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------");
            txtOutputIndOverall.AppendText(Environment.NewLine);

            //player stats by player
            int d = 0;

            while (d < Information.Team.RosterCount)
            {
                txtOutputIndOverall.AppendText(" " + Information.Players.PlayerPos[d] + "    " + Information.Players.PlayerNum[d] + "   ");

                string name = Information.Players.FirstName[d] + " " + Information.Players.LastName[d];
                len = 0;
                x = 0;
                len = name.Length;

                while (x < len)
                {
                    var temp = name.ToCharArray();
                    txtOutputIndOverall.AppendText(temp[x].ToString());
                    x++;
                }
                while (len < 30)
                {
                    txtOutputIndOverall.AppendText(" ");
                    len++;
                }
                txtOutputIndOverall.AppendText("   ");
                //GP
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 0]));
                txtOutputIndOverall.AppendText("   ");
                //Fouls
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 1]));
                txtOutputIndOverall.AppendText("   ");
                //twos
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 2]));
                txtOutputIndOverall.AppendText("   ");
                //threes
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 3]));
                txtOutputIndOverall.AppendText("   ");
                //FM
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 4]));
                txtOutputIndOverall.AppendText("   ");
                //FA
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 5]));
                txtOutputIndOverall.AppendText("      ");
                //Total
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 6]));
                txtOutputIndOverall.AppendText(Environment.NewLine);
                d++;
            }
            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------");
            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText("Player Percentages");
            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------------");
            txtOutputIndOverall.AppendText(Environment.NewLine);

            // player percentages
            txtOutputIndOverall.AppendText("Pos" + "   " + "##" + "   ");

            playerlbl = "Player";
            len = 0;
            x = 0;
            len = playerlbl.Length;

            while (x < len)
            {
                var temp = playerlbl.ToCharArray();
                txtOutputIndOverall.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                txtOutputIndOverall.AppendText(" ");
                len++;
            }

            txtOutputIndOverall.AppendText("   ");

            txtOutputIndOverall.AppendText("GP" + "   " + "PF" + "   " + "2s" + "   " + "3s" + "   " + "FM" + " - " + "FA" + "     " + "FT" + "   " + "Total");
            txtOutputIndOverall.AppendText(Environment.NewLine);
            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------------");
            txtOutputTeamOverall.AppendText(Environment.NewLine);

            d = 0;
            while (d < Information.Team.RosterCount)
            {
                txtOutputIndOverall.AppendText(" " + Information.Players.PlayerPos[d] + "    " + Information.Players.PlayerNum[d] + "   ");

                string name = Information.Players.FirstName[d] + " " + Information.Players.LastName[d];
                len = 0;
                x = 0;
                len = name.Length;

                while (x < len)
                {
                    var temp = name.ToCharArray();
                    txtOutputIndOverall.AppendText(temp[x].ToString());
                    x++;
                }
                while (len < 30)
                {
                    txtOutputIndOverall.AppendText(" ");
                    len++;
                }

                txtOutputTeamOverall.AppendText("   ");

                //GP%
                txtOutputIndOverall.AppendText(String.Format("{0:##}", Stats.EOY_Stats.EOYPlayerStats[d, 0]));
                txtOutputIndOverall.AppendText("   ");
                //Fouls%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 7]));
                txtOutputIndOverall.AppendText("   ");
                //twos%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 8]));
                txtOutputIndOverall.AppendText("   ");
                //threes%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 9]));
                txtOutputIndOverall.AppendText("   ");
                //FM%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 10]));
                txtOutputIndOverall.AppendText("   ");
                //FA%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 11]));
                txtOutputIndOverall.AppendText("      ");
                //FT%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 12]));
                txtOutputIndOverall.AppendText("      ");
                //Total%
                txtOutputIndOverall.AppendText(String.Format("{0:##.#}", Stats.EOY_Stats.EOYPlayerStats[d, 13]));
                txtOutputIndOverall.AppendText(Environment.NewLine);
                d++;
            }
            txtOutputIndOverall.AppendText("-----------------------------------------------------------------------------------------");

            //txtoutputindGame
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Individual Game Stats");
            Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

            saveFileDialog.InitialDirectory = Path.GetFullPath(reportFolder);
            saveFileDialog.Title = "Team Individual Report";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;


            // Set default file name to match student name
            saveFileDialog.FileName = String.Format("{0} {1} {2}", Stats.GameInformation.GameNumber, Stats.GameInformation.DateofGame, Information.Team.AwayTeamName);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write all text to file
                    File.WriteAllText(saveFileDialog.FileName, txtOutputIndGame.Text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Could not save the file. Message: " + ex.Message);
                }
            }

            //txtoutputteambygame
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();

            var reportFolder2 = Path.Combine(Application.StartupPath, @"Boysbasketball/Individual Game Stats");
            Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

            saveFileDialog2.InitialDirectory = Path.GetFullPath(reportFolder);
            saveFileDialog2.Title = "Team Final Report";
            saveFileDialog2.CheckPathExists = true;
            saveFileDialog2.DefaultExt = "txt";
            saveFileDialog2.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog2.RestoreDirectory = true;


            // Set default file name to match student name
            saveFileDialog2.FileName = "FinalTeamGameReport";

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write all text to file
                    File.WriteAllText(saveFileDialog2.FileName, txtOutputTeambyGame.Text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Could not save the file. Message: " + ex.Message);
                }
            }
            //txtoutputteamoverall
            SaveFileDialog saveFileDialog3 = new SaveFileDialog();

            var reportFolder3 = Path.Combine(Application.StartupPath, @"Boysbasketball/Individual Game Stats");
            Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

            saveFileDialog3.InitialDirectory = Path.GetFullPath(reportFolder);
            saveFileDialog3.Title = "Team Final Report";
            saveFileDialog3.CheckPathExists = true;
            saveFileDialog3.DefaultExt = "txt";
            saveFileDialog3.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog3.RestoreDirectory = true;


            // Set default file name to match student name
            saveFileDialog3.FileName = "FinalTeamOverallReport";

            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write all text to file
                    File.WriteAllText(saveFileDialog3.FileName, txtOutputTeamOverall.Text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Could not save the file. Message: " + ex.Message);
                }
            }
            //txtoutputindoverall
            SaveFileDialog saveFileDialog4 = new SaveFileDialog();

            var reportFolder4 = Path.Combine(Application.StartupPath, @"Boysbasketball/Individual Game Stats");
            Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

            saveFileDialog4.InitialDirectory = Path.GetFullPath(reportFolder);
            saveFileDialog4.Title = "Team Final Report";
            saveFileDialog4.CheckPathExists = true;
            saveFileDialog4.DefaultExt = "txt";
            saveFileDialog4.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog4.RestoreDirectory = true;


            // Set default file name to match student name
            saveFileDialog4.FileName = "FinalIndividualOverallReport";

            if (saveFileDialog4.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write all text to file
                    File.WriteAllText(saveFileDialog4.FileName, txtOutputIndOverall.Text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Could not save the file. Message: " + ex.Message);
                }
            }
        }
        #endregion

        #region OpeningPlayersfromFile
        class OpenPlayers
        {
            private OpenPlayers()
            {
               
                Stream myStream = null;
                OpenFileDialog OpenfromFile = new OpenFileDialog();
                OpenfromFile.InitialDirectory = "c:\\";
                OpenfromFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                OpenfromFile.FilterIndex = 2;
                OpenfromFile.RestoreDirectory = true;

                if (OpenfromFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = OpenfromFile.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                // Insert code to read the stream here.
                                foreach (string line in File.ReadAllLines(Convert.ToString(myStream)))
                                {
                                    string[] parts = line.Split('|');

                                    Information.Players.PlayerPos[a] = parts[0];
                                    Information.Players.PlayerNum[a] = parts[1];
                                    Information.Players.FirstName[a] = parts[2];
                                    Information.Players.LastName[a] = parts[3];
                                    Information.Players.PlayerGrade[a] = parts[4];

                                    a++;

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                    a = 0;
                }
            }
        }
        #endregion

        #region SavingPlayerstoFile
        
            public void SavePlayers()
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information/Roster");
                Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

                saveFileDialog.InitialDirectory = Path.GetFullPath(reportFolder);
                saveFileDialog.Title = "Save Registration Report";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.RestoreDirectory = true;


                // Set default file name to match student name
                saveFileDialog.FileName = String.Format("{0}", "Player Information");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        // Write all text to file
                        File.WriteAllText(saveFileDialog.FileName, txtOutputTeam.Text);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Could not save the file. Message: " + ex.Message);
                    }
                }
            }
        
        #endregion

        #region SaveTeamtoFile 
        public void SaveTeam()
        {//written text to output file
            txtOutputTeam.AppendText(Information.Team.teamName);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Team.teamNickName);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Team.teamAbb);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Team.teamColors);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Coaches.teamHC);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Coaches.teamAC);
            txtOutputTeam.AppendText(Environment.NewLine);
            txtOutputTeam.AppendText(Information.Team.RosterName);
            txtOutputTeam.AppendText(Environment.NewLine);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information");
            Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

            saveFileDialog.InitialDirectory = Path.GetFullPath(reportFolder);
            saveFileDialog.Title = "Team Information";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;


            // Set default file name to match student name
            saveFileDialog.FileName = String.Format("{0}", Information.Team.HomeTeamName);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Write all text to file
                    File.WriteAllText(saveFileDialog.FileName, txtOutputTeam.Text);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Could not save the file. Message: " + ex.Message);
                }
            }
        }
        #endregion


    }
}
