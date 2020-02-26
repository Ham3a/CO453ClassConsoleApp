using System;

namespace CO453ClassConsoleApp.SPS
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the SPS Game
    /// </summary>
    public class GameController
    {
        public static string Title = "Scissors-Paper-Stone Game";

        public const int MAXN_TURNS = 3;

        private RPS_Game game = new RPS_Game();

        private string playerName = "Derek";

        private int turn;

        public void RunGame()
        {
            SetupScreen();
            StartGame();

            for(turn = 1; turn <= MAXN_TURNS; turn++)
            {
                GetPlayerChoice();
                game.GetComputerChoice();

                ShowChoices();

                game.WorkoutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            game.End();
            EndGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private void EndGame()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("The overall winner is " + game.Winner);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

            string[] choices = new string [] 
            { 
                RPS_Game.SCISSORS, 
                RPS_Game.PAPER, 
                RPS_Game.ROCK 
            };

            int choiceNo = SimpleIO.GetChoice(choices);
            game.PlayerChoice = choices[choiceNo - 1];

            Console.WriteLine();
        }

        /// <summary>
        /// This method draws out an image of the choice for
        /// either the computer, or the player.  The player's
        /// choice is drawn at (x = 5, y = 14) and the computers 
        /// choice at (x = 50, y = 14)
        /// FIND THE SINGLE MISTAKE!!!
        /// </summary>
        private void DrawChoice(RPS_Players player)
        {
            string choice;
            int x;
            int y = 14;

            if (player == RPS_Players.COMPUTER)
            {
                x = 5;
                choice = game.ComputerChoice;
            }
            else
            {
                choice = game.PlayerChoice;
                x = 5;
            }

            if (choice == RPS_Game.SCISSORS)
            {
                Images.DrawScissors(x, y);
            }
            else if (choice == RPS_Game.PAPER)
            {
                Images.DrawPaper(x, y);
            }
            else if (choice == RPS_Game.ROCK)
            {
                Images.DrawStone(x, y);
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowChoices()
        {
            DrawChoice(RPS_Players.PLAYER);
            DrawChoice(RPS_Players.COMPUTER);

            Console.WriteLine("\n\tYou picked " + game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + game.ComputerChoice);
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("\tThe current winner is the " + game.Winner);
            Console.WriteLine();
            Console.WriteLine("\tThe player has won ");
            Console.WriteLine("\tThe computer has won ");
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = Title;

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void StartGame()
        {
            SimpleIO.WriteTitle(Title, "Week 3");
            game.Start();
        }
    }
}
