using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Common;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Test newTest = new Test();
            newTest.MyProperty2.Add(124);
            Console.WriteLine(newTest.MyProperty2[0]);
            Call myCall = new Call();
            Call newCall = new Call("dasfsadf", "asdfasdf", "asdfasdf", 1231, "dsafsd", "asdfasdf");
            Call secondCall = new Call("22dasfsadf", "222asdfasdf", "222asdfasdf", 22221231, "222dsafsd", "222asdfasdf");
            Call thirdCall = new Call("33333dasfsadf", "3333asdfasdf", "3333sdfasdf", 22221231, "222dsafsd", "222asdfasdf");
            myCall.CallHistory.Add(newCall);
            Console.WriteLine(myCall.CallHistory[0]);
            GSM myGSM = new GSM();
            myCall.CallHistory.Add(secondCall);
            myGSM.AddToMyCallHistory(thirdCall);
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine(myCall.CallHistory[i]);
            }

        }
    }
}
