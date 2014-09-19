using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public class Car
    {
        private string model;

        public Car(string model)
        {
            this.model = model;
        }


        public void Move()
        {

            Console.WriteLine("Brum Brum");
        }

    }


}
