using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace StatsProgram
{
    class Teams : object
    {
        private static byte teamID = 0;
        public string teamName;
        public string teamNickName;
        public string teamAbbreviation;
        public string teamColors;
        public string teamHeadCoach;
        public string teamAssistantCoach;
        public string teamRosterName;
        public byte RosterCount;

        public Teams () { }
        public Teams (string TName, string TNickName, string TAbb, string TColors, string teamHC, string teamAC, string teamRN)
        {
            teamID++;
            this.teamName = TName;
            this.teamNickName = TNickName;
            this.teamAbbreviation = TAbb;
            this.teamColors = TColors;
            this.teamHeadCoach = teamHC;
            this.teamAssistantCoach = teamAC;
            this.teamRosterName = teamRN;
            this.RosterCount = 0;

        }
    }
}
