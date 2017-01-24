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
        List<Tyre> tyre = new List<Tyre>();

        public string Name { get; set; }
        public string Model { get; set; }
        private int tyreCount = 0;
        public int TyreCount {
            get { return tyreCount; }
            set
            {
                    tyreCount = value;
            }
        }
        public List<Tyre> Tyres {
            get { return tyre; }
        }
        public int MaxTyreCount { get; set; }

        public Vehicle()
        {
           
        }

        public void AddTyre(Tyre tyre)
        {
            if (tyreCount < MaxTyreCount)
            {
                Tyres.Add(tyre);
                tyreCount++;
                Console.WriteLine("\tTyre {0} added to your vehicle {1} {2}", tyre.Model, Name, Model);
            }

            else
            {
                Console.WriteLine("\tNo room for any additional tyres!");
            }
        }

        public Vehicle(string name, string model, int tyreCount)
        {
            Name = name;
            Model = model;
            TyreCount = tyreCount;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nModel: " + Model;
        }
    }

    class Car : Vehicle
    {
        
        public Car()
        {
           MaxTyreCount = 4;
        }

        public Car(string name, string model, int tyreCount)
            : base(name, model, tyreCount)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nTyres: " + MaxTyreCount + "\n";
        }
    }

    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            MaxTyreCount = 2;
        }

        public Motorbike(string name, string model, int tyreCount)
            : base(name, model, tyreCount)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nTyres: " + MaxTyreCount + "\n";
        }
    }
}
