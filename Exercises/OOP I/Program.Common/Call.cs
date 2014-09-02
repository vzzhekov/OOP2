using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public class Call : GSM
    {
        


        private string date;
        private string time;
        private string phoneNumber;
        private int seconds;
        private List<Call> callHistory;
       
        
        public List<Call> CallHistory
        {
            get
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
       

        public Call() { }

        public Call(string date, string time, string phoneNumber, int seconds, string model, string manufacturer)
            : base(model, manufacturer)
        {
            
            this.date = date;
            this.time = time;
            this.phoneNumber = phoneNumber;
            this.seconds = seconds;
            
        }
        public string getDate()
        {
            return this.date;
        }

        public string getTime()
        {
            return this.time;
        }

        public int Seconds()
        {
            return this.seconds;
        }

    }
}
