using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsProgram
{
    class StoringStats
    {
        
        public StoringStats()
        {}

        internal static void TeamGame(string FirstQA, string SecondQA, string ThirdQA, string FourthQA, string TotalA, string FirstQH, string SecondQH, string ThirdQH, string FourthQH, string TotalH)
        {
            Stats.AwayTeam.AwayPoints[Stats.Variable.z, 0] = Convert.ToDouble(FirstQA);
            Stats.AwayTeam.AwayPoints[Stats.Variable.z, 1] = Convert.ToDouble(SecondQA);
            Stats.AwayTeam.AwayPoints[Stats.Variable.z, 2] = Convert.ToDouble(ThirdQA);
            Stats.AwayTeam.AwayPoints[Stats.Variable.z, 3] = Convert.ToDouble(FourthQA);
            Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z] = Stats.AwayTeam.AwayPoints[Stats.Variable.z, 0] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 1] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 2] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 3];

            TotalA = Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z].ToString();

            Stats.HomeTeam.HomePoints[Stats.Variable.z, 0] = Convert.ToDouble(FirstQH);
            Stats.HomeTeam.HomePoints[Stats.Variable.z, 1] = Convert.ToDouble(SecondQH);
            Stats.HomeTeam.HomePoints[Stats.Variable.z, 2] = Convert.ToDouble(ThirdQH);
            Stats.HomeTeam.HomePoints[Stats.Variable.z, 3] = Convert.ToDouble(FourthQH);
            Stats.HomeTeam.HomePointsTotal[Stats.Variable.z] = Stats.HomeTeam.HomePoints[Stats.Variable.z, 0] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 1] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 2] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 3];

            TotalH = Stats.HomeTeam.HomePointsTotal[Stats.Variable.z].ToString();


        }

        internal static void TeamEOY()
        {
            //end of year stats
            Stats.EOY_Stats.EOYTeamStats[0] = Stats.EOY_Stats.EOYTeamStats[0] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 0];//fouls
            Stats.EOY_Stats.EOYTeamStats[1] = Stats.EOY_Stats.EOYTeamStats[1] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 1];//twos
            Stats.EOY_Stats.EOYTeamStats[2] = Stats.EOY_Stats.EOYTeamStats[2] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 2];//three
            Stats.EOY_Stats.EOYTeamStats[3] = Stats.EOY_Stats.EOYTeamStats[3] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 3];//ftm
            Stats.EOY_Stats.EOYTeamStats[4] = Stats.EOY_Stats.EOYTeamStats[4] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 4];//fta
            Stats.EOY_Stats.EOYTeamStats[5] = Stats.EOY_Stats.EOYTeamStats[5] + Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 5];//total
            Stats.EOY_Stats.EOYTeamStats[6] = Stats.EOY_Stats.EOYTeamStats[0] / Stats.GameInformation.GameNumber;//fouls%
            Stats.EOY_Stats.EOYTeamStats[7] = Stats.EOY_Stats.EOYTeamStats[1] / Stats.GameInformation.GameNumber;//twos%
            Stats.EOY_Stats.EOYTeamStats[8] = Stats.EOY_Stats.EOYTeamStats[2] / Stats.GameInformation.GameNumber;//three%
            Stats.EOY_Stats.EOYTeamStats[9] = Stats.EOY_Stats.EOYTeamStats[4] / Stats.GameInformation.GameNumber;//ftm%
            Stats.EOY_Stats.EOYTeamStats[10] = Stats.EOY_Stats.EOYTeamStats[5] / Stats.GameInformation.GameNumber;//fta%
            Stats.EOY_Stats.EOYTeamStats[11] = ((Stats.EOY_Stats.EOYTeamStats[3] / Stats.EOY_Stats.EOYTeamStats[4]) * 100);//FT%

            //end of year qtrs & total away
            Stats.EOY_Stats.EOYAwayPoints[0] = Stats.EOY_Stats.EOYAwayPoints[0] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 0];//Q1
            Stats.EOY_Stats.EOYAwayPoints[1] = Stats.EOY_Stats.EOYAwayPoints[1] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 1];//Q2
            Stats.EOY_Stats.EOYAwayPoints[2] = Stats.EOY_Stats.EOYAwayPoints[2] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 2];//Q3
            Stats.EOY_Stats.EOYAwayPoints[3] = Stats.EOY_Stats.EOYAwayPoints[3] + Stats.AwayTeam.AwayPoints[Stats.Variable.z, 3];//Q4
            Stats.EOY_Stats.EOYAwayPoints[4] = Stats.EOY_Stats.EOYAwayPoints[4] + Stats.AwayTeam.AwayPointsTotal[Stats.Variable.z];//Total
            Stats.EOY_Stats.EOYAwayPoints[5] = Stats.EOY_Stats.EOYAwayPoints[0] / Stats.GameInformation.GameNumber;//Q1%
            Stats.EOY_Stats.EOYAwayPoints[6] = Stats.EOY_Stats.EOYAwayPoints[1] / Stats.GameInformation.GameNumber;//Q2%
            Stats.EOY_Stats.EOYAwayPoints[7] = Stats.EOY_Stats.EOYAwayPoints[2] / Stats.GameInformation.GameNumber;//Q3%
            Stats.EOY_Stats.EOYAwayPoints[8] = Stats.EOY_Stats.EOYAwayPoints[3] / Stats.GameInformation.GameNumber;//Q4%
            Stats.EOY_Stats.EOYAwayPoints[9] = Stats.EOY_Stats.EOYAwayPoints[4] / Stats.GameInformation.GameNumber;//Total%
                                                                                                                   //end of year qtrs & total Home
            Stats.EOY_Stats.EOYHomePoints[0] = Stats.EOY_Stats.EOYHomePoints[0] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 0];//Q1
            Stats.EOY_Stats.EOYHomePoints[1] = Stats.EOY_Stats.EOYHomePoints[1] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 1];//Q2
            Stats.EOY_Stats.EOYHomePoints[2] = Stats.EOY_Stats.EOYHomePoints[2] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 2];//Q3
            Stats.EOY_Stats.EOYHomePoints[3] = Stats.EOY_Stats.EOYHomePoints[3] + Stats.HomeTeam.HomePoints[Stats.Variable.z, 3];//Q4
            Stats.EOY_Stats.EOYHomePoints[4] = Stats.EOY_Stats.EOYHomePoints[4] + Stats.HomeTeam.HomePointsTotal[Stats.Variable.z];//Total
            Stats.EOY_Stats.EOYHomePoints[5] = Stats.EOY_Stats.EOYHomePoints[0] / Stats.GameInformation.GameNumber;//Q1%
            Stats.EOY_Stats.EOYHomePoints[6] = Stats.EOY_Stats.EOYHomePoints[1] / Stats.GameInformation.GameNumber;//Q2%
            Stats.EOY_Stats.EOYHomePoints[7] = Stats.EOY_Stats.EOYHomePoints[2] / Stats.GameInformation.GameNumber;//Q3%
            Stats.EOY_Stats.EOYHomePoints[8] = Stats.EOY_Stats.EOYHomePoints[3] / Stats.GameInformation.GameNumber;//Q4%
            Stats.EOY_Stats.EOYHomePoints[9] = Stats.EOY_Stats.EOYHomePoints[4] / Stats.GameInformation.GameNumber;//total%
        }

        internal static void PlayerGame(string fouls, string twos, string threes, string ftm, string fta, string totalpoints, string dreb, string oreb, string treb, string to, string stl, string blk)
        {
            if (Stats.Plyer_TtlStats.DidYouPlay == true)
            {
                Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 0]++; // if they played in the game
            }
            else
            {
                return;
            }

            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 1] = Convert.ToDouble(fouls); // fouls
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 2] = Convert.ToDouble(twos); //twos
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 3] = Convert.ToDouble(threes); //threes
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 4] = Convert.ToDouble(ftm); //ftm
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 5] = Convert.ToDouble(fta); //fta
            totalpoints = ((Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 2] * 2) + (Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 3] * 3) + (Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 4] * 1)).ToString();
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 6] = Convert.ToDouble(totalpoints);

            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 7] = Convert.ToDouble(dreb); //def reb
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 8] = Convert.ToDouble(oreb); // off reb
            treb = (Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 7] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 8]).ToString();
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 9] = Convert.ToDouble(treb); //total reb
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 10] = Convert.ToDouble(to); // TO
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 11] = Convert.ToDouble(stl); //STL
            Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 12] = Convert.ToDouble(blk); //BLK


        }

        internal static void PlayerTotalGame()
        {
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 1] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 1] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 1]; //fouls
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 2] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 2] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 2]; //twos
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 3] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 3] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 3]; //threes
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 4] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 4] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 4]; //ftm
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 5] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 5] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 5]; //fta
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 6] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 6] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 6]; //totalpoints
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 7] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 7] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 7]; //dreb
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 8] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 8] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 8]; //oreb
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 9] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 9] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 9]; //treb
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 10] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 10] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 10]; //TO
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 11] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 11] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 11]; //STL
            Stats.Plyer_TtlStats.TotalStats[Stats.Variable.z, 12] = Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.z, 12] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 12]; //BLK

        }

        internal static void PlayerEOY()
        {
            //per player
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 0];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 1] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 1] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 1];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 2] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 2] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 2];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 3] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 3] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 3];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 4] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 4] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 4];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 5] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 5] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 5];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 6] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 6] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 6];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 7] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 7] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 7];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 8] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 8] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 8];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 9] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 9] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 9];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 10] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 10] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 10];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 11] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 11] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 11];
            Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 12] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 12] + Stats.Plyer_TtlStats.PlayerStats[Stats.Variable.a, 12];
        }

        internal static void PlayerPercentages()
        {
            //per player per game
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 1] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 1] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //fouls
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 2] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 2] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //twos
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 3] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 3] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //threes
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 4] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 4] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //ftm
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 5] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 5] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //fta
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 6] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 6] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //totalpoints
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 7] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 7] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //dreb
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 8] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 8] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //oreb
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 9] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 9] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //treb
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 10] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 10] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //to
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 11] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 11] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //stl
            Stats.Plyer_TtlStats.PlayerPercents[Stats.Variable.a, 12] = Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 12] / Stats.EOY_Stats.EOYPlayerStats[Stats.Variable.a, 0]; //blk
        }

    }
}
