using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Move
    {
        public static void MakeObjectMove(string a,string input)
        {
            if (input == "move") { 
            StringBuilder movement = new StringBuilder();
            int movementInteger = 0;

            for (int i = 0; i < 10; i++)
            {
                movement.Append("_");
            }
            Console.Write(movement);
            Console.Write(a);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
