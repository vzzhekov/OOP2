using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    class Display
    {
        private string size { get; set;}
        private int numberOfColors { get; set; }

        public Display() { }


         public Display(string size, int numberOfColors) {
             this.size = size;
                this.numberOfColors = numberOfColors;
        }


    }
}
