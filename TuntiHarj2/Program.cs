using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace TuntiHarj2
{
    class Program
    {
        static void Main(string[] args)
        {
            SetVolume();
        }

        static void SetVolume()
        {
            Amplifier amplifier = new Amplifier();
            amplifier.Volume = 10;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a new volume value (0-100): ");
                amplifier.Volume = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(amplifier.ToString());
            }
        }
    }
}
