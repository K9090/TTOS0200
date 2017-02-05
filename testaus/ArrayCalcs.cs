using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class ArrayCalcs
    {
        public const string ExMsg = "Shit just went sideways...";

        public static double Sum(double[] array)
        {
            double sum = 0;
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            } 
        }

        public static double Avg(double[] array)
        {
            double avg = 0;
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    avg += array[i];
                }
                avg = avg / array.Length;
                return avg;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static double Min(double[] array)
        {
            double min = 0;
            try
            {
                Array.Sort(array);
                min = array[0];
                return min;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static double Max(double[] array)
        {
            double max = 0;
            try
            {
                Array.Sort(array);
                max = array[array.Length - 1];
                return max;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
