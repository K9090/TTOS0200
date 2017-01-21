using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace BookshelfApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one BluRay movie object
            DigitalMedia bluRayMovie = new DigitalMedia();
            bluRayMovie.IsPhysical = true;
            bluRayMovie.DataSize = 45;
            bluRayMovie.TypeOfMedia = "Blu Ray disc";
            bluRayMovie.Name = "Geteven";
            Console.WriteLine(bluRayMovie.ToString());

            // create one DVD document Object
            DigitalMedia dvdDoc = new DigitalMedia();
            dvdDoc.Name = "Tunturi";
            dvdDoc.IsPhysical = true;
            dvdDoc.DataSize = 4.7f;
            dvdDoc.TypeOfMedia = "DVD disc";
            Console.WriteLine(dvdDoc.ToString());

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
