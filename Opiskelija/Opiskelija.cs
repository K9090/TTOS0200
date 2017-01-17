using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public void Fill()
        {
            Console.Write("Anna etunimesi: ");
            FirstName = Console.ReadLine();
            Console.Write("Anna sukunimesi: ");
            SurName = Console.ReadLine();
            Console.Write("Anna opiskelijatunnuksesi: ");
            ID = Console.ReadLine();
            Console.Write("Anna ikäsi: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            string tiedot = SurName + ", " + FirstName + ", " + ID + ", " + Age;
            return tiedot;
        }
    }
}
