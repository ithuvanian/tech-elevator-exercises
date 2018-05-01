using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.ShowDeck();
            newDeck.Shuffle();
            newDeck.ShowDeck();
            newDeck.DrawHand();
            newDeck.DrawHand();
            newDeck.DrawHand();
            newDeck.DrawHand();

            Console.ReadLine();
        }
    }
}
