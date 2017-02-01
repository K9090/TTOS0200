using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class FileIO
    {
        public int i = 0;

        public void ReadFromFile()
        {
            var sameName = new SortedDictionary<string, int>(); // Adding Sorted prefix to Dictionary, sorts the list
            try
            {
                foreach (string line in File.ReadAllLines(@"D:\K9090\Olio\Repo\harjoitukset\nimet.txt"))
                {
                    i++;
                    if (sameName.ContainsKey(line))
                    {
                        sameName[line] = sameName[line] + 1;
                    }
                    else
                    {
                        sameName.Add(line, 1);
                    }
                }

                Console.WriteLine("Amount of names: {0}", i);

                foreach (var pair in sameName)
                {
                    Console.WriteLine(pair.Key + " " + pair.Value);
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
