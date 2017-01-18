using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TuntiHarjoitus1

namespace JAMK.IT
{
    class Elevator
    { 
        private int floor = 1;
        public int Floor {
            get { return floor; }
            set
            {
                floor = value;
                if (value < 1)
                {
                    floor = 1;
                }
                else if (floor > 5)
                {
                    floor = 5;
                }
                else
                {
                    floor = value;
                }
            }
        }

        public override string ToString()
        {
            return "Elevator is now in floor: " + Floor;
        }
    }
}
