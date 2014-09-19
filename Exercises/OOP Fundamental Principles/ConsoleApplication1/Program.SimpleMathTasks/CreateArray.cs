using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class CreateArray
    {
        public static Array ArrayCreator()
        {
            int lenght = int.Parse(Console.ReadLine());
            
            
            int[] numbers = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                numbers[0] = int.Parse(Console.ReadLine());
            }
            return numbers; 
        }
    }
}
