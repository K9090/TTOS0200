using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T5Lab8
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        static void Print()
        {
            double[] array = { 1.0, 2.0, 3.3, 22.5, 6.3, -4.5, -12.0 };

            try
            {
                Console.WriteLine("Sum: {0:F2}", ArrayCalcs.Sum(array));
                Console.WriteLine("Average: {0:F2}", ArrayCalcs.Avg(array));
                Console.WriteLine("Min: {0:F2}", ArrayCalcs.Min(array));
                Console.WriteLine("Max: {0:F2}", ArrayCalcs.Max(array));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
