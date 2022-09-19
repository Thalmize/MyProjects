using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsProgram
{
    class Reports
    {
        public Reports()
        {

        }
        internal static void IndividualReport()
        {
            ReportTxtArea rta = new ReportTxtArea();
            //header
            rta.txtOutputIndGame.AppendText("                          ");
            rta.txtOutputIndGame.AppendText("Official Game Stats - Single Game");
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            rta.txtOutputIndGame.AppendText("                        ");
            rta.txtOutputIndGame.AppendText(Information.Team.teamName + " " + Information.Team.teamNickName + " - " + Information.Team.RosterName);
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            rta.txtOutputIndGame.AppendText("                           ");
            rta.txtOutputIndGame.AppendText("Game #: " + Stats.GameInformation.GameNumber + "   " + "Record: " + Stats.GameInformation.TeamWin + "-" + Stats.GameInformation.TeamLoss);
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            rta.txtOutputIndGame.AppendText("              ");
            rta.txtOutputIndGame.AppendText("Date of Game: " + Stats.GameInformation.DateofGame + "   " + "Game Location: " + Stats.GameInformation.GameLocation);
            rta.txtOutputIndGame.AppendText(Environment.NewLine);
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            //Team Stats
            rta.txtOutputIndGame.AppendText("Team Stats");
            rta.txtOutputIndGame.AppendText(Environment.NewLine);
            rta.txtOutputIndGame.AppendText("---------------------------------------------------------------------------");
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            rta.txtOutputIndGame.AppendText("W/L" + "   ");

            string name = "Team Name";
            int len = 0;
            int x = 0;
            len = name.Length;

            while (x < len)
            {
                var temp = name.ToCharArray();
                rta.txtOutputIndGame.AppendText(temp[x].ToString());
                x++;
            }
            while (len < 30)
            {
                rta.txtOutputIndGame.AppendText(" ");
                len++;
            }
            rta.txtOutputIndGame.AppendText("   ");
            rta.txtOutputIndGame.AppendText("Q1" + "     " + "Q2" + "     " + "Q3" + "     " + "Q4" + "       " + "Total");
            rta.txtOutputIndGame.AppendText(Environment.NewLine);
            rta.txtOutputIndGame.AppendText("---------------------------------------------------------------------------");
            rta.txtOutputIndGame.AppendText(Environment.NewLine);

            rta.txtOutputIndGame.AppendText(" " + Stats.GameInformation.AwayResult + "    ");


        }
        internal static void IndividualOverallReport()
        {
            ReportTxtArea rta = new ReportTxtArea();

        }
        internal static void TeambyGameReport()
        {
            ReportTxtArea rta = new ReportTxtArea();

        }
        internal static void TeamOverallReport()
        {
            ReportTxtArea rta = new ReportTxtArea();

        }
    }
}
