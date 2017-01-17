using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace VehicleTeht
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new JAMK.IT.Vehicle();
            vehicle.Name = "Bugatti";
            vehicle.Speed = 320;
            vehicle.Tyres = 4;

            Vehicle vehicle1 = new JAMK.IT.Vehicle();
            vehicle1.Name = "Saab";
            vehicle1.Speed = 460;
            vehicle1.Tyres = 4;

            vehicle.PrintData();
            vehicle.ToString();

            Console.WriteLine();

            vehicle1.PrintData();
            vehicle1.ToString();
        }
        
    }
}