using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1S3G4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project1S3G4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {

            List<string> timeList = new List<string>();
            
            foreach(Time t in Time.GetTimes())
            {
                timeList.Add(string.Format($"{t.HourTime}"));
            }

            return View(timeList);
        }

        public IActionResult SignUp(appInfo signUp)
        {
            appTempStorage.AddApplication(signUp);
            return View();
        }

        public IActionResult ViewAppointment()
        {
            return View(appTempStorage.Applications);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
