using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Nisakas
    {
        private int age;
        public int Age {
            get { return age; }
            set
            {
                age = value;
            }
        }

        public Nisakas()
        {

        }

        public string Move()
        {
            return string.Format("is moving");
        }

        public override string ToString()
        {
            return "Age: " + Age;
        }
    }

    class Human : Nisakas
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Human()
        {

        }

        public int Grow()
        {
            int age = Age;
            age++;
            return age;
        }

        public override string ToString()
        {
            return base.ToString() + "\nName: " + Name + "\nHeight: " + Height + "\nWeight: " + Weight;
        }
    }

    class Adult : Human
    {
        public string Car { get; set; }

        public Adult()
        {

        }

        public new string Move()
        {
            return string.Format("is walking");
        }

        public override string ToString()
        {
            return base.ToString()  + "\nCar: " + Car + "\n" + Move();
        }
    }

    class Infant : Human
    {
        public bool HasDiaper { get; set; }

        public Infant()
        {

        }

        public new string Move()
        {
            return string.Format("is crawling");
        }

        public override string ToString()
        {
            return base.ToString() + "\nDiaper: " + HasDiaper + "\n" + Move();
        }
    }
}
