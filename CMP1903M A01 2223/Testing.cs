using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        // Card creation, pack creation, shuffling, deal without amount, deal with amount
        // No interface needed
        // test for valid and invalid cases
        // i.e a card with 1 and 14 being invalid with an over max value 

        public void RunTests()
        {

            /*
                Test Card creation with valid input
                Valid card creations :
                { 0< , >0 }
                { 1 , 1 }
                ...
                { 15> , <5 }
                { 14 , 4 }
            */ 
            try
            {
                Card c1 = new Card(5, 2);
                Console.WriteLine("Test 1: Card creation with valid input passed. Result: " + c1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 1: Card creation with valid input failed. Exception: " + e.Message);
            }


            /*
                Test Card creation with invalid input
                Invalid card creations :
                { 0> , <0 }
                { 15< , >5 }
            */
            try
            {
                Card c2 = new Card(0, 5);
                Console.WriteLine("Test 2: Card creation with invalid input failed. Result: " + c2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 2: Card creation with invalid input passed. Exception: " + e.Message);
            }


            // Test Pack creation
            // As long as pack has 52 cards this will always come back as valid
            try
            {
                Pack p1 = new Pack();
                Console.WriteLine("Test 3: Pack creation passed. Result: " + p1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 3: Pack creation failed. Exception: " + e.Message);
            }


            // Test shuffling with Fisher-Yates algorithm
            try
            {
                Pack p2 = new Pack();
                Pack.shuffleCardPack(1);
                Console.WriteLine("Test 4: Shuffling with Fisher-Yates algorithm passed. Result: " + p2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 4: Shuffling with Fisher-Yates algorithm failed. Exception: " + e.Message);
            }


            // Test shuffling with Riffle algorithm
            try
            {
                Pack p3 = new Pack();
                Pack.shuffleCardPack(2);
                Console.WriteLine("Test 5: Shuffling with Riffle algorithm passed. Result: " + p3.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 5: Shuffling with Riffle algorithm failed. Exception: " + e.Message);
            }


            // Test deal without amount
            try
            {
                Pack p4 = new Pack();
                Card c3 = Pack.deal();
                Console.WriteLine("Test 6: Deal without amount passed. Result: " + c3.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 6: Deal without amount failed. Exception: " + e.Message);
            }


            // Test deal with amount
            try
            {
                Pack p5 = new Pack();
                int numCards = 5;
                Console.WriteLine("Dealing {0} cards...", numCards);
                List<Card> cards = Pack.dealCard(numCards);
                foreach (Card card in cards)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("Test 7: Deal with amount passed. Result: " + cards.Count + " cards dealt.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Test 7: Deal with amount failed. Exception: " + e.Message);
            }

            Console.Write("Press any key to continue . . . ");Console.ReadKey();
        }
    }
}
