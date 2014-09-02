using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;
        private static Point3D init = new Point3D(0, 0, 0);

        public static Point3D Init
        {
            get { return Point3D.init; }
            
        }

    
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z; 
           
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public override string ToString()
        {
            string a;
            return a = this.x + "," + this.y + "," + this.z;
            
        }
    }
}
