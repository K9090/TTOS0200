using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class FileIO
    {
        public string input;
        public int isInt;

        public void SaveToFile()
        {
            StreamWriter outputFile1 = null;
            StreamWriter outputFile2 = null;
            try
            {
                outputFile1 = new StreamWriter(@"..\..\T3ints.txt");
                outputFile2 = new StreamWriter(@"..\..\T3doubles.txt");
                do
                {
                    Console.Write("Insert numbers: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out isInt);
                    
                    if (isInt == 0)
                    {
                        outputFile2.WriteLine(input);
                    }
                    else

                    {
                        outputFile1.WriteLine(input);
                    }

                } while (input != String.Empty);

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access to the file is denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile1 != null || outputFile2 != null)
                {
                    outputFile1.Close();
                    outputFile2.Close();
                }
            }
        }

        public void ReadFromFile()
        {
            try
            {
                string ints = File.ReadAllText(@"..\..\T3ints.txt");
                Console.WriteLine("Contents of T3ints.txt:\n" + ints);
                string doubles = File.ReadAllText(@"..\..\T3doubles.txt");
                Console.WriteLine("Contents of T3doubles.txt:\n" + doubles);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
