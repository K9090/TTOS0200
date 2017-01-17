using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OpiskelijaTeht
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija[] opiskelija = new Opiskelija[2];

            for (int i = 0; i < opiskelija.Length; i++)
            {
                Console.WriteLine("Opiskelija nro {0}", i + 1);
                opiskelija[i] = new Opiskelija();
                opiskelija[i].Fill();
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < opiskelija.Length; i++)
            {
                Console.WriteLine("Opiskelija nro {0}: {1}", i + 1, opiskelija[i].ToString());
            }

            Console.WriteLine();
        }
    }
}
