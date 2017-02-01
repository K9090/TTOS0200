using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T3Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UseRegister();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void UseRegister()
        {
            List<Fisher> fisher = new List<Fisher>();
            List<Fish> fish = new List<Fish>();

            try
            {
                Fisher fisher1 = new Fisher { Name = "Erkki Tolvana", PhoneNumber = "045-6667778" };
                Fisher fisher2 = new Fisher { Name = "Janne Tampio", PhoneNumber = "049-2634326" };

                fisher.Add(fisher1);
                fisher.Add(fisher2);

                Fish fish1 = new Fish { Specie = "Salmon", Size = 160, Weight = 15 };
                Fish fish2 = new Fish { Specie = "Pike", Size = 2000, Weight = 15 };

                fish.Add(fish1);
                fish.Add(fish2);

                LocationOfCatch location1 = new LocationOfCatch { Place = "Keurusselkä", Location = "Middle-Finland" };
                LocationOfCatch location2 = new LocationOfCatch { Place = "River Teno", Location = "Lapland" };

                
                Console.WriteLine(fisher1.ToString());
                fisher1.AddFish(fish1);
                fisher1.AddLocation(location1);

                Console.WriteLine();

                Console.WriteLine(fisher2.ToString());
                fisher2.AddLocation(location2);
                fisher2.AddFish(fish2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
