using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class NumberToReverse
    {

        public static void Reverse(string input)
        {
            int stringEnd = input.Length;

            StringBuilder result = new StringBuilder();
            for (int i = (stringEnd-1); i >= 0; i--)
            {
                result.Append(input[i]);
            }

            Console.WriteLine(result);
        }
    }
}
