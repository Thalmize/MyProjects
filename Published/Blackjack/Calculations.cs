using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJack
{
    class Calculations
    {
        public Calculations(){}
        
        public int BetCalc(int chipSel)
        {
            int amount = 0;
            switch (chipSel)
            {
                case 0:
                    amount = amount + 0;
                    return amount;
                case 1:
                    amount = amount + 5;
                    return amount;
                case 2:
                    amount = amount + 10;
                    return amount;
                case 3:
                    amount = amount + 20;
                    return amount;
                case 4:
                    amount = amount + 50;
                    return amount;
                case 5:
                    amount = amount + 100;
                    return amount;

            }

            return amount;
            
        }

        public int HandCalc(string hand, int prevValue)
        {
            int value = 0;
            switch (hand)
            {
                case "10":
                    value = 10;
                    break;
                case "J":
                    value = 10;
                    break;
                case "Q":
                    value = 10;
                    break;
                case "K":
                    value = 10;
                    break;
                case "A":
                    value = 11;
                    break;
                default:
                    value = Convert.ToInt32(hand);
                    break;
            }
            prevValue = prevValue + value;

            return prevValue;
        }
        

        public void DealerRulesCheck()
        {
            Information.Variables.Dealer.DealerHasBlackjack = doesDealerHaveBlackjack();
            if (Information.Variables.Dealer.DealerHasBlackjack == true)
            {
                // goes to calculating wins/losses
                Information.Variables.Player.PlayerBank -= Information.Variables.TableInfo.BetAmount;
            }
             else
            {
                Information.Variables.Dealer.DealerAction = canDealerHitorStay();
            }
        }

        public string canDealerHitorStay()
        {
            if (Information.Variables.Dealer.DealerHandValue <= 16)
            {
                return "HIT";
            }
           else
            {
                if (Information.Variables.Dealer.DealerHandValue >= 17 && Information.Variables.Dealer.DealerHandValue < 21 )
                {
                return "STAY";
                }
                return "STAY";
            }
            
        }
        public bool doesDealerHaveBlackjack()
        {
            if (Information.Variables.Dealer.DealerHand[0] == "A")
            {
                if (Information.Variables.Dealer.DealerHand[1] =="10" || Information.Variables.Dealer.DealerHand[1] == "J" || Information.Variables.Dealer.DealerHand[1] == "Q" ||
                    Information.Variables.Dealer.DealerHand[1] == "K")
                {
                    return true;
                }
            }
            return false;
        }

        public bool didPlayerBust()
        {
            if(Information.Variables.TableInfo.HandValuesForEachSeat[Information.Variables.Player.PlayerSeat] > 21)
            {
                return true;
            }

            return false;
        }
        public bool didDealerBust()
        {
            if (Information.Variables.Dealer.DealerHandValue > 21)
            {
                return true;
            }

            return false;
        }
        public string whoWon()
        {
            Information.Variables.TableActions.playerBust = didPlayerBust();
            Information.Variables.Dealer.dealerBust = didDealerBust();
            //player wins
            switch(Information.Variables.TableActions.playerBust)
            {
                case true:
                    Information.Variables.Player.PlayerBank -= Information.Variables.TableInfo.BetAmount;
                    return "Dealer Wins";
                    
                case false:
                    if (Information.Variables.TableInfo.HandValuesForEachSeat[Information.Variables.Player.PlayerSeat] > Information.Variables.Dealer.DealerHandValue)
                    {
                        Information.Variables.Player.PlayerBank += (Information.Variables.TableInfo.BetAmount * 2);
                        return "Player Wins";

                    }
                    break;
            }
            switch (Information.Variables.Dealer.dealerBust)
            {
                case true:
                    Information.Variables.Player.PlayerBank += (Information.Variables.TableInfo.BetAmount * 2);
                    return "Player Wins";

                case false:
                    if (Information.Variables.TableInfo.HandValuesForEachSeat[Information.Variables.Player.PlayerSeat] < Information.Variables.Dealer.DealerHandValue)
                    {
                        Information.Variables.Player.PlayerBank -= Information.Variables.TableInfo.BetAmount;
                        return "Dealer Wins";
                    }
                    break;

            }
            if (Information.Variables.TableInfo.HandValuesForEachSeat[Information.Variables.Player.PlayerSeat] == Information.Variables.Dealer.DealerHandValue)
            {
                return "TIE";
            }
            Information.Variables.Player.PlayerBank -= Information.Variables.TableInfo.BetAmount;
            return "Dealer Wins";
        }

    }
}
