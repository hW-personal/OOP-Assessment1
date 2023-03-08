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

        //public int Value { get; set; }
        //public int Suit { get; set; }

        private int value;
        private int suit;

        Card card = new Card();
        card.Value = 1; //minimum value
        card.Suit = 1; //minmum suit
        Console.WriteLine($"Value: {card.Value}, Suit: {card.Suit}");

        card.Value = 13; //maximum value
        card.Suit = 4; //maximum suit
        Console.WriteLine($"Value: {card.Value}, Suit: {card.Suit}");




        public int Value
        {
            get { return Value ; }
            set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentException("Invalid card value.");
                }
                this.value = value;
            }

        }

        public int Suit
        {
            get { return Suit ; }
            set
            { 
                if (value < 1 || value > 4 )
                {
                    throw new ArgumentException("Invalid card suit.");
                }
                this.suit = value ;
            }
        }
    }
}
