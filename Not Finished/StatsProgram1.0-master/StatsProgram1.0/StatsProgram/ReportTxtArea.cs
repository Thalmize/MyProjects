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

      

        #region FinalSave

        public void FinalSavetoFile()
        {
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
                     int c = 0; 

            while (c < Information.Team.RosterCount)
            {
                txtOutputPlayers.AppendText(Information.Players.PlayerNum[c] + Information.Team.Split + Information.Players.PlayerPos[c] + Information.Team.Split + Information.Players.FirstName[c] + Information.Team.Split + Information.Players.LastName[c] + Information.Team.Split + Information.Players.PlayerGrade[c]);
                txtOutputPlayers.AppendText(Environment.NewLine);
                c++;
            }
                 
                 SaveFileDialog saveFileDialog = new SaveFileDialog();

                var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information/Players");
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
                        File.WriteAllText(saveFileDialog.FileName, txtOutputPlayers.Text);
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

            var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Team Information/Roster");
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
