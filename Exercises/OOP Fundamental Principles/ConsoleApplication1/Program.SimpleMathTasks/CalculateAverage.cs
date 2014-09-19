using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class CalculateAverage
    {
        public static int Average(int[] array)
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            result = sum / array.Length;
            return result;


        }

    }
}
