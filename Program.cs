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
            string computer;
            while (playAgain)
            {
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter Rock , Paper or Scissors");
                    player = Console.ReadLine();
                    //converting to upper for consistency
                    player = player.ToUpper();
                }
                



            }
        }
    }
}
