using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Radio
    {
        public bool PowerOn { get; set; }

        private int volume = 1;
        private int isVolValid = 1;
        private const int maxVol = 9;
        private const int minVol = 0;
        private int IsVolValid
        {
            get { return isVolValid; }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (value < minVol)
                {
                    isVolValid = 0;
                    volume = minVol;
                }
                else if (value > maxVol)
                {
                    isVolValid = 2;
                    volume = maxVol;
                }
                else
                {
                    isVolValid = 1;
                    volume = value;
                }
            }
        }

        private int isFreqValid = 1;
        public int IsFreqValid
        {
            get { return isFreqValid; }
        }
        private const float maxFreq = 26000f;
        private const float minFreq = 2000f;
        private float frequency = 2000f;
        public float Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;
                if (value < minFreq)
                {
                    isFreqValid = 0;
                    frequency = minFreq;
                }
                else if (value > maxFreq)
                {
                    isFreqValid = 2;
                    frequency = maxFreq;
                }
                else
                {
                    isFreqValid = 1;
                    frequency = value;
                }
            }
        }

        public string VolMsg()
        {

            if (IsVolValid == 0)
            {
                return "Volume too low  - Radio min volume is set to: " + minVol;
            }
            else if (IsVolValid == 2)
            {
                return "Volume too potent - Radio max volume is set to: " + maxVol;
            }
            else
            {
                return "Radio volume set to: " + Volume;
            }

        }

        public string FreqMsg()
        {
            if (IsFreqValid == 0)
            {
                return "Attempted frequency too low  - Lowest possible frequency is set to: " + minFreq;
            }
            else if (IsFreqValid == 2)
            {
                return "Attempted frequency too high  - Highest possible frequency is set to: " + maxFreq;
            }
            else
            {
                return "Radio frequency set to: " + Frequency;
            }
        }

        public override string ToString()
        {
            return VolMsg() + "\n" + FreqMsg() + "\n";
        }
    }
}
