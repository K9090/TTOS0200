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
            try
            {
                Fishes.Add(fish);
                Console.WriteLine("- {0} caught {1}", Name, fish.Specie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddLocation(LocationOfCatch location)
        {
            try
            {
                Locations.Add(location);
                Console.WriteLine("- From: {0}, {1}", location.Place, location.Location);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            try
            {
                return "- Name of fisher: " + Name + "\n- Phone number: " + PhoneNumber;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    class Fish
    {
        public string Specie { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            try
            {
                return "- Specie: " + Specie + "\n- Size: " + Size + " cm\n- Weight: " + Weight + " kg";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    class LocationOfCatch
    {
        public string Place { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            try
            {
                return "- Place of catch: " + Place + "\n- Location: " + Location;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
