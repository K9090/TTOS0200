using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Employee object
            Employee person = new Employee();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Profession = "Kylähullu";
            person.Salary = 3000;
            Console.WriteLine(person.ToString());

            // create a one Boss Object
            Boss teacher = new Boss();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Profession = "Ope";
            teacher.Salary = 4000;
            teacher.Car = "Lada";
            teacher.Bonus = 6000;
            Console.WriteLine(teacher.ToString());

            // create another Employee object
            Employee person2 = new Employee();
            person2.FirstName = "Minna";
            person2.LastName = "Husso";
            person2.Profession = "Velhotar";
            person2.Salary = 10000;
            Console.WriteLine(person2.ToString());
        }
    }
}
