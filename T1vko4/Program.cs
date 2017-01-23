using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace T1vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 70;
            int height = 30;
            Console.SetWindowSize(width, height);
            //-------------------------------------------------------------

            Tyre tyre1 = new Tyre();
            tyre1.Maker = "Nokia";
            tyre1.Model = "Hakka";
            tyre1.TyreSize = "225/45R17";

            Car car1 = new Car();
            car1.Name = "Ford";
            car1.Model = "Sierra";
            car1.TyreCount = 4;

            Console.WriteLine(car1.ToString());

            List<Tyre> tyre = new List<Tyre>();

            for (int i = 0; i < car1.TyreCount; i++)
            {
                car1.AddTyre(tyre1);
            }

            Console.WriteLine();

            for (int i = 0; i < car1.TyreCount; i++)
            {
                Console.WriteLine(tyre1.ToString());
            }
        }
    }
}
