using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Teht5vko3
{
    class Program
    {
        static void Main(string[] args)
        {
            SetVolAndFreq();
        }

        static void SetVolAndFreq()
        {
            Radio radio = new Radio();
            radio.Volume = 2;
            radio.PowerOn = true;

            Console.WriteLine("Power is on: {0}", radio.PowerOn);

            if (radio.PowerOn == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Give a new volume value (0-9): ");
                    radio.Volume = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a new frequency (2000.0 - 26000.0): ");
                    radio.Frequency = Double.Parse(Console.ReadLine());

                    Console.WriteLine(radio.ToString());
                }
            }
        }
    }
}
