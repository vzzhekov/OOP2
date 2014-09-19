using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class NumberOfRepetitions
    {
       public static int CheckNumber(int x, int[] thearray) {

           int count = 0; 
           for (int i = 0; i < thearray.Length; i++)
           {
               if (x == thearray[i])
               {
                   count++;

               }

                
           }
           return count;
       }
    }
}
