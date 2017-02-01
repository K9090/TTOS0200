using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Dice
    {
        List<Dice> diceHistory = new List<Dice>();
        public int NumberOfThrows { get; set; }
        public int Number { get; set; }
        private const int minNumber = 1;
        private const int maxNumber = 6;

        Random rnd = new Random();

        public void Throw()
        {
            Console.WriteLine("Program simulates dicethrows and returns corresponding information");
            Console.Write("Insert the amount of throws: ");
            NumberOfThrows = int.Parse(Console.ReadLine());
        }
        public void Randomize()
        {
            Number = rnd.Next(minNumber, maxNumber);
        }

        public void AddToHistory()
        {
            Dice dice = new Dice();
            for (int i = 0; i < NumberOfThrows; i++)
            {
                diceHistory.Add(dice);
            }
        }

        public void ReadHistory()
        {
            foreach (var num in diceHistory)
            {
                Console.WriteLine("Throw: {0}", diceHistory);
            }
        }

        public override string ToString()
        {
            return "Last number: " + Number + "\nNumber of throws: " + NumberOfThrows;
        }
    }
}
