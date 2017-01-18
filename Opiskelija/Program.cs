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
            Opiskelija[] opiskelija = new Opiskelija[3];

            Console.WriteLine("Opiskelija nro 1");
            opiskelija[0] = new Opiskelija();
            opiskelija[0].Fill();
            Console.WriteLine();

            opiskelija[1] = new Opiskelija();
            opiskelija[1].FirstName = "Janne";
            opiskelija[1].SurName = "Seppänen";
            opiskelija[1].ID = "K666";
            opiskelija[1].Age = 33;

            opiskelija[2] = new Opiskelija();
            opiskelija[2].FirstName = "Eerika";
            opiskelija[2].SurName = "Kekkonen";
            opiskelija[2].ID = "H6780";
            opiskelija[2].Age = 20;

            Console.WriteLine();

            for (int i = 0; i < opiskelija.Length; i++)
            {
                Console.WriteLine("Opiskelija nro {0}: {1}", i + 1, opiskelija[i].ToString());
            }

            Console.WriteLine();
        }
    }
}
