using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1S3G4.Models
{
    public class appTempStorage
    {
        private static List<appInfo> AppList = new List<appInfo>();

        public static IEnumerable<appInfo> Applications => AppList;

        public static void AddApplication(appInfo addList)
        {
            AppList.Add(addList);
        }
    }
}
