using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Fridge
    {
        List<Consumable> consumable = new List<Consumable>();

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        internal static int maxSpace = 20;
        internal const int minSpace = 0;
        private int space = 20;
        public int Space {
            get { return space; }
            set { space = value; }
        }
        public List<Consumable> Consumbale
        {
            get { return consumable; }
        }

        public void AddConsumable(Consumable foodStuff)
        {
            if (space <= maxSpace)
            {
                consumable.Add(foodStuff);
                space -= foodStuff.SpaceTaken;
                Console.WriteLine("Room for: {0}", Space);
            }
            else if (space == minSpace)
            {
                Console.WriteLine("No more room!");
                space = minSpace;
            }
        }

        public void RemConsumable(Consumable foodStuff)
        {
            if (space >= minSpace && space <= maxSpace)
            {
                consumable.Remove(foodStuff);
                Console.WriteLine("Room for: {0}", Space);
                space += foodStuff.SpaceTaken;
            }
            else if (space == maxSpace)
            {
                Console.WriteLine("Fridge empty");
                space = maxSpace;
            }
        }

        public Fridge()
        {
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
        private int spaceTaken = 0;
        public int SpaceTaken {
            get { return spaceTaken; }
            set { spaceTaken = value; }
                }
        public string ContSize { get; set; }
        public int Count { get; set; }

        public Consumable()
        { }

        public Consumable(string name, int spaceTaken, string contSize)
        {
            Name = name;
            SpaceTaken = spaceTaken;
            ContSize = contSize;
        }

        public override string ToString()
        {
            return "Product name: " + Name + ", size: " + ContSize;
        }
    }
}
