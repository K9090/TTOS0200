using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T1vko5
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelReg();
        }

        static void PersonnelReg()
        {
            // Creates a few person test subjects
            Persons group = new Persons();
            Person person = new Person { FirstName = "Erik", LastName = "Strongarm", SocialID = "124343-432K" };
            Person person1 = new Person { FirstName = "Olaf", LastName = "Strongarm", SocialID = "484343-478K" };
            Person person2 = new Person { FirstName = "Jalmari", LastName = "Kalmari", SocialID = "174876-122K" };

            // Add persons to group
            group.AddPerson(person);
            group.AddPerson(person1);
            group.AddPerson(person2);

            // Print group to console
            foreach (Person p in group.PersonsList)
            {
                Console.WriteLine("{0}", p.ToString());
            }

            // TODO Ask person's socialID from the user and seek the corresponding person on screen
            string seekID;

            Console.WriteLine("\nSeek personnel information from registery");
            Console.WriteLine("SocialID to seek");
            seekID = Console.ReadLine();
           
            Console.WriteLine(group.SeekPersonSocialID(seekID));
        }
    }
}
