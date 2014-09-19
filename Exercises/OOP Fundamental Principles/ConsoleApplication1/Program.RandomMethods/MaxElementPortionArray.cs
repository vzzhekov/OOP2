using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public static class MaxElementPortionArray
    {
       //{1,4,24,5,1,6,7,8,1,23,4,5,6} 
       public static int MaxNumber(int[] numbers, int startingPostion)
       {
           int bestInteger = 0; 
          
           for (int i = startingPostion; i < numbers.Length; i++)
           {
               if (numbers[i - 1] < numbers[i])
               {
                   bestInteger = numbers[i];
               }
               else bestInteger = numbers[i - 1];

               
           }
           return bestInteger;
       }

    }
}
