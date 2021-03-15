using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1S3G4.Models
{
    public class Time
    {
        public Time HourTime { get; set; }

        public List<appInfo> Lines { get; set; } = new List<appInfo>();
    }
}
