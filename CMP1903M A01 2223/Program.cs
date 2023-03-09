using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the card shuffling program!");

            // ask the user if they want to run tests or shuffle
            Console.WriteLine("Would you like to run tests or shuffle the pack?");
            Console.WriteLine("1. Run tests");
            Console.WriteLine("2. Shuffle pack");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Run tests
                Testing test = new Testing();
                test.RunTests();
            }

            else if (choice == 2)
            {
                Console.WriteLine("Welcome to the card shuffling program!");

                // initializes a new pack of cards
                Pack pack = new Pack();

                // ask the user which shuffle algorithm to use
                Console.WriteLine("Which shuffle algorithm would you like to use?");
                Console.WriteLine("1. Fisher-Yates shuffle");
                Console.WriteLine("2. Riffle shuffle");
                Console.WriteLine("3. No shuffle");
                int shuffleType = Convert.ToInt32(Console.ReadLine());

                // shuffle the pack based on the user's choice
                switch (shuffleType)
                {
                    case 1:
                        Pack.shuffleCardPack(1);
                        Console.WriteLine("Pack shuffled using Fisher-Yates algorithm.");
                        break;
                    case 2:
                        Pack.shuffleCardPack(2);
                        Console.WriteLine("Pack shuffled using Riffle algorithm.");
                        break;
                    case 3:
                        Pack.shuffleCardPack(3);
                        Console.WriteLine("Pack not shuffled.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Pack not shuffled.");
                        break;
                }

                // ask the user how many cards to deal
                Console.WriteLine("How many cards would you like to deal?");
                int numCards = Convert.ToInt32(Console.ReadLine());

                // deal the requested number of cards and display them
                Console.WriteLine("Dealing {0} cards...", numCards);
                List<Card> cards = Pack.dealCard(numCards);
                foreach (Card card in cards)
                {
                    Console.WriteLine(card);
                }

                Console.Write("Press any key to continue . . . "); Console.ReadKey();
            }


            else 
            {
                Console.WriteLine("Inalid Input");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();


        }
    }
}
