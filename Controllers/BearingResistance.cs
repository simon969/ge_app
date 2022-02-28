using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using ge_app.Models;

namespace ge_app.Controllers
{
    public class BearingResistanceController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private readonly IWebHostEnvironment _webHostEnvironment;


        public BearingResistanceController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            // https://stackoverflow.com/questions/49398965/what-is-the-equivalent-of-server-mappath-in-asp-net-core
            
            List<ProcessModel> processes = ProcessModelData.List("BearingResistance");
            return View(processes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
