using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Classes
{
    class Deck
    {
        private List<Card> Cards = new List<Card>();

        public int NumberOfCardsRemaining
        {
            get
            {
                return Cards.Count;
            }
        }


        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                string suit = "";
                switch (i)
                {
                    case 0:
                        suit = "Hearts";
                        break;
                    case 1:
                        suit = "Diamonds";
                        break;
                    case 2:
                        suit = "Clubs";
                        break;
                    case 3:
                        suit = "Spades";
                        break;
                }
                for (int j = 0; j < 13; j++)
                {
                    Card newCard = new Card(suit, j);
                    Cards.Add(newCard);
                }
            }
        }

        public void ShowDeck ()
        {
            Console.WriteLine("All cards in the deck:");
            Console.WriteLine("***");
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.FaceValue);
            }
            Console.WriteLine();
        }

        public Card[] Draw(int numberOfCards)
        {
            Console.WriteLine("Drawing cards:");
            Console.WriteLine("***");
            Card[] cardsDrawn = new Card[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, Cards.Count);
                cardsDrawn[i] = Cards[index];
                Cards.Remove(cardsDrawn[i]);
            }
            foreach (Card card in cardsDrawn)
            {
                Console.WriteLine(card.FaceValue);
            }
            Console.WriteLine();
            return cardsDrawn;
        }

        public void DrawHand()
        {
            Draw(13);
        }


        public void Shuffle ()
        {
            Console.WriteLine("Shuffling Cards...");
            Console.WriteLine();
            List<Card> shuffledList = new List<Card>();
            Random r = new Random();
            int randomIndex = 0;
            while (Cards.Count > 0)
            {
                randomIndex = r.Next(0, Cards.Count);
                shuffledList.Add(Cards[randomIndex]);
                Cards.RemoveAt(randomIndex); 
            }
            foreach (Card card in shuffledList)
            {
                Cards.Add(card);
            }
        }
    }
}
