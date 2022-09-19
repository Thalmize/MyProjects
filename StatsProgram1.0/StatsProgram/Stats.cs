using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsProgram
{
    class Stats
    {
        
        
        //team totals
       
       
        
       
        //playerStats with Total Array
        
        
        internal static class HomeTeam
        {
            public static double[,] HomePoints = new double[1000, 4];
            public static double[] HomePointsTotal = new double[1000];
        }

        internal static class AwayTeam
        {
            public static double[,] AwayPoints = new double[1000, 4];
            public static double[] AwayPointsTotal = new double[1000];
        }

        internal static class GameInformation
        {
            public static double[] PointDifferential = new double[1000];
            //location and DOG arrays
            public static string[] GameLocation = new string[1000];
            public static string[] DateofGame = new string[1000];
            //game number and team win/loss

            public static int GameNumber = 0;
            public static int TeamWin = 0;
            public static int TeamLoss = 0;
            public static string HomeResult;
            public static string AwayResult;
        }

        internal static class EOY_Stats
        {
            public static double[] EOYTeamStats = new double[100];
            public static double[] EOYHomePoints = new double[100];
            public static double[] EOYAwayPoints = new double[100];
            public static double[,] EOYPlayerStats = new double[1000, 1000];
        }
        internal static class Variable
        {
            public static int a;
            public static int z;
        }
            

        internal static class Plyer_TtlStats
        {
            public static bool DidYouPlay;
            public static double[,] PlayerStats = new double[1000, 1000];
            public static double[,] PlayerPercents = new double[1000, 1000];
            public static double[,] TotalStats = new double[1000, 1000];
        }
        public Stats()
        {
            
        }


    }
}
