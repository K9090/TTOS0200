using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T1Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice();
        }

        static void ThrowDice()
        {
            Dice dice = new Dice();

            dice.Throw();

            dice.Randomize();

            dice.ReadHistory();

            Console.WriteLine(dice.ToString());
        }
    }
}
