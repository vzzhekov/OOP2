using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public static class CalculateDistance
    {
        

        public static void Distance(Point3D pointA, Point3D pointB)
        {

            Point3D pointAInner = pointA;
            Point3D pointBInner = pointB;
            
            double result = Math.Sqrt(Math.Pow((pointAInner.X - pointBInner.X), 2) + Math.Pow((pointAInner.Y - pointBInner.Y), 2) + Math.Pow((pointAInner.Z - pointBInner.Z), 2));
            
            Console.WriteLine("The result is: {0}", result);

            
        }

    }
}
