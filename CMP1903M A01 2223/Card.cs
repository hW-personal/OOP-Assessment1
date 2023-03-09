using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        //There are 52 cards in a deck

        /*public int Value { get; set; }
        //public int Suit { get; set; }
        */

        private int _value;
        private int _suit;


        //  Card constructor
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public int Value
        {

            //  Getter and Setter method to return the value of the card
            get { return _value; }
            set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentException("Invalid card value.");
                }
                _value = value;
            }

        }

        public int Suit
        {

            //  Getter and Setter method to return the suit of the card
            get { return _suit; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Invalid card suit.");
                }
                _suit = value;
            }
        }


        //  Returns a phrase based off of the given suit/value applied to the two array of strings
        public override string ToString()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            return values[Value - 1] + " of " + suits[Suit - 1];
        }
    }
}