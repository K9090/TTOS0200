using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    [Serializable]
    class TvProgram
    {
        public string ProgName { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Info { get; set; }
    }
}
