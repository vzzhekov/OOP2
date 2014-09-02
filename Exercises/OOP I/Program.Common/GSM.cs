using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public class GSM  
    {
        Battery myBattery = new Battery();
        
        
        private string model { get; set; }
        private string manufacturer { get; set; }
        private static string iPhone4S { get; set; } 

        public GSM() { }

        public GSM(string model, string manufacturer) {
            this.model = model;
            this.manufacturer = manufacturer;
            

        }


        
 
        public string Model()
        {
            return this.model; 
        }

        public string Manufacturer()
        {
            return this.manufacturer;
        }

        public static string getIPhone4S()
        {
                 return iPhone4S; 
          
            
        }
        public static void setIPhone4S(string value)
        {
            iPhone4S = value; 


        }



        public override string ToString()
        {
            
            return "The Model is: " + model.ToString()+ "The Manufacturer is: " + manufacturer.ToString();
            
        }
        
    }
}
