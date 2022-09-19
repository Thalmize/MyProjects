using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DiceRolling
{
    class Menu
    {
        public Menu() { }

        public void SimulationDiceRolls()
        {
            var sim = new Simulation();
            int[] RollResults;
            bool isDiceRollingActive = true;
            bool inputcheck;

            while (isDiceRollingActive)
            {
                inputcheck = false;

                Write("How many sides to the dice are there: ");
                int inputSides = Convert.ToInt32(ReadLine());
                Write("How many times is this dice being rolled: ");
                int inputRoll = Convert.ToInt32(ReadLine());
                //instantiate results for rolls
                RollResults = new int[inputSides];
                RollResults = sim.SimulateDiceRoll(inputSides, inputRoll);
                sim.Percentage[0]++;

                for (int x = 1; x < inputRoll + 1; x++)
                {
                    WriteLine($"Roll {x}: [{RollResults[x - 1]}]");
                }
                for (int y = 1; y <= inputSides; y++)
                {
                    decimal percent = (decimal)sim.Percentage[y] / (decimal)sim.Percentage[0];
                    WriteLine($"Dice Side: [{y}] - {sim.Percentage[y]} / {sim.Percentage[0]} {string.Format("{0:0.#####}", percent)}");

                }
                //asks to roll again
                string inputPlayAgain = null;
                WriteLine("Would you like to roll again?");
                Write("yes (y) or no (n): ");
                inputPlayAgain = ReadLine().ToLower();

                while (!inputcheck)
                {
                    if (inputPlayAgain.Length > 1)
                    {
                        WriteLine("Sorry that is not valid! Try Again!!");
                        WriteLine("Would you like to roll again?");
                        Write("yes (y) or no (n): ");
                        inputPlayAgain = ReadLine().ToLower();
                    }
                    else if (inputPlayAgain == "n")
                    {
                        isDiceRollingActive = false;
                        break;
                    }
                    else if (inputPlayAgain != "y")
                    {
                        WriteLine("Sorry that is not valid! Try Again!!");
                        WriteLine("Would you like to roll again?");
                        Write("yes (y) or no (n): ");
                        inputPlayAgain = ReadLine().ToLower();
                    }
                    else inputcheck = true;
                }
            }
        }

        public void BoardGameDice()
        {
            Write("How many dice are you playing with: ");
            byte inputNumofDice = Convert.ToByte(ReadLine());
            Write("How many sides are their for each dice: ");
            byte inputNumofSides = Convert.ToByte(ReadLine());

            bool startBoardGameDice = true;

            while (startBoardGameDice)
            {

            }
        }
    }
}
