using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public bool PowerOn { get; set; }
        public bool DoorClosed { get; set; }
        public bool WaterOn { get; set; }
        int wProgram;
        public int WashProgram{
            get { return wProgram; }
            set
            {
                wProgram = value;
                if (wProgram < 1)
                {
                    wProgram = 10;
                }
                else if (wProgram > 10)
                {
                    wProgram = 1;
                }
            }
        }
    }
}
