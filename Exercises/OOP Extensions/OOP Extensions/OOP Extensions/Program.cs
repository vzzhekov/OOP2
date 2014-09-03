using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Common;

namespace OOP_Extensions
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8 };

            var querySmallNumbers = from num in numbers
                                    where num < 5
                                    select num;

            foreach (var num in querySmallNumbers)
            {
                Console.WriteLine("{0}", num);
            }
           

        }
    }
}
