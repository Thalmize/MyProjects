using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace BlackJack
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Random r = new Random();
        public bool isGameActive;
        private void Main_Load(object sender, EventArgs e)
        {
            Information.Variables.Player.timer.Interval = 1000;
            Information.Variables.Player.timer.Tick += new EventHandler(Timer_Tick);

            btnReset.Visible = false;
            lblPlayerBank.Text = Information.Variables.Player.PlayerBank.ToString();
            Cards cards = new Cards();
            pbDealerHideCard.Visible = false;            
            pnlPlayerOpt.Visible = false;
            Information.Variables.TableActions.isPlayerSeated = false;
            GUI gui = new GUI();
            gui.LeaveSeatLocation();
            cards.Creating_Deck();
            cards.InitiateChipImages();
            //Shuffling Deck
            cards.Shuffling_Deck();
            cards.Shuffling_Deck();

            cards.InitiateStartingCardLocation();

            //Initializing Game Board
            btnLeaveSeat.Visible = false;
            btnChipsSeat1.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat2.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat3.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat4.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat5.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat6.BackgroundImage = Information.Variables.Card_Chips.chip[0];

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Calculations calc = new Calculations();

            Information.Variables.TableActions.playerBust = calc.didPlayerBust();

            if (Information.Variables.TableActions.playerBust == true)
            {
                Information.Variables.Player.timer.Stop();
                Mechanic mech = new Mechanic();
                pbDealerHideCard.Visible = false;
                Information.Variables.Dealer.DealerHandValue = calc.HandCalc(Information.Variables.Dealer.DealerHand[1], Information.Variables.Dealer.DealerHandValue);
                UpdateGUI();
                Information.Variables.TableActions.CurrentPlayerTurn = "DEALER";
                calc.DealerRulesCheck();
                testlbl.Text = Information.Variables.Dealer.DealerAction;


                //Dealer plays
                while (Information.Variables.TableActions.CurrentPlayerTurn == "DEALER")
                {
                    Thread.Sleep(1500);
                    if (Information.Variables.Dealer.DealerAction == "HIT")
                    {

                        Information.Variables.Card_Chips.card[0, Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[0], Information.Variables.Card_Chips.CardLocationHeight[0]), this);
                        Information.Variables.Dealer.DealerHand[Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.Dealer.DealerHandValue = calc.HandCalc(Information.Variables.Dealer.DealerHand[Information.Variables.TableInfo.NumofCardsforEachPlayer[0]], Information.Variables.Dealer.DealerHandValue);

                        Information.Variables.TableInfo.NumofCardsforEachPlayer[0]++;
                        Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                        Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                        Information.Variables.Card_Chips.cards.RemoveAt(0);
                        Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                        Information.Variables.Card_Chips.CardLocationWidth[0] += 20;

                        UpdateGUI();

                        calc.DealerRulesCheck();
                        testlbl.Text = Information.Variables.Dealer.DealerAction;
                    }

                    if (Information.Variables.Dealer.DealerAction == "STAY")
                    {
                        break;
                    }
                }
                // CPU

                testlbl.Text = calc.whoWon();
                btnReset.Visible = true;
            }
            if(Information.Variables.TableActions.PlayerTimer > 0)
            {
                Information.Variables.TableActions.PlayerTimer--;
                lblTimer.Text = Information.Variables.TableActions.PlayerTimer.ToString();
            }
            else
            {
                Information.Variables.Player.timer.Stop();
                MessageBox.Show("Time is up. Turn is over");
                
            }
        }
        // Seat button mechanic allowing user to sit and disables all seats
        #region

        private void BtnSeat1_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[1], Information.Variables.GUI.LeaveButtonLocationHeight[1]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 1;
            Players players = new Players();
            players.CPUPlaying();
            
            txtbxSeat1.Text = Information.Variables.Player.PlayerName;
           
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat2.BackColor = Color.Gray;
            btnChipsSeat2.Enabled = false;
            btnChipsSeat3.BackColor = Color.Gray;
            btnChipsSeat3.Enabled = false;
            btnChipsSeat4.BackColor = Color.Gray;
            btnChipsSeat4.Enabled = false;
            btnChipsSeat5.BackColor = Color.Gray;
            btnChipsSeat5.Enabled = false;
            btnChipsSeat6.BackColor = Color.Gray;
            btnChipsSeat6.Enabled = false;

            // Disables seat user is not in
            btnSeat2.BackColor = Color.Gray;
            btnSeat2.Enabled = false;
            btnSeat3.BackColor = Color.Gray;
            btnSeat3.Enabled = false;
            btnSeat4.BackColor = Color.Gray;
            btnSeat4.Enabled = false;
            btnSeat5.BackColor = Color.Gray;
            btnSeat5.Enabled = false;
            btnSeat6.BackColor = Color.Gray;
            btnSeat6.Enabled = false;
        }

        private void BtnSeat2_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[2], Information.Variables.GUI.LeaveButtonLocationHeight[2]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 2;
            Players players = new Players();
            players.CPUPlaying();
            txtbxSeat2.Text = Information.Variables.Player.PlayerName;
          
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat1.BackColor = Color.Gray;
            btnChipsSeat1.Enabled = false;
            btnChipsSeat3.BackColor = Color.Gray;
            btnChipsSeat3.Enabled = false;
            btnChipsSeat4.BackColor = Color.Gray;
            btnChipsSeat4.Enabled = false;
            btnChipsSeat5.BackColor = Color.Gray;
            btnChipsSeat5.Enabled = false;
            btnChipsSeat6.BackColor = Color.Gray;
            btnChipsSeat6.Enabled = false;
            // Disables seat user is not in
            btnSeat1.BackColor = Color.Gray;
            btnSeat1.Enabled = false;
            btnSeat3.BackColor = Color.Gray;
            btnSeat3.Enabled = false;
            btnSeat4.BackColor = Color.Gray;
            btnSeat4.Enabled = false;
            btnSeat5.BackColor = Color.Gray;
            btnSeat5.Enabled = false;
            btnSeat6.BackColor = Color.Gray;
            btnSeat6.Enabled = false;
        }

        private void BtnSeat3_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[3], Information.Variables.GUI.LeaveButtonLocationHeight[3]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 3;
            Players players = new Players();
            players.CPUPlaying();

            txtbxSeat3.Text = Information.Variables.Player.PlayerName;
           
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat1.BackColor = Color.Gray;
            btnChipsSeat1.Enabled = false;
            btnChipsSeat2.BackColor = Color.Gray;
            btnChipsSeat2.Enabled = false;
            btnChipsSeat4.BackColor = Color.Gray;
            btnChipsSeat4.Enabled = false;
            btnChipsSeat5.BackColor = Color.Gray;
            btnChipsSeat5.Enabled = false;
            btnChipsSeat6.BackColor = Color.Gray;
            btnChipsSeat6.Enabled = false;
            // Disables seat user is not in
            btnSeat1.BackColor = Color.Gray;
            btnSeat1.Enabled = false;
            btnSeat2.BackColor = Color.Gray;
            btnSeat2.Enabled = false;
            btnSeat4.BackColor = Color.Gray;
            btnSeat4.Enabled = false;
            btnSeat5.BackColor = Color.Gray;
            btnSeat5.Enabled = false;
            btnSeat6.BackColor = Color.Gray;
            btnSeat6.Enabled = false;
        }

        private void BtnSeat4_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[4], Information.Variables.GUI.LeaveButtonLocationHeight[4]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 4;
            Players players = new Players();
            players.CPUPlaying();

            txtbxSeat4.Text = Information.Variables.Player.PlayerName;
           
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat1.BackColor = Color.Gray;
            btnChipsSeat1.Enabled = false;
            btnChipsSeat2.BackColor = Color.Gray;
            btnChipsSeat2.Enabled = false;
            btnChipsSeat3.BackColor = Color.Gray;
            btnChipsSeat3.Enabled = false;
            btnChipsSeat5.BackColor = Color.Gray;
            btnChipsSeat5.Enabled = false;
            btnChipsSeat6.BackColor = Color.Gray;
            btnChipsSeat6.Enabled = false;
            // Disables seat user is not in
            btnSeat1.BackColor = Color.Gray;
            btnSeat1.Enabled = false;
            btnSeat2.BackColor = Color.Gray;
            btnSeat2.Enabled = false;
            btnSeat3.BackColor = Color.Gray;
            btnSeat3.Enabled = false;
            btnSeat5.BackColor = Color.Gray;
            btnSeat5.Enabled = false;
            btnSeat6.BackColor = Color.Gray;
            btnSeat6.Enabled = false;
        }

        private void BtnSeat5_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[5], Information.Variables.GUI.LeaveButtonLocationHeight[5]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 5;
            Players players = new Players();
            players.CPUPlaying();

            txtbxSeat5.Text = Information.Variables.Player.PlayerName;
          
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat1.BackColor = Color.Gray;
            btnChipsSeat1.Enabled = false;
            btnChipsSeat2.BackColor = Color.Gray;
            btnChipsSeat2.Enabled = false;
            btnChipsSeat3.BackColor = Color.Gray;
            btnChipsSeat3.Enabled = false;
            btnChipsSeat4.BackColor = Color.Gray;
            btnChipsSeat4.Enabled = false;
            btnChipsSeat6.BackColor = Color.Gray;
            btnChipsSeat6.Enabled = false;
            // Disables seat user is not in
            btnSeat1.BackColor = Color.Gray;
            btnSeat1.Enabled = false;
            btnSeat2.BackColor = Color.Gray;
            btnSeat2.Enabled = false;
            btnSeat3.BackColor = Color.Gray;
            btnSeat3.Enabled = false;
            btnSeat4.BackColor = Color.Gray;
            btnSeat4.Enabled = false;
            btnSeat6.BackColor = Color.Gray;
            btnSeat6.Enabled = false;
        }

        private void BtnSeat6_Click(object sender, EventArgs e)
        {
            btnLeaveSeat.Location = new Point(Information.Variables.GUI.LeaveButtonLocationWidth[6], Information.Variables.GUI.LeaveButtonLocationHeight[6]);
            btnLeaveSeat.Visible = true;
            Information.Variables.TableActions.isPlayerSeated = true;
            Information.Variables.Player.PlayerSeat = 6;
            Players players = new Players();
            players.CPUPlaying();

            txtbxSeat6.Text = Information.Variables.Player.PlayerName;
           
            // disables chips at seats user is not in
            btnLeaveSeat.Visible = true;
            btnChipsSeat1.BackColor = Color.Gray;
            btnChipsSeat1.Enabled = false;
            btnChipsSeat2.BackColor = Color.Gray;
            btnChipsSeat2.Enabled = false;
            btnChipsSeat3.BackColor = Color.Gray;
            btnChipsSeat3.Enabled = false;
            btnChipsSeat4.BackColor = Color.Gray;
            btnChipsSeat4.Enabled = false;
            btnChipsSeat5.BackColor = Color.Gray;
            btnChipsSeat5.Enabled = false;
            // Disables seat user is not in
            btnSeat1.BackColor = Color.Gray;
            btnSeat1.Enabled = false;
            btnSeat2.BackColor = Color.Gray;
            btnSeat2.Enabled = false;
            btnSeat3.BackColor = Color.Gray;
            btnSeat3.Enabled = false;
            btnSeat4.BackColor = Color.Gray;
            btnSeat4.Enabled = false;
            btnSeat5.BackColor = Color.Gray;
            btnSeat5.Enabled = false;
        }
        #endregion 

        private void BtnLeaveSeat_Click(object sender, EventArgs e)
        {
            Information.Variables.TableActions.isPlayerSeated = false;
            btnLeaveSeat.Visible = false;
            Information.Variables.Player.PlayerSeat = 0;
            // enables chips upon leaving seat
            btnLeaveSeat.Visible = false;
            btnChipsSeat1.BackColor = Color.Green;
            btnChipsSeat1.Enabled = true;
            btnChipsSeat2.BackColor = Color.Green;
            btnChipsSeat2.Enabled = true;
            btnChipsSeat3.BackColor = Color.Green;
            btnChipsSeat3.Enabled = true;
            btnChipsSeat4.BackColor = Color.Green;
            btnChipsSeat4.Enabled = true;
            btnChipsSeat5.BackColor = Color.Green;
            btnChipsSeat5.Enabled = true;
            btnChipsSeat6.BackColor = Color.Green;
            btnChipsSeat6.Enabled = true;
            // enables chips upon leaving seat
            btnSeat1.BackColor = Color.Red;
            btnSeat1.Enabled = true;
            btnSeat2.BackColor = Color.Red;
            btnSeat2.Enabled = true;
            btnSeat3.BackColor = Color.Red;
            btnSeat3.Enabled = true;
            btnSeat4.BackColor = Color.Red;
            btnSeat4.Enabled = true;
            btnSeat5.BackColor = Color.Red;
            btnSeat5.Enabled = true;
            btnSeat6.BackColor = Color.Red;
            btnSeat6.Enabled = true;

            //chip stack back to origin
            btnChipsSeat1.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat2.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat3.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat4.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat5.BackgroundImage = Information.Variables.Card_Chips.chip[0];
            btnChipsSeat6.BackgroundImage = Information.Variables.Card_Chips.chip[0];

            //reset name for player upon leaving
            txtbxSeat1.Clear();
            txtbxSeat2.Clear();
            txtbxSeat3.Clear();
            txtbxSeat4.Clear();
            txtbxSeat5.Clear();
            txtbxSeat6.Clear();
        }
        //Chip selection for each seat
       

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Information.Variables.TableActions.PlayerTimer = 15;
            Information.Variables.Player.timer.Start();
            Mechanic mech = new Mechanic();
            Calculations calc = new Calculations();
            GUI gui = new GUI();
            Cards cards = new Cards();
            isGameActive = true;

            if (Information.Variables.TableActions.isPlayerSeated != true)
            {
                MessageBox.Show("Sorry you are not seated");
            }
            else
            {
                pnlPlayerOpt.Visible = true;

                
                lblPlayerBank.Text = Information.Variables.Player.PlayerBank.ToString();
                FirstDeal();
                UpdateGUI();
                
                
                bool doesDeckNeedsReshuffled;
                doesDeckNeedsReshuffled = cards.ReShufflingDeckCheck();
                if (doesDeckNeedsReshuffled == true)
                {
                    while (Information.Variables.Card_Chips.discardPile.Count != 0)
                    {
                        Information.Variables.Card_Chips.BaseDeck.Add(Information.Variables.Card_Chips.discardPile[0]);
                        Information.Variables.Card_Chips.cards.Add(Information.Variables.Card_Chips.discardPileImage[0]);
                        Information.Variables.Card_Chips.discardPile.RemoveAt(0);
                        Information.Variables.Card_Chips.discardPileImage.RemoveAt(0);
                    }
                    cards.Shuffling_Deck();

                }
            }
           
        }

        public void FirstDeal()
        {
            //initiate class
            Main main = new Main();
            Mechanic mech = new Mechanic();

            Calculations calc = new Calculations();
            Information.Variables.TableInfo.isGameActive = true;
            int seat = 1;

            //first deal to players
            while (seat <= 6)
            {
                Information.Variables.Card_Chips.card[seat, Information.Variables.TableInfo.NumofCardsforEachPlayer[seat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[seat], Information.Variables.Card_Chips.CardLocationHeight[seat]), this);
                Information.Variables.TableInfo.HandsForEachSeat[seat, 0] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                Information.Variables.TableInfo.HandValuesForEachSeat[seat] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[seat, 0], Information.Variables.TableInfo.HandValuesForEachSeat[seat]);
                Information.Variables.TableInfo.NumofCardsforEachPlayer[seat]++;
                Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                Information.Variables.Card_Chips.cards.RemoveAt(0);
                Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                Information.Variables.Card_Chips.CardLocationWidth[seat] += 20;
                seat++;

            }
            //first card to dealer
            Information.Variables.Card_Chips.card[0, Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[0], Information.Variables.Card_Chips.CardLocationHeight[0]), this);
            Information.Variables.Dealer.DealerHand[0] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
            Information.Variables.Dealer.DealerHandValue = calc.HandCalc(Information.Variables.Dealer.DealerHand[0], Information.Variables.Dealer.DealerHandValue);

            Information.Variables.TableInfo.NumofCardsforEachPlayer[0]++;
            Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
            Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

            Information.Variables.Card_Chips.cards.RemoveAt(0);
            Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

            Information.Variables.Card_Chips.CardLocationWidth[0] += 20;
            seat = 1;

            // second deal to player
            while (seat <= 6)
            {
                Information.Variables.Card_Chips.card[seat, Information.Variables.TableInfo.NumofCardsforEachPlayer[seat]] =  mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[seat], Information.Variables.Card_Chips.CardLocationHeight[seat]), this);
                Information.Variables.TableInfo.HandsForEachSeat[seat, 1] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                Information.Variables.TableInfo.HandValuesForEachSeat[seat] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[seat, 1], Information.Variables.TableInfo.HandValuesForEachSeat[seat]);
                Information.Variables.TableInfo.NumofCardsforEachPlayer[seat]++;

                Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                Information.Variables.Card_Chips.cards.RemoveAt(0);
                Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                Information.Variables.Card_Chips.CardLocationWidth[seat] += 20;
                seat++;
            }
            // second card to dealer
            Information.Variables.Card_Chips.card[0, Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[0], Information.Variables.Card_Chips.CardLocationHeight[0]), this);
            Information.Variables.Dealer.DealerHand[1] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
            
            Information.Variables.TableInfo.NumofCardsforEachPlayer[0]++;
            Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
            Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

            Information.Variables.Card_Chips.cards.RemoveAt(0);
            Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

            Information.Variables.Card_Chips.CardLocationWidth[0] += 20;
            pbDealerHideCard.Visible = true;


        }

        public void UpdateGUI()
        {
            GUI gui = new GUI();
            DealerHandValue.Text = gui.UpdateGUIDealer();
            lblHandValueGUI.Text = gui.UpdateGUIHandValue();
            txtbxHandGUI.Text = gui.UpdateGUIHand(txtbxHandGUI);
        }
        private void BtnHIT_Click(object sender, EventArgs e)
        {
            Mechanic mech = new Mechanic();
            Calculations calc = new Calculations();
            Information.Variables.Player.timer.Stop();
            Information.Variables.TableActions.PlayerTimer = 15;
            Information.Variables.Player.timer.Start();
            switch (Information.Variables.Player.PlayerSeat)
                {
                    case 1:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[1], Information.Variables.Card_Chips.CardLocationHeight[1]), this);
                        Information.Variables.TableInfo.NumofCardsforEachPlayer[1]++;
                    Information.Variables.Card_Chips.CardLocationWidth[1] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[1, Information.Variables.TableInfo.NumofCardsforEachPlayer[1]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[1] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[1, Information.Variables.TableInfo.NumofCardsforEachPlayer[1]], Information.Variables.TableInfo.HandValuesForEachSeat[1]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();

                    break;
                    case 2:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[2], Information.Variables.Card_Chips.CardLocationHeight[2]), this);
                    Information.Variables.TableInfo.NumofCardsforEachPlayer[2]++;
                    Information.Variables.Card_Chips.CardLocationWidth[2] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[2, Information.Variables.TableInfo.NumofCardsforEachPlayer[2]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[2] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[2, Information.Variables.TableInfo.NumofCardsforEachPlayer[2]], Information.Variables.TableInfo.HandValuesForEachSeat[2]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();
                    break;
                    case 3:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[3], Information.Variables.Card_Chips.CardLocationHeight[3]), this);
                    Information.Variables.TableInfo.NumofCardsforEachPlayer[3]++;
                        Information.Variables.Card_Chips.CardLocationWidth[3] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[3, Information.Variables.TableInfo.NumofCardsforEachPlayer[3]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[3] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[3, Information.Variables.TableInfo.NumofCardsforEachPlayer[3]], Information.Variables.TableInfo.HandValuesForEachSeat[3]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();
                    break;
                    case 4:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[4], Information.Variables.Card_Chips.CardLocationHeight[4]), this);
                    Information.Variables.TableInfo.NumofCardsforEachPlayer[4]++;
                    Information.Variables.Card_Chips.CardLocationWidth[4] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[4, Information.Variables.TableInfo.NumofCardsforEachPlayer[4]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[4] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[4, Information.Variables.TableInfo.NumofCardsforEachPlayer[4]], Information.Variables.TableInfo.HandValuesForEachSeat[4]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();
                    break;
                    case 5:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[5], Information.Variables.Card_Chips.CardLocationHeight[5]), this);
                    Information.Variables.TableInfo.NumofCardsforEachPlayer[5]++;
                    Information.Variables.Card_Chips.CardLocationWidth[5] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[5, Information.Variables.TableInfo.NumofCardsforEachPlayer[5]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[5] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[5, Information.Variables.TableInfo.NumofCardsforEachPlayer[5]], Information.Variables.TableInfo.HandValuesForEachSeat[5]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();
                    break;
                    case 6:
                    Information.Variables.Card_Chips.card[Information.Variables.Player.PlayerSeat, Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[6], Information.Variables.Card_Chips.CardLocationHeight[6]), this);
                    Information.Variables.TableInfo.NumofCardsforEachPlayer[6]++;
                    Information.Variables.Card_Chips.CardLocationWidth[6] += 20;
                        Information.Variables.TableInfo.HandsForEachSeat[6, Information.Variables.TableInfo.NumofCardsforEachPlayer[6]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                        Information.Variables.TableInfo.HandValuesForEachSeat[6] = calc.HandCalc(Information.Variables.TableInfo.HandsForEachSeat[6, Information.Variables.TableInfo.NumofCardsforEachPlayer[6]], Information.Variables.TableInfo.HandValuesForEachSeat[6]);

                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    UpdateGUI();
                    break;

                }

                
        }
        private void BtnStay_Click(object sender, EventArgs e)
        {
            Information.Variables.Player.timer.Stop();
            Calculations calc = new Calculations();
            Mechanic mech = new Mechanic();
            pbDealerHideCard.Visible = false;
            Information.Variables.Dealer.DealerHandValue = calc.HandCalc(Information.Variables.Dealer.DealerHand[1], Information.Variables.Dealer.DealerHandValue);
            UpdateGUI();
            Information.Variables.TableActions.CurrentPlayerTurn = "DEALER";
            calc.DealerRulesCheck();
            testlbl.Text = Information.Variables.Dealer.DealerAction;


            //Dealer plays
            while (Information.Variables.TableActions.CurrentPlayerTurn == "DEALER")
            {
                Thread.Sleep(1500);
                if (Information.Variables.Dealer.DealerAction == "HIT")
                {

                    Information.Variables.Card_Chips.card[0, Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.Card(new Point(Information.Variables.Card_Chips.CardLocationWidth[0], Information.Variables.Card_Chips.CardLocationHeight[0]), this);
                    Information.Variables.Dealer.DealerHand[Information.Variables.TableInfo.NumofCardsforEachPlayer[0]] = mech.CardId(Information.Variables.Card_Chips.BaseDeck[0]);
                    Information.Variables.Dealer.DealerHandValue = calc.HandCalc(Information.Variables.Dealer.DealerHand[Information.Variables.TableInfo.NumofCardsforEachPlayer[0]], Information.Variables.Dealer.DealerHandValue);

                    Information.Variables.TableInfo.NumofCardsforEachPlayer[0]++;
                    Information.Variables.Card_Chips.discardPileImage.Add(Information.Variables.Card_Chips.cards[0]);
                    Information.Variables.Card_Chips.discardPile.Add(Information.Variables.Card_Chips.BaseDeck[0]);

                    Information.Variables.Card_Chips.cards.RemoveAt(0);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(0);

                    Information.Variables.Card_Chips.CardLocationWidth[0] += 20;

                    UpdateGUI();

                    calc.DealerRulesCheck();
                    testlbl.Text = Information.Variables.Dealer.DealerAction;
                }

                if (Information.Variables.Dealer.DealerAction == "STAY")
                {
                    break;
                }
            }
            // CPU

            testlbl.Text = calc.whoWon();
            btnReset.Visible = true;
        }

        private void BtnStartingInformation_Click(object sender, EventArgs e)
        {
            //player name
            Information.Variables.Player.PlayerName = txtbxPlayerName.Text;
            pnlPlayerInfo.Visible = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Cards card = new Cards();
            GUI gui = new GUI();

            lblPlayerBank.Text = Information.Variables.Player.PlayerBank.ToString();

            gui.ResetChipImage(btnChipsSeat1, btnChipsSeat2, btnChipsSeat3, btnChipsSeat4, btnChipsSeat5, btnChipsSeat6);

            Information.Variables.TableActions.isBetSet = false;
            Information.Variables.TableInfo.isGameActive = false;

            int seat = 0;
            int cards = 0;
            while (seat < 7)
            {
                while (cards < Information.Variables.TableInfo.NumofCardsforEachPlayer[seat])
                {
                    Information.Variables.Card_Chips.card[seat, cards].Dispose();
                    Information.Variables.TableInfo.HandsForEachSeat[seat, cards] = " ";
                    cards++;

                }
                seat++;
                cards = 0;
            }
            pnlPlayerOpt.Visible = false;
            btnReset.Visible = false;

            int i = 0;
            while (i < 7)
            {
                Information.Variables.TableInfo.HandValuesForEachSeat[i] = 0;
                i++;
            }
            i = 0;
            while (i < Information.Variables.TableInfo.NumofCardsforEachPlayer[0])
            {
                Information.Variables.Card_Chips.card[0, i].Dispose();
                i++;
            }
            i = 0;
            while (i < 7)
            {
                Information.Variables.TableInfo.NumofCardsforEachPlayer[i] = 0;
                i++;
            }

            Information.Variables.Dealer.DealerHandValue = 0;
            card.InitiateStartingCardLocation();
            DealerHandValue.Text = "0";
            lblHandValueGUI.Text = "0";
            txtbxHandGUI.Text = " ";
            testlbl.Text = " ";
           
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            GUI gui = new GUI();
            Mechanic mech = new Mechanic();
            if(Information.Variables.TableActions.isPlayerSeated !=true)
            {
                MessageBox.Show("You are not seated at the table, and are unable to make a bet. Please take a seat");
                
            }
            if (Information.Variables.TableActions.isPlayerSeated == true && Information.Variables.TableActions.isBetSet != true)
            {
                gui.setChipImage(cbBetAmount, btnChipsSeat1, btnChipsSeat2, btnChipsSeat3, btnChipsSeat4, btnChipsSeat5, btnChipsSeat6);

                Information.Variables.TableInfo.BetAmount = mech.SetBetAmount(cbBetAmount);
                lblbetamount.Text = gui.UpdateGUIBetAmount();
            }
            if(Information.Variables.TableActions.isPlayerSeated == true && Information.Variables.TableActions.isBetSet == true)
            {
                MessageBox.Show("You have placed your bet!");
            }
            
        }
    }
}
