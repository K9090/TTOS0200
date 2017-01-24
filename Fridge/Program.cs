using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace T2vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            fridge.Manufacturer = "Siemens";
            fridge.Model = "Kalsa";

            Consumable beer = new Consumable();
            beer.Name = "Karhu III";
            beer.SpaceTaken = 3;
            beer.ContSize = "0,33l";

            Consumable orange = new Consumable();
            orange.Name = "Appelsiini";
            orange.SpaceTaken = 2;
            orange.ContSize = "0.3kg";

            Console.WriteLine(fridge.ToString());

            if (fridge.Space == Fridge.maxSpace)
            {
                Console.WriteLine("Fridge empty\n");
            }

            List<Consumable> consumable = new List<Consumable>();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Added: " + beer.ToString());
                fridge.AddConsumable(beer);
                if (fridge.Space <= 0)
                {
                    break;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                fridge.AddConsumable(orange);
                Console.WriteLine("Added: " + orange.ToString());
                if (fridge.Space <= 0)
                {
                    break;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                fridge.RemConsumable(beer);
                Console.WriteLine("Removed: " + beer.ToString());
                if (fridge.Space >= 20)
                {
                    break;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                fridge.RemConsumable(orange);
                Console.WriteLine("Removed: " + orange.ToString());
                if (fridge.Space >= 20)
                {
                    break;
                }
            }


        }
    }
}
