using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // wow

            string answer = "";
            do {
                Console.WriteLine("Rock Paper Scissors?");

                Console.WriteLine("Player 1 please enter your choice!");

                string hand1 = Console.ReadLine().ToLower();

                Console.WriteLine("Player 2 please eneter your choice!");
                // julio did shit

                string hand2 = Console.ReadLine().ToLower();

                if (hand1 == hand2) {
                    Console.WriteLine("Its a tie!");
                }
                else if (hand1 == "rock" && hand2 == "paper")
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                //julio who?
                else if (hand1 == "paper" && hand2 == "rock") {

                    Console.WriteLine("Player 1 Wins!");
                }

                else if (hand1 == "scissors" && hand2 == "paper")
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (hand1 == "paper" && hand2 == "scissors")
                {
                    Console.WriteLine("Player 2 Wins!");
                }

                else if (hand1 == "scissors" && hand2 == "rock")
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (hand1 == "rock" && hand2 == "scissors") {
                    Console.WriteLine("Player 2 Wins!");
                }
                Console.WriteLine("Continue? yes or no");
                
                answer = Console.ReadLine().ToLower();
            }
            
            while (answer == "yes");

            Console.WriteLine("You'll be back");







        }
    }
}
