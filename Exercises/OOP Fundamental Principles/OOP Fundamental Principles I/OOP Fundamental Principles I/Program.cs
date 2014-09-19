using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Users;

namespace OOP_Fundamental_Principles_I
{
    class Program
    {
        static void Main()
        {
            string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Firday",
                                      "Saturday",
                                      "Sunday"
                                  };


            int[] numbers = {1,2,3,4,5};
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                Console.WriteLine(daysOfWeek[i]);
            }

          

        }
    }
}
