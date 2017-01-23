using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Tyre
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }

        public Tyre()
        { }

        public Tyre(string maker, string model, string tyreSize)
        {
            Maker = maker;
            Model = model;
            TyreSize = tyreSize;
        }

        public override string ToString()
        {
            return "\tMaker: " + Maker + " / Model: " + Model + " / Size of tyres: " + TyreSize;
        }
    }

    class Vehicle
    {
        public string Name { get; set; }

        public Vehicle()
        { }

        public Vehicle(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }
    }

    class Car : Vehicle
    {
        private int tyreCount = 0;
        public string Model { get; set; }
        public List<Tyre> Tyres { get; }
        public int TyreCount { get; set; }
        
        private const int maxTyreCount = 4;

        public Car()
        {
            Tyres = new List<Tyre>();
        }

        public void AddTyre(Tyre tyre)
        {
            if (tyreCount < maxTyreCount)
            {
                Tyres.Add(tyre);
                tyreCount++;
                Console.WriteLine("\tTyre {0} added to your vehicle {1}", tyre.Model, Name);
            }
            else
            {
                Console.WriteLine("\tNo room for any additional tyres!");
            }
        }
        public Car(string name, string model, int tyreCount)
            : base(name)
        {
            Model = model;
            TyreCount = tyreCount;
        }

        public override string ToString()
        {
            return base.ToString() + "\nModel: " + Model + "\n";
        }
    }
}
