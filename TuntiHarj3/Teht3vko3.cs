using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // default constructor
        public Employee()
        {
        }

        // constructor takes employee firstname and lastname as a parameter
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // return Employee data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + ", Profession: " + Profession + ", Salary: " + Salary;
        }
    }
    
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        // default constructor
        public Boss()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boss(string firstName, string lastName, string car, int bonus)
            : base(firstName, lastName)
        {
            Car = car;
            Bonus = bonus;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + ", Bonus: " + Bonus;
        }
    }
}
