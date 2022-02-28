using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ge_app.Models;

namespace ge_app.Controllers
{
    public class BearingResistanceController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BearingResistanceController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProcessModel> processes = ProcessModelData.Processes.Where(item => item.controllers.Contains("BearingResistance")).ToList();
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
