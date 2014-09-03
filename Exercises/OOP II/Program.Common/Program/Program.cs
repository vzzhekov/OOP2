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
        static void Main(string[] args)
        {

            
            Point3D a = new Point3D(-177,40,3);
            Point3D b = new Point3D(222, 54, 8);
            
            CalculateDistance.Distance(a,b);
            var point = new { x = 3, y = 5 };
            Console.WriteLine(point.ToString());
            var car = new { Brand = "BMW", Color = "Red", Speed = 180 };
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.Speed);
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Color);
            Console.WriteLine(point.Equals(car));

            var arr = new[] {
                new { X =3 , Y = 5},
                new { X = 9, Y = -7},
                new {X = 4, Y = 11}


            };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

            var student = new { Name = "Vilian Zhekov", University = "London School of Economics" };
            Console.WriteLine(student);



        }
    }
}
