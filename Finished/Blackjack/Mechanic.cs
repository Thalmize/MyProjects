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
    class Mechanic
    {
        public Mechanic() { }


        public PictureBox Card(Point location, Main main)
        {
            PictureBox card = new PictureBox();

            card.Enabled = true;
            card.Visible = true;
            card.Size = new Size(35, 62);
            card.BackgroundImageLayout = ImageLayout.Center;
            card.Location = location;
            card.BringToFront();
            main.Controls.Add(card);
            card.BackgroundImage = Information.Variables.Card_Chips.cards[0];
            return card;
        }
          
        public string CardId(string card)
        {
            string result;
            var temp = card;
            var test = temp.Split('|');
            string[] dump = new string[2];

            dump[0] = test[0];
            result = dump[0];
            dump[1] = test[1];

            return result;
        }

        public int SetBetAmount(ComboBox cbBetAmount)
        {
            int betamount = 0;
           switch(cbBetAmount.SelectedIndex)
            {
                case 0:
                    betamount = 5;
                    return betamount;
                case 1:
                    betamount = 10;
                    return betamount;
                case 2:
                    betamount = 20;
                    return betamount;
                case 3:
                    betamount = 50;
                    return betamount;
                case 4:
                    betamount = 100;
                    return betamount;
            }
            return betamount;
        }
    }

}
