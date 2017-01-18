using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Name { get; set; }

        int speed;
        public int Speed {
            get { return speed; }
            set
            {
                speed = value;
                if (speed < 0 )
                {
                    speed = 0;
                }
                if (speed > 400)
                {
                    if (Name == "Saab")
                    {
                        speed = value;
                    }
                    else
                    {
                        speed = 400;
                    }
                }
            }
        }

        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Ajoneuvon nimi on {0}", Name);
            Console.WriteLine("Ajoneuvon nopeus on {0}", Speed);
            Console.WriteLine("Ajoneuvon renkaiden määrä {0}", Tyres);
            //mitä tapahtuu, jos nopeutta pyydetään liikaa
            Speed = 420;
            Console.WriteLine("Ajoneuvon nopeus on {0}", Speed);
        }
        public override string ToString()
        {
            string tiedot = Name + ", nopeus: " + Speed + " km/h, " + Tyres + " kpl renkaita";

            Console.WriteLine(tiedot);

            return tiedot;
        }
    }
}
