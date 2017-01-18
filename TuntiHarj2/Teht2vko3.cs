using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Amplifier
    {
        private int volume = 10;
        private int isVolValid = 1;
        private const int maxVol = 100;
        private const int minVol = 0;
        private int IsVolValid
        {
            get { return isVolValid; }
        }
        public int Volume {
            get { return volume; }
            set
            {
                volume = value;
                if (value < minVol)
                {
                    isVolValid = 0;
                    volume = 0;
                }
                else if (value > maxVol)
                {
                    isVolValid = 2;
                    volume = 100;
                }
                else
                {
                    isVolValid = 1;
                    volume = value;
                }
            }
        }

        public string VolMsg()
        {

            if (IsVolValid == 0)
            {
                return "Too low volume - Amplifier min volume is set to: " + minVol;
            }
            else if (IsVolValid == 2)
            {
                return "Too potent volume - Amplifier max volume is set to: " + maxVol;
            }
            else
            {
                return "Amplifier volume set to: " + Volume;
            }
            
        }

        public override string ToString()
        {
                return VolMsg();
        }
    }
}
