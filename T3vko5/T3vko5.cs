using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Card
    {
        public int Number { get; set; }
        public virtual string Suit { get; set; }

        public Card()
        {

        }

        public Card(int number)
        {
            Number = number;
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
