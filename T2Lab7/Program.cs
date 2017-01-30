using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T2Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            FileIO fileIO = new FileIO();
            
            fileIO.ReadFromFile();
        }
    }
}
