using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Classes
{
    class Card
    {
        private string suit;
        private int value;
        private bool isFaceUp;
        private string color;
        private string faceValue;

        public string Suit
        {
            get
            {
                return this.suit;
            }
        }
        public int Value
        {
            get
            {
                return this.value;
            }
        }
        public bool IsFaceUp
        {
            get
            {
                return this.isFaceUp;
            }
        }
        public string Color
        {
            get
            {
                if (this.suit == "Hearts" || this.suit == "Diamonds")
                {
                    return "red";
                }
                else
                {
                    return "black";
                }
            }
        }
        public string FaceValue
        {
            get
            {
                switch (value)
                {
                    case 9:
                        return $"Jack of {suit}";
                    case 10:
                        return $"Queen of {suit}";
                    case 11:
                        return $"King of {suit}";
                    case 12:
                        return $"Ace of {suit}";
                    default:
                        int faceNumber = value + 2;
                        return $"{faceNumber} of {suit}";
                }

            }
        }

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public void TurnOver()
        {
            if (isFaceUp)
            {
                isFaceUp = false;
            }
            else
            {
                isFaceUp = true;
            }
        }
    }
}
