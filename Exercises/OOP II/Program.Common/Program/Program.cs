﻿using System;
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
            
        }
    }
}