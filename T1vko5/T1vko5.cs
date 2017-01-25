using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    /// <summary>
    /// This class contains person's properties
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialID { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + SocialID;
        }
    }

    /// This class holds person's information in a collection
    /// 
    class Persons
    {
        // Properties
        private List<Person> persons;
        public List<Person> PersonsList { get { return persons; } }
        public Persons()
        {
            persons = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public Person SeekPerson(int index) // Returns person object
        {
            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            }
            else
            {
                return null; // If outside index
            }
        }
        public Person SeekPersonSocialID(string socialID)
        {
            foreach (Person person in persons)
            {
                if (person.SocialID == socialID)
                {
                    return person;
                }
            }
            return null;
        }
    }
}
