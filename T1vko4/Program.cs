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
            int width = 90;
            int height = 30;
            Console.SetWindowSize(width, height);
            //-------------------------------------------------------------

            Tyre tyre1 = new Tyre();
            tyre1.Maker = "Nokian";
            tyre1.Model = "Hakka Green";
            tyre1.TyreSize = "225/45R17";

            Tyre tyre2 = new Tyre();
            tyre2.Maker = "Michelin";
            tyre2.Model = "Pilot Power";
            tyre2.TyreSize = "190/50-ZR-17";

            Car car1 = new Car();
            car1.Name = "Ford";
            car1.Model = "Sierra";
            car1.MaxTyreCount = 4;

            Motorbike moto = new Motorbike();
            moto.Name = "Suzuki";
            moto.Model = "GSX1300R";
            moto.MaxTyreCount = 2;

            Console.WriteLine(car1.ToString());


            for (int i = car1.TyreCount; i < car1.MaxTyreCount; i++)
            {
                car1.AddTyre(tyre1);
                if (car1.TyreCount <= 4)
                {
                    Console.WriteLine(tyre1.ToString());
                }
                
            }

            Console.WriteLine();

            Console.WriteLine(moto.ToString());


            for (int i = moto.TyreCount; i < moto.MaxTyreCount; i++)
            {
                moto.AddTyre(tyre2);
                if (moto.TyreCount <= 2)
                {
                    Console.WriteLine(tyre2.ToString());
                }
                
            }

            Console.WriteLine();
        }
    }
}
