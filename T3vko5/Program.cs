﻿using System;
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
            Deck();
        }
        static void Deck()
        {
            Hearts heart9 = new Hearts();
            heart9.Number = 9;
            heart9.Suit = "Hearts";
            heart9.GiveNumber();

            List<Card> cardDeck = new List<Card>();

            cardDeck.Add(new Hearts());

            Console.WriteLine("Loop through the card deck:");
            foreach (Card card in cardDeck)
            {
                card.GiveNumber();
            }
        }
    }
}
