using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public class Battery
    {
        private int hoursIdle { get; set; }
        private int hoursTalk { get; set; }
        private BatteryType batteryType { get; set; }

        public Battery() { }

        public Battery(int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
             this.hoursIdle = hoursIdle;
             this.hoursTalk = hoursTalk;
             this.batteryType = batteryType; 
        }

    }
}
