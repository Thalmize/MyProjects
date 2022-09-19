using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace RockPaperScissors
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var mech = new Mechanics();
            var results = new Results();
            bool inputCheck = false;
            //Asks player to pick between rock paper and scissors
            //Computer chooses move
            //compare and determine who wins

            WriteLine("Welcome to Rock - Paper - Scissors");

            bool isGameActive = true;
            while (isGameActive)
            {
                WriteLine("Score:");
                WriteLine($"Player: {results.playerScore}");
                WriteLine($"CPU: {results.CPUScore}");
                WriteLine($"Ties: {results.TieScore}");

                Write("Please choose (R) - Rock, (P) - Paper, or (S) - Scissors: ");
                string playerInput = Console.ReadLine().ToUpper();
                while((playerInput.Length > 1) || (inputCheck != true))
                {
                    if (playerInput == "R" || playerInput == "S" || playerInput == "P")
                    {
                        break;
                    }
                    WriteLine("Sorry that is not the correct input! Try again!!");
                    Write("Please choose (R) - Rock, (P) - Paper, or (S) - Scissors: ");
                    playerInput = Console.ReadLine().ToUpper();

                }
                string cpuTurn = mech.CPUMove();
                string playerTurn = mech.PlayerMove(playerInput);
                string result = results.CalculateResults(playerTurn, cpuTurn);

                WriteLine($"Player choose: {playerTurn}");
                WriteLine($"CPU choose: {cpuTurn}");
                WriteLine($"Result: {result}");
                
                bool isPlayingAgain = mech.PlayAgain();
                Console.Clear();
                if (!isPlayingAgain)
                {
                    isGameActive = false;
                }
            }
            
        }
        
    }
    class Mechanics
    {
        public string CPUMove()
        {
            string[] moves = new[] {
            "Rock",
            "Paper",
            "Scissors"};

            Random random = new Random();
            int number = random.Next(0, 2);

            return moves[number];
        }
        public string PlayerMove(string pInput)
        {
            string input; 

            switch(pInput)
            {
                case "R":
                    return input = "Rock";
                case "P":
                    return input = "Paper";
                case "S":
                    return input = "Scissors";
                default:
                    return input = null;
            }
        }
        public bool PlayAgain()
        {
            bool check = false;

            WriteLine("Would you like to play again?");
            Write("(Y) - Yes or (N) No: ");
            string input = Console.ReadLine().ToUpper();
            while (check != true)
            {
                if(input == "Y" || input == "N")
                {
                    break;
                }
                WriteLine("Sorry that is not the correct input. Try again!!");
                WriteLine("Would you like to play again?");
                Write("(Y) - Yes or (N) No: ");
                input = Console.ReadLine().ToUpper();
            }
            if (input != "N")
            {
                return true;
            }
            else return false;
        }
    }
    class Results
    {
        public byte playerScore = 0;
        public byte CPUScore = 0;
        public byte TieScore = 0;
        public string CalculateResults(string pTurn, string cTurn)
        {
            string result;
            // player wins
            if ((pTurn == "Rock" && cTurn == "Scissors") || (pTurn == "Paper" && cTurn == "Rock") || (pTurn == "Scissors" && cTurn == "Paper"))
            {
                playerScore++;
                return result = "Player Wins";
            }
            // cpu wins
            else if ((cTurn == "Rock" && pTurn == "Scissors") || (cTurn == "Paper" && pTurn == "Rock") || (cTurn == "Scissors" && pTurn == "Paper"))
            {
                CPUScore++;
                return result = "Cpu Wins";
            }
            // tie
            else if (pTurn == cTurn)
            {
                TieScore++;
                return result = "Tie";
            }
            else return result = null;
        }
        
        
    }
    
    
}
