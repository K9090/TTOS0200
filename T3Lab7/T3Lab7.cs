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
        public string Input { get; set; }

        public void SaveToFile()
        {
            StreamWriter outputFile = null;
            try
            {
                if (Input )
                {

                }
                outputFile = new StreamWriter(@"D:\K9090\Olio\Repo\harjoitukset\T3ints.txt");
                outputFile = new StreamWriter(@"D:\K9090\Olio\Repo\harjoitukset\T3doubles.txt");
                do
                {
                    Console.Write("Insert numbers: ");
                    Input = Console.ReadLine();
                    outputFile.WriteLine(Input);

                } while (Input != String.Empty);

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access to the path 'D:\K9090\Olio\Repo\harjoitukset\test.txt' is denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }

        public void ReadFromFile()
        {
            try
            {
                string ints = File.ReadAllText(@"D:\K9090\Olio\Repo\harjoitukset\T3ints.txt");
                Console.WriteLine("Contents of T3ints.txt:\n" + ints);
                string doubles = File.ReadAllText(@"D:\K9090\Olio\Repo\harjoitukset\T3ints.txt");
                Console.WriteLine("Contents of T3doubles.txt:\n" + doubles);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
