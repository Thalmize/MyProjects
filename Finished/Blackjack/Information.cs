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
    class Information
    {
        public Information() { }
        internal static class Variables
        {
            internal static class Player
            {
                public static string PlayerName;
                public static int PlayerSeat;
                public static int PlayerBank = 500;
                public static Timer timer = new Timer();

            }
            internal static class CPU
            {
                public static int[] CPUActive = new int[6];
            }
            internal static class Dealer
            {
                public static string[] DealerHand = new string[10];
                public static PictureBox[] dealercard = new PictureBox[10];
                public static int NumofCardsforDealer;
                public static int DealerHandValue;
                public static bool DealerHasBlackjack;
                public static string DealerAction;
                public static bool dealerBust;
            }
            internal static class Card_Chips
            {
                public static List<Image> cards = new List<Image>();
                public static List<Image> chip = new List<Image>();
                public static List<Image> discardPileImage = new List<Image>();
                public static List<string> discardPile = new List<string>();
                public static PictureBox[,] card = new PictureBox[7, 10];

                public static int Deck_count = 6;
                public static List<string> BaseDeck = new List<string>();
                public static int[] CardLocationHeight = new int[7];
                public static int[] CardLocationWidth = new int[7];
            }
            internal static class GUI
            {
                public static int[] LeaveButtonLocationWidth = new int[7];
                public static int[] LeaveButtonLocationHeight = new int[7];
            }
            internal static class TableInfo
            {
                public static int[] HandValuesForEachSeat = new int[7];
                public static int BetAmount;
                public static string[,] HandsForEachSeat = new string[7, 10];
                public static int[] NumofCardsforEachPlayer = new int[7];
                public static bool isGameActive;
            }
            internal static class TableActions
            {
               
                public static bool playerBust;
                public static bool isPlayerSeated;
                public static string CurrentPlayerTurn;
                public static bool isBetSet;
                public static int PlayerTimer;

            }

        }
        
    }
}
