using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Common;
using System.Timers;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            bool playing = true;
            int counter = 0;
            while (playing)
            {
                Console.WriteLine("------------------------------------------------");
                try {
                    if (counter > 0)
                    {
                        Console.WriteLine("Lets go again!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the number!");
                    }
                Console.Write("The number is: ");
                string str = Console.ReadLine();
                int.Parse(str);
                Console.WriteLine(" > Parsing was successful.");
                Console.WriteLine(" > Your number is {0}", str);
                counter++;
                    }
                catch (FormatException ef)
                {
                    Console.WriteLine("**********Error, error!*************");
                    Console.WriteLine(ef.Message);
                    Console.WriteLine(ef.Source);
                    Console.WriteLine("************************************");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine(" > This is the end of the program.");

                

            }


        }
    }
}
