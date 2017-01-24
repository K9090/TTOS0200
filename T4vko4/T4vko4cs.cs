using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CoffeeMaker
    {
        List<Ingredient> ingredient = new List<Ingredient>();

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        internal static int maxSpace = 10;
        internal const int minSpace = 0;
        private int waterSpace = 10;
        public int WaterSpace
        {
            get { return waterSpace; }
            set
            {
                if (waterSpace <= maxSpace)
                {
                    waterSpace = value;
                }
                else if (waterSpace >= minSpace)
                {
                    waterSpace = minSpace;
                }
            }
        }
        private int coffeeSpace = 10;
        public int CoffeeSpace
        {
            get { return coffeeSpace; }
            set
            {
                if (coffeeSpace <= maxSpace)
                {
                    coffeeSpace = value;
                }
                else if (coffeeSpace >= minSpace)
                {
                    coffeeSpace = minSpace;
                }
            }
        }
        public List<Ingredient> Ingredient
        {
            get { return ingredient; }
        }

        public void AddWater(Ingredient foodStuff)
        {
            if (waterSpace <= maxSpace)
            {
                ingredient.Add(foodStuff);
                waterSpace--;
                Console.WriteLine("Room for: {0} cups of water", WaterSpace);
            }
            else if (waterSpace == minSpace)
            {
                Console.WriteLine("No more room!");
                waterSpace = minSpace;
            }
        }

        public void AddCoffee(Ingredient foodStuff)
        {
            if (coffeeSpace <= maxSpace)
            {
                ingredient.Add(foodStuff);
                coffeeSpace--;
                Console.WriteLine("Room for: {0} spoons of coffee", CoffeeSpace);
            }
            else if (coffeeSpace == minSpace)
            {
                Console.WriteLine("No more room!");
                coffeeSpace = minSpace;
            }
        }

        public CoffeeMaker()
        {
        }

        public CoffeeMaker(string manufacturer, string model)
        {
            Manufacturer = manufacturer;
            Model = model;
        }

        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer + "\nModel: " + Model;
        }
    }

    class Ingredient
    {
        public string Name { get; set; }

        public Ingredient()
        { }

        public Ingredient(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Ingredient: " + Name;
        }
    }
}
