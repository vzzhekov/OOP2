using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Common;


namespace Program
{
    
    class Program
    {

       
        static void Main()
        {
            Point3D pointA = new Point3D(5, -16, 4);
            Point3D pointB = new Point3D(4, 22, 5);

            CalculateDistance.Distance(pointA, pointB);

            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(4);
            Console.WriteLine(numbers[0]);

            GenericList<string> strings = new GenericList<string>();
            strings.Add("FirstString");
            strings.Add("SecondString");

            for (var i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[i]);
            }


        }
    }
}

