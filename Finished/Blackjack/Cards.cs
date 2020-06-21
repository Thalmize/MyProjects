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
    class Cards
    {
        
        public Cards()    {        }
               
        public void InitiateStartingCardLocation()
        {
            Information.Variables.Card_Chips.CardLocationHeight[0] = 62; //dealer
            Information.Variables.Card_Chips.CardLocationHeight[1] = 42;
            Information.Variables.Card_Chips.CardLocationHeight[2] = 159;
            Information.Variables.Card_Chips.CardLocationHeight[3] = 273;
            Information.Variables.Card_Chips.CardLocationHeight[4] = 273;
            Information.Variables.Card_Chips.CardLocationHeight[5] = 159;
            Information.Variables.Card_Chips.CardLocationHeight[6] = 42;

            Information.Variables.Card_Chips.CardLocationWidth[0] = 534; //dealer
            Information.Variables.Card_Chips.CardLocationWidth[1] = 289;
            Information.Variables.Card_Chips.CardLocationWidth[2] = 316;
            Information.Variables.Card_Chips.CardLocationWidth[3] = 465;
            Information.Variables.Card_Chips.CardLocationWidth[4] = 776;
            Information.Variables.Card_Chips.CardLocationWidth[5] = 919;
            Information.Variables.Card_Chips.CardLocationWidth[6] = 930;
        }
        public void InitiateBaseDeck()
        {
        // 0-12 Clubs                                     
                                                                    
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/2c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("2|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/3c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("3|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/4c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("4|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/5c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("5|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/6c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("6|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/7c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("7|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/8c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("8|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/9c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("9|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/10c.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("10|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/Jc.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("J|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/Qc.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("Q|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/Kc.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("K|c");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Clubs/Ac.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("A|c");
            //13-25 spades
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/2s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("2|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/3s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("3|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/4s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("4|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/5s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("5|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/6s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("6|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/7s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("7|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/8s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("8|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/9s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("9|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/10s.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("10|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/Js.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("J|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/Qs.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("Q|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/Ks.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("K|s");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Spades/As.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("A|s");
            //26-38 - Diamonds
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/2d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("2|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/3d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("3|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/4d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("4|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/5d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("5|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/6d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("6|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/7d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("7|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/8d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("8|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/9d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("9|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/10d.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("10|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/Jd.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("J|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/Qd.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("Q|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/Kd.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("K|d");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Diamonds/Ad.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("A|d");
            //39-51- Hearts

            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/2h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("2|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/3h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("3|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/4h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("4|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/5h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("5|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/6h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("6|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/7h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("7|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/8h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("8|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/9h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("9|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/10h.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("10|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/Jh.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("J|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/Qh.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("Q|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/Kh.png"));
            Information.Variables.Card_Chips.BaseDeck.Add("K|h");
            Information.Variables.Card_Chips.cards.Add(Image.FromFile("../../../BlackJack/Cards/Hearts/Ah.png"));//311
            Information.Variables.Card_Chips.BaseDeck.Add("A|h");
        }
        
        public void InitiateChipImages()
        {
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipBase.png"));
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipFIVE.png"));
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipTEN.png"));
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipTWENTY.png"));
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipFIFTY.png"));
            Information.Variables.Card_Chips.chip.Add(Image.FromFile("../../../BlackJack/Cards/Chips/ChipHUNDRED.png"));
        }
        public void Creating_Deck()
        {
            int temp = (Information.Variables.Card_Chips.Deck_count * 51);
            while (Information.Variables.Card_Chips.BaseDeck.Count < temp)
            {
                InitiateBaseDeck();
            }
        }
        
        public void Shuffling_Deck()
        {
            Random r = new Random();
            int t = 1;
            
            List<Image> image_shuffle = new List<Image>();
            List<string> card_shuffle = new List<string>();
             int totalcards = 311;
            while (t < 7)
            {
                while (totalcards != 0)
                {
                    int num = r.Next(0, totalcards);
                    image_shuffle.Add(Information.Variables.Card_Chips.cards[num]);
                    card_shuffle.Add(Information.Variables.Card_Chips.BaseDeck[num]);
                    Information.Variables.Card_Chips.cards.RemoveAt(num);
                    Information.Variables.Card_Chips.BaseDeck.RemoveAt(num);
                   
                    totalcards--;
                }
                while (totalcards != 311)
                {
                    Information.Variables.Card_Chips.cards.Add(image_shuffle[0]);
                    Information.Variables.Card_Chips.BaseDeck.Add(card_shuffle[0]);
                    image_shuffle.RemoveAt(0);
                    card_shuffle.RemoveAt(0);
                    
                    totalcards++;
                    
                }
                
                t++;
            }
        }

        public bool ReShufflingDeckCheck()
        {
            if (Information.Variables.Card_Chips.BaseDeck.Count <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
