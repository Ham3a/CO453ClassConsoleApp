using System;

namespace CO453ClassConsoleApp.SPS
{
    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        ROCK,
        PAPER,
        SCISSORS
    }

    /// <summary>
    /// This class plays ...
    /// Author: Derek
    /// Started: 12/02/2019
    /// Modified : 26/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string ROCK = "ROCK";
        public const string PAPER = "PAPER";
        public const string SCISSORS = "SCISSORS";

        public const string UNKOWN = "UNKNOWN";

        public string PlayerName { get; set; }
        public string ComputerName { get; set; }
        public string ComputerChoice { get; set; }
        public string PlayerChoice { get; set; }
        public string Winner { get; set; }

        private Random randomGenerator = new Random();

         public void Start()
        {
            PlayerName = "Derek";
            ComputerName = "Computer";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
             Winner = "No Winner";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);  

            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else 
            {
                ComputerChoice = UNKOWN;
            }
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "You have Drawn!!!";
            }
            else
            {
                Winner = "Not Yet Determined!!!";
            }

        }
    }
}
