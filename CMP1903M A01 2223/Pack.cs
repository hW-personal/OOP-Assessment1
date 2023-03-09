using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //  Static list containing all the cards
        static List<Card> pack;

        //  Initialising the card pack
        public Pack()
        {
            pack = new List<Card>();

            //  For every suit and value combination, create a new card, then add it to the pack
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //  Shuffles the pack based on the type of shuffle
            //  typeOfShuffle must be
            //      1. Fisher-Yates
            //      2. Riffle Shuffle
            //      3. No Shuffle


            //  1. Fisher-Yates Shuffle
            //      Iterate over the cards in the pack from the last index to the first index
            if (typeOfShuffle == 1)
            {
                Random random = new Random();
                for (int i = (pack.Count - 1); i > 0; i--)
                {
                    //  Generate random index between 0 and 1 then assigns it to j
                    int j = random.Next(i + 1);

                    //  Swap cards at given indexes
                    Card temp = pack[j];
                    pack[j] = pack[i];
                    pack[i] = temp;
                }
                return true;
            }


            //  2. Riffle Shuffle
            //      Split pack into halves
            //      While both halves are not empty, randomly select a card from one of the halves and add it to the pack
            else if (typeOfShuffle == 2)
            {
                List<Card> leftHalf = pack.GetRange(0, pack.Count / 2);
                List<Card> rightHalf = pack.GetRange(pack.Count / 2, pack.Count - pack.Count / 2);

                pack.Clear();
                
                Random random = new Random();
                while (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    if (random.NextDouble() < 0.5)
                    {
                        pack.Add(leftHalf[0]);
                        leftHalf.RemoveAt(0);
                    }
                    else
                    {
                        pack.Add(rightHalf[0]);
                        rightHalf.RemoveAt(0);
                    }
                }

                // Adds the remaining cards from both halves back to the pack
                pack.AddRange(leftHalf);
                pack.AddRange(rightHalf);
                return true;
            }

            //  3. No Shuffle
            else if (typeOfShuffle == 3)
            {
                return true;
            }
            return false;

        }
        public static Card deal()
        {
            //  Deals one card
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //  Deals the number of cards specified by 'amount'
            List<Card> cards = pack.GetRange(0, amount);
            pack.RemoveRange(0, amount);
            return cards;
        }


        //  Returns pack list
        public override string ToString()
        {
            string result = "";
            foreach (Card card in pack)
            {
                result += card.ToString() + "\n";
            }
            return result;
        }
    }
}
