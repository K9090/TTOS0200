using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        List<Fish> Fishes { get; }
        List<LocationOfCatch> Locations { get; }

        public Fisher()
        {
            Fishes = new List<Fish>();
            Locations = new List<LocationOfCatch>();
        }

        public void AddFish(Fish fish)
        {
            Fishes.Add(fish);
            Console.WriteLine("- {0} caught {1}!", Name, fish.Specie);
        }

        public void AddLocation(LocationOfCatch location)
        {
            Locations.Add(location);
            Console.WriteLine("- From: {0}, {1}", location.Place, location.Location);
        }

        public override string ToString()
        {
            return "- Name of fisher: " + Name + "\n- Phone number: " + PhoneNumber;
        }
    }

    class Fish
    {
        public string Specie { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return "- Specie: " + Specie + "\n- Size: " + Size + " cm\n- Weight: " + Weight + " kg";
        }
    }

    class LocationOfCatch
    {
        public string Place { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return "- Place of catch: " + Place + "\n- Location: " + Location;
        }
    }
}
