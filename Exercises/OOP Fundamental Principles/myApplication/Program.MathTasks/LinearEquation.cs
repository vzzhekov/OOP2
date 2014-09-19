using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.MathTasks
{
    public static class LinearEquation
    {
        public static void Equasion()
        {
            Console.Write("Please enter value for a! a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter value for b! b = ");
            int b = int.Parse(Console.ReadLine());
            decimal result = 0;
            result = (-b) / a;
            Console.WriteLine("The result of the linear equation is ---------->{0}",result);
        }
    }
}
