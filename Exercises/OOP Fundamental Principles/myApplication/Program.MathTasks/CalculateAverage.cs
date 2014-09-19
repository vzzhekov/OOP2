using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.MathTasks
{
    public static class CalculateAverage
    {
        public static decimal Average(int[] numbers)
        {
            if (numbers == null)
            {
                Console.WriteLine("Please provide a full list of integers");
            }
            decimal result = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            result = sum / numbers.Length;
            return result;
        }
    }
}
