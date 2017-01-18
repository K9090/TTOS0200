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
        private bool isFloorValid = true;
        private int floor = 1;
        private bool IsFloorValid
        {
            get { return isFloorValid; }
        }
        public int Floor {
            get { return floor; }
            set
            {
                floor = value;
                if (value < 1)
                {
                    isFloorValid = false;
                    floor = 1;
                }
                else if (floor > 5)
                {
                    isFloorValid = false;
                    floor = 5;
                }
                else
                {
                    isFloorValid = true;
                    floor = value;
                }
            }
        }
        public string FloorMsg()
        {
            if (IsFloorValid)
            {
                return "Valittu kerros " + Floor;
            }
            else
            {
                return "Valittu kerros ei ole käytettävissä";
            }
        }

        public override string ToString()
        {
            if (IsFloorValid)
            {
                return FloorMsg();
            }
            else
            {
                return FloorMsg();
            }  
        }
    }
}
