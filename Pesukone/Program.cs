using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace PesukoneTeht
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaPesukone();
        }
        static void TestaaPesukone()
        {
            Pesukone pesukone = new JAMK.IT.Pesukone();
            pesukone.PowerOn = true;
            pesukone.DoorClosed = true;
            pesukone.WaterOn = true;
            pesukone.WashProgram = 3;

            Console.WriteLine("Pesukoneen virta on päällä {0}", pesukone.PowerOn);
            Console.WriteLine("Pesukoneen luukku on kiinni {0}", pesukone.DoorClosed);
            Console.WriteLine("Pesukone saa vettä {0}", pesukone.WaterOn);
            Console.WriteLine("Pesukoneen ohjelma {0}", pesukone.WashProgram);
            //mitä tapahtuu, jos ohjelmanuppi pyörähtää ympäri
            pesukone.WashProgram = 11;
            Console.WriteLine("Pesukoneen ohjelma {0}", pesukone.WashProgram);
        }
    }
}
