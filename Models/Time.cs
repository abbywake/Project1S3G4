using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1S3G4.Models
{
    public class Time
    {
        public String HourTime { get; set; }

        public List<appInfo> Appointment { get; set; } = new List<appInfo>();

        public static Time[] GetTimes()
        {

            Time t1 = new Time
            {
                HourTime = "8:00 AM",
            };

            Time t2 = new Time
            {
                HourTime = "9:00 AM",
            };

            Time t3 = new Time
            {
                HourTime = "10:00 AM",
            };

            Time t4 = new Time
            {
                HourTime = "11:00 AM",
            };

            Time t5 = new Time
            {
                HourTime = "12:00 PM",
            };

            Time t6 = new Time
            {
                HourTime = "1:00 PM",
            };

            Time t7 = new Time
            {
                HourTime = "2:00 PM",
            };

            Time t8 = new Time
            {
                HourTime = "3:00 PM",
            };

            Time t9 = new Time
            {
                HourTime = "4:00 PM",
            };

            Time t10 = new Time
            {
                HourTime = "5:00 PM",
            };

            Time t11 = new Time
            {
                HourTime = "6:00 PM",

            };

            Time t12 = new Time
            {
                HourTime = "8:00 PM",
            };

            Time t13 = new Time
            {
                HourTime = "9:00 PM",
            };

            return new Time[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 };
        }

    
    }
}
