using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BillibleHoursClock
{
    class Menu
    {
        public Menu () { }

        public void openingMenu()
        {
            byte input = 0;
            WriteLine("Menu");
            WriteLine("1 - Start new Stopwatch");
            WriteLine("2 - Exit");
            Write("Option: ");

            if (input != 1 || input != 2)
            {
                WriteLine("Sorry that is not an option! Try Again!");
                openingMenu();
            }
            else if (input == 1)
            {

            }
            else
            {
                Environment.Exit(0);
            }
        }
        public void menuNewStopwatch()
        {
            Clear();
                        
        }
    }
}
