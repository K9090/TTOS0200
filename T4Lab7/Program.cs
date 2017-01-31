using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T4Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Use();
        }

        static void Use()
        {
            IFormatter formatter = new BinaryFormatter();

            List<TvProgram> programs = new List<TvProgram>();

            programs.Add(new TvProgram { ProgName = "Mars Attacks", Channel = "SubTv", StartTime = "21.00", EndTime = "22.42", Info = "A movie about the martians invading the earth" });
            programs.Add(new TvProgram { ProgName = "Mars Attacks 2", Channel = "Fox", StartTime = "22.00", EndTime = "23.55", Info = "A movie about the martians invading the earth... again" });
            programs.Add(new TvProgram { ProgName = "Braveheart", Channel = "Nelonen", StartTime = "21.30", EndTime = "23.27", Info = "A movie about the scots showing their asses on the battlefield" });

            Stream writeMultiStream = null; 
            try
            {
                writeMultiStream = new FileStream("Programs.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(writeMultiStream, programs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writeMultiStream != null)
                {
                    writeMultiStream.Close();
                }
                
            }

            Stream openStream = null;
            List<TvProgram> readPrograms = null;
            try
            {
                openStream = new FileStream("Programs.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                readPrograms = (List<TvProgram>)formatter.Deserialize(openStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (openStream != null)
                {
                    openStream.Close();
                }
            }

            foreach (TvProgram p in readPrograms)
            {
                Console.WriteLine("Name of program is: {0}\n\t From channel: {1}\n\t Starts at: {2}\n\t Ends around: {3}\n\t Info: {4}\n\n", p.ProgName, p.Channel, p.StartTime, p.EndTime, p.Info);
            }
        }
    }
}
