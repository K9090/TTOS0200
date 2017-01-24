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
            CoffeeMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.Manufacturer = "MoccaMaster";
            coffeeMaker.Model = "Super";

            Ingredient water = new Ingredient();
            water.Name = "cup of water";

            Ingredient coffee = new Ingredient();
            coffee.Name = "spoonful of Juhla Moukka";

            Console.WriteLine(coffeeMaker.ToString());

            if (coffeeMaker.WaterSpace == 10)
            {
                Console.WriteLine("Coffeemaker's water reservoir empty\n");
            }

            List<Ingredient> ingredient = new List<Ingredient>();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Added " + water.ToString());
                coffeeMaker.AddWater(water);
                if (coffeeMaker.WaterSpace <= 0)
                {
                    break;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                coffeeMaker.AddCoffee(coffee);
                Console.WriteLine("Added " + coffee.ToString());
                if (coffeeMaker.CoffeeSpace <= 0)
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
