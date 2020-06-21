using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace StatsProgram
{
    class Information
    {
        
        internal static class Players
        {
            public static string[] PlayerPos = new string[1000];
            public static string[] PlayerNum = new string[1000];
            public static string[] FirstName = new string[1000];
            public static string[] LastName = new string[1000];
            public static string[] PlayerGrade = new string[1000];
        }
        internal static class Coaches
        {
            public static string teamHC;
            public static string teamAC;
        }
         internal static class Team
        {
            public static string[] AwayTeamName = new string[1000];
            public static string HomeTeamName = "Oak Grove Eagles";
            public static string teamName;
            public static string teamNickName;
            public static string teamAbb;
            public static string teamColors;
            public static string RosterName;
            public static int RosterCount;
        }
        
       
        public Information()
        { }

    }
    
}
