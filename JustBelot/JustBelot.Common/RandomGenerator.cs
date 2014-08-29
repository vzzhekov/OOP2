using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public static class RandomGenerator
    {

        private static Random randomGenerator;

        static RandomGenerator()
        {
            randomGenerator = new Random();
        }

        public static int GetNext(int minValue, int maxValue)
        {   
            return randomGenerator.Next(minValue, maxValue + 1);

        }

        


    }
}
