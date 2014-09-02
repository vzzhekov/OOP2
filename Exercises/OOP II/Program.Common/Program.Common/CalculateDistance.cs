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
            string pointAInner = pointA.ToString();
            string pointBInner = pointB.ToString();
            Console.WriteLine(pointAInner[1]);
            int x1 = (Convert.ToInt32(pointAInner[0])) - 48;
            int x2 = (Convert.ToInt32(pointBInner[0])) - 48;
            int y1 = (Convert.ToInt32(pointAInner[1])) - 48;
            int y2 = (Convert.ToInt32(pointBInner[1])) - 48;
            int z1 = (Convert.ToInt32(pointAInner[2])) - 48;
            int z2 = (Convert.ToInt32(pointBInner[2])) - 48;
            double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
            
            Console.WriteLine("The result is {0}", result);
        }

    }
}
