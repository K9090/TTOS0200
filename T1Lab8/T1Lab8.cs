using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Dice
    {
        public int NumberOfThrows { get; set; }
        public int Number { get; set; }
        private const int minNumber = 1;
        private const int maxNumber = 7;
        private double average;
        private int[] count = new int[6];

        Random rnd = new Random();

        public void Throw()
        {
            Console.WriteLine("Program simulates dicethrows and returns corresponding information");
            Console.Write("Insert the amount of throws: ");
            NumberOfThrows = int.Parse(Console.ReadLine());
        }
        public void Randomize()
        {
            for (int i = 0; i < NumberOfThrows; i++)
            {
                Number = rnd.Next(minNumber, maxNumber);

                average += Number;
                switch (Number)
                {
                    case 1: count[0]++; break;
                    case 2: count[1]++; break;
                    case 3: count[2]++; break;
                    case 4: count[3]++; break;
                    case 5: count[4]++; break;
                    case 6: count[5]++; break;
                    default:
                        break;
                }
            }
            average = average / NumberOfThrows;
        }

        public override string ToString()
        {
            return "Averagely your number was: " + average + "\nNumber of throws: " + NumberOfThrows +
                "\n\tNumber 1 shows up: " + count[0] + " times" +
                "\n\tNumber 2 shows up: " + count[1] + " times" +
                "\n\tNumber 3 shows up: " + count[2] + " times" +
                "\n\tNumber 4 shows up: " + count[3] + " times" +
                "\n\tNumber 5 shows up: " + count[4] + " times" + 
                "\n\tNumber 6 shows up: " + count[5] + " times";
        }
    }
}
