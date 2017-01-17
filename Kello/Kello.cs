using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kello
    {
        public bool IsRunning { get; set; }
        int hour, min, day = 1;
        public int TimeH {
            get { return hour; }
            set
            {
                hour = value;
                if (hour >= 24)
                {
                    day++;
                    hour = hour - 24 * day;
                }
            }
        }
        public int TimeM {
            get { return min; }
            set
            {
                min = value;
                if (min >= 60)
                {
                    hour++;
                    min = min - 60;
                }
            }
        }
        public bool IsOnTime { get; set; }

        public void SetTime()
        {
            Console.Write("Syötä tunnit: ");
            TimeH = Int32.Parse(Console.ReadLine());
            Console.Write("Syötä minuutit: ");
            TimeM = Int32.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            string showTime = TimeH + " tuntia, " + TimeM + " minuuttia.";
            return showTime;
        }
    }
}
