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
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);

        }
    }
}
