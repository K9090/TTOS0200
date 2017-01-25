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
            beer.Name = "Karhu III, 6-pack";
            beer.SpaceTaken = 6;
            beer.ContSize = "6 x 0.33l";

            Consumable orange = new Consumable();
            orange.Name = "Appelsiinipussi";
            orange.SpaceTaken = 2;
            orange.ContSize = "2.0kg";

            Console.WriteLine(fridge.ToString());

            if (fridge.Space == Fridge.maxSpace)
            {
                Console.WriteLine("Fridge empty\n");
            }

            Console.WriteLine("How many beers you bought?");
            beer.Count = Convert.ToInt32(Console.ReadLine());

            List<Consumable> consumable = new List<Consumable>();

            for (int i = 0; i < beer.Count; i++)
            {
                Console.WriteLine("Added: " + beer.ToString());
                fridge.AddConsumable(beer);
                if (fridge.Space <= 0)
                {
                    break;
                }
            }

            Console.WriteLine("How many oranges you bought?");
            orange.Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < orange.Count; i++)
            {
                fridge.AddConsumable(orange);
                Console.WriteLine("Added: " + orange.ToString());
                if (fridge.Space <= 0)
                {
                    break;
                }
            }

            Console.WriteLine("\nConsuming...\n");

            for (int i = 0; i < beer.Count; i++)
            {
                fridge.RemConsumable(beer);
                Console.WriteLine("Removed: " + beer.ToString());
                if (fridge.Space >= 20)
                {
                    break;
                }
            }

            for (int i = 0; i < orange.Count; i++)
            {
                fridge.RemConsumable(orange);
                Console.WriteLine("Removed: " + orange.ToString());
                if (fridge.Space >= 20)
                {
                    break;
                }
            }
            Console.WriteLine("\n");
        }
    }
}
