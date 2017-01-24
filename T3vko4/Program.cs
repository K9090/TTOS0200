using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace T3vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            
            adult.Name = "Ugga";
            adult.Age = 23;
            adult.Height = 160;
            adult.Weight = 80;
            adult.Car = "Lada";

            Infant infant = new Infant();
            
            infant.Name = "Krugg";
            infant.Age = 1;
            infant.Height = 70;
            infant.Weight = 10;
            infant.HasDiaper = true;

            Adult adult1 = new Adult();

            adult1.Name = "Umbah";
            adult1.Age = 26;
            adult1.Height = 170;
            adult1.Weight = 70;
            adult1.Car = "Flintstones' Mobile";

            Console.WriteLine(adult.ToString() + "\n");

            Console.WriteLine(infant.ToString() + "\n");

            Console.WriteLine(adult1.ToString() + "\n");

            Console.WriteLine(infant.Name + " just experienced his {0} birthday!", infant.Grow());

            Console.WriteLine();
        }
    }
}
