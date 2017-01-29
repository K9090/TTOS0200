using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T3vko5
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDeck();
        }
        static void UseDeck()
        {
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();
            int deckSize = 52;

            for (int i = 0; i < deckSize; i++)
            {
                cards.Add(deck.LoopDeck());
            }

            Console.WriteLine("Loop through the card deck:");

            foreach (Card x in cards)
            {
                Console.WriteLine(x.Number + " of " + x.Suit);
            }
        }
    }
}
