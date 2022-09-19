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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Program
            Close();
           
        }

        

        

        private void btnGameManagement_Click(object sender, EventArgs e)
        {
            // Opens Game Management 
            AddGame AG = new AddGame();

            AG.ShowDialog();

        }

        private void btnRosterManagement_Click(object sender, EventArgs e)
        {
            // Opens Roster Management 
            TeamManagement rosterManagement = new TeamManagement();
            rosterManagement.ShowDialog();

        }

        private void btnViewRep_Click(object sender, EventArgs e)
        {
            // Opens View Report
            ViewReport viewReport = new ViewReport();
            viewReport.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

    }
}
