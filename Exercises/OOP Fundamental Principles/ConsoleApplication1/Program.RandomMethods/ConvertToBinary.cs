using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class ConvertToBinary
    { // a= 500; 
        public static void Conversion(int a) {

            StringBuilder result = new StringBuilder();

            while (a > 0)
            {
                result.Append(a % 2);
                a /= 2;
            }
            Console.WriteLine(result);
        
        }
    }
}
   