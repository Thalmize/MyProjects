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
    public partial class PlayerCore : Form
    {
        public PlayerCore()
        {
            InitializeComponent();
        }


        int i;
        int b;
        //declares variables and arrays
        
        private void PlayerCore_Load(object sender, EventArgs e)
        {//loads roster to program
            
            lblSavePlyr.Visible = false;
            
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            
            try
            {//takes txtbxs and adds to array 
                Information.Players.FirstName[b] = txtbxFirstName.Text;
                Information.Players.LastName[b] = txtbxLastName.Text;
                Information.Players.PlayerNum[b] = txtbxNumber.Text;
                Information.Players.PlayerGrade[b] = txtbxGrade.Text;
                Information.Players.PlayerPos[b] = txtbxPosition.Text;
                //takes player info puts in txt file
                txtOutputPlayers.AppendText(Information.Players.FirstName[b] + "|" + Information.Players.LastName[b] + "|" + Information.Players.PlayerNum[b] + "|" + Information.Players.PlayerPos[b] + "|" + Information.Players.PlayerGrade[b]);
                txtOutputPlayers.AppendText(Environment.NewLine);

                Information.Team.RosterCount++;
                b++;
            }


            catch(Exception ex)
            { MessageBox.Show("DID NOT WORK " + ex.Message); }
            
            Clearboxes();
            //triggers label stating player added
            lblSavePlyr.Visible = true;
            lblSavePlyr.Text = "Player Added";

            lblPlayerind.Text = Information.Team.RosterCount.ToString();

        }



        private void btnReturn_Click(object sender, EventArgs e)
        {//saves roster and prompts to close
            ReportTxtArea RTA = new ReportTxtArea();

            RTA.SavePlayers();
            this.Close();


        }

        
        private void Clearboxes()
        {
            lblSavePlyr.Visible = false;
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxGrade.Clear();
            txtbxNumber.Clear();
            txtbxPosition.Clear();
            i++;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {//clears txtbxs
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxGrade.Clear();
            txtbxNumber.Clear();
            txtbxPosition.Clear();
        }

       
    }
}
