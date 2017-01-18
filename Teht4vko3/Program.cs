using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Vehicle object
            Vehicle automobile = new Vehicle();
            automobile.Name = "Honda";
            automobile.Model = "Civic";
            automobile.ModelYear = 2006;
            automobile.Color = "Metallic Blue";
            Console.WriteLine(automobile.ToString());

            // create a one Bike Object
            Bike bike1 = new Bike();
            bike1.Name = "Tunturi";
            bike1.Model = "Raider";
            bike1.ModelYear = 2000;
            bike1.Color = "Black";
            bike1.HasGears = true;
            bike1.GearModel = "Wanderer";
            Console.WriteLine(bike1.ToString());

            // create a one Bike Object
            Bike bike2 = new Bike();
            bike2.Name = "-some chinesey crap-";
            bike2.Model = "-fear for your life-";
            bike2.ModelYear = 2030;
            bike2.Color = "Rusted Grey";
            bike2.HasGears = false;
            bike2.GearModel = "";
            Console.WriteLine(bike2.ToString());

            // create another Boat object
            Boat boat = new Boat();
            boat.Name = "Works Better";
            boat.Model = "On Land";
            boat.ModelYear = 1650;
            boat.Color = "Brown";
            boat.BoatType = "Motokayak";
            boat.SeatCount = 3;
            Console.WriteLine(boat.ToString());
        }
    }
}
