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
        //Declares team information
        string TeamName;
        string TeamNickName;
        string RosterName;
        string TeamAbb;
        string TeamColor;
        string TeamHC;
        string TeamAC;

        //Declares Player information
        string[] FirstName = new string[1000];
        string[] LastName = new string[1000];
        string[] PlayerPos = new string[1000];
        string[] PlayerGrade = new string[1000];
        string[] PlayerNumber = new string[1000];
        //used for counting number of players on roster * will use later*
        int rostercount = 0;
   
        //used for loop of players
        int a = 0;
        int i = 0;
        //shows Team Record
        string TeamRecord;
        double GameNumber = 1;
        double Win = 0;
        double Loss = 0;

        public void AddGame_Load(object sender, EventArgs e)
        {
            

            //Shows Team Information
            ShowTeamRoster();
            //Shows Roster for Team
            OpenTeamPlayers();
            
            txtbxGameNum.Text = Convert.ToString(GameNumber);
            txtbxW.Text = Convert.ToString(Win);
            txtbxL.Text = Convert.ToString(Loss);
            TeamRecord = (Convert.ToString(Win) + " - " + Convert.ToString(Loss));

        }

        private void LoadGameInfo()
        {//Loads game information to txtoutput *MUST DO LOAD FIRST
            txtOutput.AppendText("                              ");
            txtOutput.AppendText("Official Game Stats");
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText("                        ");
            txtOutput.AppendText(TeamName + " " +TeamNickName);
            txtOutput.AppendText(" - ");
            txtOutput.AppendText(RosterName);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText("                           ");
            txtOutput.AppendText("Game #:" + " " + txtbxGameNum.Text);
            txtOutput.AppendText("     ");
            txtOutput.AppendText("Record:" + " " + TeamRecord);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText("              ");
            txtOutput.AppendText("Date of Game:" + " " + txtbxDoG.Text);
            txtOutput.AppendText("     ");
            txtOutput.AppendText("Game Location:" + " " + txtbxGL.Text);
            txtOutput.AppendText(Environment.NewLine);
        }
        private void ShowTeamRoster()
        {//Open directory for Team Roster
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
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
                       
                        //reads txt file
                        var line = File.ReadAllLines(filename);
                        //splits each line in txt file to sub-grouping
                        TeamName = line[0];
                        TeamNickName = line[1];
                        TeamAbb = line[2];
                        TeamColor = line[3];
                        TeamHC = line[4];
                        TeamAC = line[5];
                        RosterName = line[6];
                        // puts rostername to txtbx to show
                        txtbxTeamRoster.Text = RosterName;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void OpenTeamPlayers()
        {
            // opens roster
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
                        rostercount = filename.Count();
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            while (reader.Peek() >= 0)
                            {
                                var line = reader.ReadLine();

                                var parts = line.Split('|');

                                PlayerNumber[i] = parts[0];
                                PlayerPos[i] = parts[1];
                                FirstName[i] = parts[2];
                                LastName[i] = parts[3];
                                PlayerGrade[i] = parts[4];
                                i++;


                            }
                        }
                    }

                    txtbxPlayer.Text =FirstName[a] + " " +LastName[a];
                    txtbxNumber.Text = PlayerNumber[a];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
      
    private void btnSaveGame_Click(object sender, EventArgs e)
        {//adds total and team information right before final save.
         

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                
                var reportFolder = Path.Combine(Application.StartupPath, @"Boysbasketball/Individual Game Reports");
                Directory.CreateDirectory(reportFolder); // Creates the folder if it does not exist

                saveFileDialog.InitialDirectory = Path.GetFullPath(reportFolder);
                saveFileDialog.Title = "Save Registration Report";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.RestoreDirectory = true;


                // Set default file name to match student name
                saveFileDialog.FileName = String.Format("{0}", txtbxHomeTeamName.Text);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Write all text to file
                        File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Could not save the file. Message: " + ex.Message);
                    }
                }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {//closes addgame
            this.Close();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameNumber++;
            txtbxGameNum.Text = Convert.ToString(GameNumber);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkBoxAG.Checked == true)
            {
                txtbxAwayTeamName.Text = TeamName + " " + TeamNickName;
                
            }
            else
            {
                txtbxHomeTeamName.Text = TeamName + " " + TeamNickName;
            }
        
        }
    }
   
}
