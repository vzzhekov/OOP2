using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public static class GSMTest
    {       
        
            public static void GSMToTest(GSM x1, GSM x2)
            {
                GSM[] array = new GSM[] {x1, x2 };
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
                    Console.WriteLine(GSM.getIPhone4S()); 
           }


    }
}
