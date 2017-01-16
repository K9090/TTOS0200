using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kiuas
    {
        public bool PowerOn { get; set; }
        public float Temperature { get; set; }
        //kosteus voi olla välillä 0-100
        float moisture;
        public float Moisture {
            get { return moisture; }
            set
            {
                moisture = value;
                if (moisture < 0 || moisture > 100)
                {
                    moisture = 0;
                }
            }
        }
    }
}
