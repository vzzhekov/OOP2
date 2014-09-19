using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.MathTasks;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<------------------------------------------------------------------------------>");
            Console.WriteLine("Please follow the instructions. Please enter the type of math operation you would like to perform. Either type 'Average' or 'Linear' and follow the instructions. Do not worry about upper or lower case letters!");
            Console.WriteLine("<------------------------------------------------------------------------------>");
            string caseSwitch = Console.ReadLine();
            
            switch (caseSwitch.ToUpper())
            {
                case "AVERAGE":
                    int[] numbers = { };
                    Console.WriteLine(CalculateAverage.Average(numbers));
                    break;
                case "LINEAR":               
                    LinearEquation.Equasion();
                    break;
                default:
                    Console.WriteLine("You did not enter a valid input!");
                    break; 

            }



            

            


        }
    }
}
