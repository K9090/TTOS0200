using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace KiuasTeht
{
    class Program
    {
        static void Main()
        {
            TestaaKiuas();
        }
        //Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //luodaan kiuas olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            kiuas.PowerOn = true;
            kiuas.Temperature = 90;
            kiuas.Moisture = 50;

            Console.WriteLine("Kiuas on päällä {0}", kiuas.PowerOn);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Temperature);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Moisture);
            //mitä tapahtuu, jos kosteus yli rajojen
            kiuas.Moisture = 101;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Moisture);
        }
    }
}
