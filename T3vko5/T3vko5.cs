using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Card
    {
        private List<Card> cards;
        public List<Card> Cards { get { return cards; } }
        private int minNumber = 1;
        private int maxNumber = 13;
        private int number;
        public int Number {
            get { return number; }
            set
            {
                if (number >= minNumber || number <= maxNumber)
                {
                    number = value;
                }
                else
                {
                    Console.WriteLine(number + " will not do"); 
                }
            }
        }
        public virtual string Suit { get; set; }

        public Card()
        {

        }
        public Card(int number)
        {
            Number = number;
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public void LoopNumbers(int number)
        {
            for (int i = 0; i < 13; i++)
            {
                number++;
            }
        }

        public abstract void GiveNumber();
    }
    class Hearts : Card
    {
        public override string Suit
        {
            get
            {
                return "Hearts";
            }

            set
            {
                Suit = value;
            }
        }
        public override void GiveNumber()
        {
            Console.WriteLine(Number + " of " + Suit);
        }
    }
    class Diamonds : Card
    {
        public override string Suit
        {
            get
            {
                return "Diamonds";
            }

            set
            {
                Suit = value;
            }
        }
        public override void GiveNumber()
        {
            Console.WriteLine(Suit);
        }

    }
    class Clubs : Card
    {
        public override string Suit
        {
            get
            {
                return "Clubs";
            }

            set
            {
                Suit = value;
            }
        }
        public override void GiveNumber()
        {
            Console.WriteLine(Suit);
        }
    }
    class Spades : Card
    {
        public override string Suit
        {
            get
            {
                return "Spades";
            }

            set
            {
                Suit = value;
            }
        }
        public override void GiveNumber()
        {
            Console.WriteLine(Suit);
        }
    }
}
