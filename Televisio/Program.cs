using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace TelevisioTeht
{
    class Program
    {
        static void Main()
        {
            TestaaTelevisio();
        }
        static void TestaaTelevisio()
        {
            Televisio tv = new JAMK.IT.Televisio();
            tv.PowerOn = true;
            tv.Volume = 20;
            tv.Channel = 3;
            tv.Wifi = true;

            Console.WriteLine("Television virta on päällä {0}", tv.PowerOn);
            Console.WriteLine("Television äänenvoimakkuus {0}", tv.Volume);
            Console.WriteLine("Television kanava {0}", tv.Channel);
            Console.WriteLine("Television Wifi on päällä {0}", tv.Wifi);
            //mitä tapahtuu, jos ohjelmanuppi pyörähtää ympäri
            tv.Channel = 1001;
            Console.WriteLine("Television ohjelma {0}", tv.Channel);
        }
    }
}
