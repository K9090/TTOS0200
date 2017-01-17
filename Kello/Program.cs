using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kello time = new Kello();
            time.IsRunning = true;
            time.IsOnTime = true;

            time.SetTime();

            Console.WriteLine();
            Console.WriteLine(time.ToString());
            Console.WriteLine();
        }
    }
}
