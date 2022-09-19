using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DiceRolling
{
    class Simulation
    {
        public int[] Percentage;
        public Simulation() { }

        public int[] SimulateDiceRoll(int diceSides, int diceRolls) 
        {
            int[] resultOfRoll = new int[diceRolls];
            Percentage =  new int[diceSides + 1];

            var rand = new Random();
            int timesRolled = 0;
            while (timesRolled < diceRolls)
            {
                resultOfRoll[timesRolled] = rand.Next(1, diceSides + 1);
                Percentage[0] = timesRolled;
                Percentage[resultOfRoll[timesRolled]]++;
                timesRolled++;
            }
            return resultOfRoll;
        }
    }
}
