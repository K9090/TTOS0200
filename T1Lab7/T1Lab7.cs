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
                outputFile = new StreamWriter(@"D:\K9090\Olio\Repo\harjoitukset\test.txt");

                do
                {
                    Console.Write("Insert text: ");
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
                string text = File.ReadAllText(@"D:\K9090\Olio\Repo\harjoitukset\test.txt");
                Console.WriteLine("Contents of test.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
