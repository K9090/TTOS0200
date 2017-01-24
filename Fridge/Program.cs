using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Fridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumable beer = new Consumable();
            beer.Name = "Karhu III";
            beer.SpaceTaken = 1;
            beer.ContSize = "0,33l";

            Console.WriteLine(beer.ToString());
        }
    }
}
