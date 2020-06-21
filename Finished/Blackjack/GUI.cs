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

namespace BlackJack
{
    class GUI
    {
        public GUI() { }

        public void LeaveSeatLocation()
        {
            
            Information.Variables.GUI.LeaveButtonLocationWidth[1] = 14;
            Information.Variables.GUI.LeaveButtonLocationWidth[2] = 106;
            Information.Variables.GUI.LeaveButtonLocationWidth[3] = 366;
            Information.Variables.GUI.LeaveButtonLocationWidth[4] = 807;
            Information.Variables.GUI.LeaveButtonLocationWidth[5] = 1042;
            Information.Variables.GUI.LeaveButtonLocationWidth[6] = 1141;

            Information.Variables.GUI.LeaveButtonLocationHeight[1] = 198;
            Information.Variables.GUI.LeaveButtonLocationHeight[2] = 444;
            Information.Variables.GUI.LeaveButtonLocationHeight[3] = 636;
            Information.Variables.GUI.LeaveButtonLocationHeight[4] = 636;
            Information.Variables.GUI.LeaveButtonLocationHeight[5] = 444;
            Information.Variables.GUI.LeaveButtonLocationHeight[6] = 198;

        }
        public void ResetChipImage(Button btnchip1, Button btnchip2, Button btnchip3, Button btnchip4, Button btnchip5, Button btnchip6 )
        {
            switch(Information.Variables.Player.PlayerSeat)
            {
                case 1:
                    btnchip1.Image = Information.Variables.Card_Chips.chip[0];
                    break;
                case 2:
                    btnchip2.Image = Information.Variables.Card_Chips.chip[0];
                    break;
                case 3:
                    btnchip3.Image = Information.Variables.Card_Chips.chip[0];
                    break;
                case 4:
                    btnchip4.Image = Information.Variables.Card_Chips.chip[0];
                    break;
                case 5:
                    btnchip5.Image = Information.Variables.Card_Chips.chip[0];
                    break;
                case 6:
                    btnchip6.Image = Information.Variables.Card_Chips.chip[0];
                    break;
            }
        }
        public string UpdateGUIDealer()
        {
            string dealerhandvalue = Information.Variables.Dealer.DealerHandValue.ToString();

            return dealerhandvalue;
        }
        public string UpdateGUIHand(TextBox hand)
        {
            hand.Clear();
            int i = 0;

            while (i <= Information.Variables.TableInfo.NumofCardsforEachPlayer[Information.Variables.Player.PlayerSeat])
            {
                hand.AppendText(Information.Variables.TableInfo.HandsForEachSeat[Information.Variables.Player.PlayerSeat, i] + " ");
                i++;
            }
            return hand.Text;
        }
        public string UpdateGUIHandValue()
        {
            string handvalue = Information.Variables.TableInfo.HandValuesForEachSeat[Information.Variables.Player.PlayerSeat].ToString();
            return handvalue;
        }
        public string UpdateGUIBetAmount()
        {
            string betamount = Information.Variables.TableInfo.BetAmount.ToString();

            return betamount;
        }
        public void setChipImage(ComboBox cbBetAmount, Button btnChipsSeat1, Button btnChipsSeat2, Button btnChipsSeat3, Button btnChipsSeat4, Button btnChipsSeat5, Button btnChipsSeat6)
        {
            switch (Information.Variables.Player.PlayerSeat)
            {
                case 1:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat1.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat1.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat1.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat1.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat1.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;
                case 2:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat2.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat2.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat2.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat2.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat2.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;
                case 3:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat3.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat3.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat3.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat3.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat3.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;
                case 4:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat4.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat4.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat4.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat4.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat4.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;
                case 5:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat5.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat5.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat5.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat5.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat5.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;
                case 6:
                    switch (cbBetAmount.SelectedIndex)
                    {
                        case 0:
                            btnChipsSeat6.Image = Information.Variables.Card_Chips.chip[1];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 1:
                            btnChipsSeat6.Image = Information.Variables.Card_Chips.chip[2];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 2:
                            btnChipsSeat6.Image = Information.Variables.Card_Chips.chip[3];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 3:
                            btnChipsSeat6.Image = Information.Variables.Card_Chips.chip[4];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                        case 4:
                            btnChipsSeat6.Image = Information.Variables.Card_Chips.chip[5];
                            Information.Variables.TableActions.isBetSet = true;
                            break;
                    }
                    break;

            }
        }
    }
}
