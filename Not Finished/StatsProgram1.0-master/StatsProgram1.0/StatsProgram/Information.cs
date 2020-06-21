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
            public static string HomeTeamName = teamName + " " + teamNickName;
            public static string teamName;
            public static string teamNickName;
            public static string teamAbb;
            public static string teamColors;
            public static string RosterName;
            public static int RosterCount;
            public static string Split = "|";
        }
        
        internal static class Variables
        {
            public static int a;
        }

        public Information()
        { }

        #region Open Team
        public void OpenTeam()
        {
            var folder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information/Roster");
            Directory.CreateDirectory(folder);

            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = Path.GetFullPath(folder),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Title = "Open Team Information"
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
        }
        #endregion

        #region Open Players
        public void OpenPlayers()
        {
            var folder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information/Players");
            Directory.CreateDirectory(folder);
            Information.Variables.a = 0;


            OpenFileDialog openFileDialog2 = new OpenFileDialog()
            {

                InitialDirectory = Path.GetFullPath(folder),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                Title = "Open Players File"
            };
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog2.OpenFile()) != null)
                    {
                        string filename = openFileDialog2.FileName;
                        Information.Team.RosterCount = File.ReadAllLines(filename).Count();
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            while (reader.Peek() >= 0)
                            {
                                var line = reader.ReadLine();

                                //splits line into 5 parts
                                var parts = line.Split('|');

                                Information.Players.PlayerNum[Information.Variables.a] = parts[0];//Number
                                Information.Players.PlayerPos[Information.Variables.a] = parts[1];//Position
                                Information.Players.FirstName[Information.Variables.a] = parts[2];//First Name
                                Information.Players.LastName[Information.Variables.a] = parts[3];//Last Name
                                Information.Players.PlayerGrade[Information.Variables.a] = parts[4];//Grade
                                Information.Variables.a++;
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

    }
}
