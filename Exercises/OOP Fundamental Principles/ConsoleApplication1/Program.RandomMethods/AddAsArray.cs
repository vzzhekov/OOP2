using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class AddAsArray
    {
        public static Array MyArray(string number)
        {
            if (number.Length > 10000)
            {
                Console.WriteLine("The amount of digits is beyond what this program could handle!");
            }
            char[] numberAsArray = new char[number.Length];
            for (int i = 1; i < number.Length; i++)
            {
                numberAsArray[i] = number[i - 1];
                
            }
            numberAsArray[0] = number[number.Length -1];
            return numberAsArray; 
        }

    }
}
