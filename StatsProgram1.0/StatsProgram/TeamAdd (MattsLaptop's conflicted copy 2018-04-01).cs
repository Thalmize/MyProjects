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
    public partial class TeamAdd : Form
    {
        //declared variables

        public string teamName;
        public string teamNickName;
        public string teamAbb;
        public string teamColors;
        public string teamHC;
        public string teamAC;
        public string RosterName;
        

     
        int i = 0;
        public TeamAdd()
        {
            InitializeComponent();
        }

        private void Roster_Load(object sender, EventArgs e)
        {
           //hidden label until shown
            lblTeamPlayer.Visible = false;


        }

        private void btnSaveTeam_Click(object sender, EventArgs e)
        {
           //on click label is visible
            lblTeamPlayer.Visible = true;
            //saves team to file
            SaveTeam();

           

        
        }

        private void SaveTeam()
        {//written text to output file
            txtOutput.AppendText(txtbxTeamName.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxTeamNick.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxTeamAbb.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxSchColor.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxHeadCoach.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxAstCoach.Text);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText(txtbxRosterName.Text);
            txtOutput.AppendText(Environment.NewLine);

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
            saveFileDialog.FileName = String.Format("{0}", txtbxTeamName.Text);

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
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
        
            //closes Team Add
            Close();

        }
    }
}
