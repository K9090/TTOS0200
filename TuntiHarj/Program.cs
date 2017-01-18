using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace TuntiHarj1
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterFloor();
        }
        static void EnterFloor()
        {
            Elevator elevator = new Elevator();
            int exit = 5;

            for (int i = 0; i < exit; i++)
            {
                Console.Write("Give a new floor number: ");
                elevator.Floor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(elevator.ToString());
            } 
        }
    }
}
