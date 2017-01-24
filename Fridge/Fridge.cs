using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Fridge
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        private const int maxSpace = 20;
        private const int minSpace = 0;
        private int space = 20;
        public int Space {
            get { return space; }
            set
            {
                space = value;
                if (space == minSpace)
                {
                    Console.WriteLine("No more room!");
                    space = minSpace;
                }
                else if (space == maxSpace)
                {
                    Console.WriteLine("Fridge empty");
                }
                else
                {
                    Console.WriteLine("Room for: {0}", Space);
                }
            }
        }
        public List<Consumable> consumable { get; }

        public Fridge()
        {
            consumable = new List<Consumable>();
        }

        public Fridge(string manufacturer, string model, int space)
        {
            Manufacturer = manufacturer;
            Model = model;
            Space = space;
        }

        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer + "\nModel: " + Model + "\nSpace: " + Space;
        }
    }

    class Consumable
    {
        public string Name { get; set; }
        public int SpaceTaken { get; set; }

        public Consumable()
        { }

        public Consumable(string name, int spaceTaken)
        {
            Name = name;
            SpaceTaken = spaceTaken;
        }

        public override string ToString()
        {
            return "Product name: " + Name;
        }
    }

    class Drink : Consumable
    {

    }

    class Edible : Consumable
    {

    }

}
