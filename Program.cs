using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperSiccors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //? ttt
            Random random = new Random();
            bool playAgain = true;
            string player = "";
            string computer = "";
            while (playAgain == true)
            {
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter Rock , Paper or Scissors");
                    player = Console.ReadLine();
                    //converting to upper for consistency
                    player = player.ToUpper();
                }
                //? now we will create the random for computer
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }
                Console.WriteLine("Player:- " + player);
                Console.WriteLine("Computer:-" + computer);
                //now we compare both the computer and the player and decide who wins
                switch (player)
                {
                    case "ROCK":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("Computer Wins");
                        }
                        else if (computer == player)
                        {
                            Console.WriteLine("Draw");
                        }
                        else Console.WriteLine("Player Wins");
                        break;
                    case "PAPER":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("Computer Wins");
                        }
                        else if (computer == player)
                        {
                            Console.WriteLine("Draw");
                        }
                        else Console.WriteLine("Player Wins");
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Computer Wins");
                        }
                        else if (computer == player)
                        {
                            Console.WriteLine("Draw");
                        }
                        else Console.WriteLine("Player Wins");
                        break;
                }
                Console.WriteLine("Do you want to play again (y/n)");
                if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                {
                    playAgain= true;
                    player = "";
                    computer = "";
                }
                else playAgain= false;
            }
        }
    }
}
