using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Televisio
    {
        public bool PowerOn { get; set; }
        public bool Wifi { get; set; }
        int vol;
        public int Volume {
            get { return vol; }
            set
            {
                vol = value;
                if (vol < 0 || vol > 100)
                {
                    vol = 0;
                }
            }
        }
        int chan;
        public int Channel {
            get { return chan; }
            set
            {
                chan = value;
                if (chan < 1)
                {
                    chan = 1000;
                }
                else if (chan > 1000)
                {
                    chan = 1;
                }
            }
        }
    }
}
