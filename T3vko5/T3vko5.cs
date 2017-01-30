using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Card
    {
        public int Number { get; set; }
        public string d = "Diamonds";
        public string c = "Clubs";
        public string s = "Spades";
        public string h = "Hearts";
        public string Suit { get; set; }
    }

    class Deck
    {
        public List<Card> Cards { get; set; }
   
        public Deck()
        {
            Cards = new List<Card>();
            Card card;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    card = new Card();
                    card.Number = j;
                    switch (i)
                    {
                        default:
                        case 1: card.Suit = card.c; break;
                        case 2: card.Suit = card.d; break;
                        case 3: card.Suit = card.h; break;
                        case 4: card.Suit = card.s; break;
                    }
                    Cards.Add(card);
                }
            }
        }
        
        public Card LoopDeck()
        {
            Card card = Cards[Cards.Count];
            return card;
        } 
    }
}