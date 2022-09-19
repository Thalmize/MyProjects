using System;
using static System.Console;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NEEDS
             * - Allow user to input number of sides on dice, and how many times it needs to be rolled
             * - Program should simulate dice rolls and track how many times each number comes up
             * SUBGOALS
             * - user prompt for incorrect entry
             * - program needs to loop, or have loop ability
             * - print out how many times each side appeared, also print percentage it appeared. Round to 2 dec places
             * BONUS
             * - board game dice, create program that draws 2 six sided dice
             * - allow user to quit or roll again
             * - allow user to select number of dice to be drawn on screen: (1-4), add dice and display them
             * 
             */
            var menu = new Menu();
            ///////////////////////////////////////////////
            //Menu options
            WriteLine("Welcome!");
            WriteLine("Choose your option below: ");
            WriteLine("1 - Simulation Dice Rolling");
            WriteLine("2 - Board Game Dice");
            Write("Which option would you like: ");
            byte input = Convert.ToByte(ReadLine());
            switch(input)
            {
                case 1:
                    menu.SimulationDiceRolls();
                    break;
                case 2:
                    menu.BoardGameDice();
                    break;
            }
            //initate rolling prompt
           
            
        }
    }
}
