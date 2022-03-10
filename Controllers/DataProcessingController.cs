using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ge_app.Models;
using Microsoft.AspNetCore.Authorization;

namespace ge_app.Controllers
{
    // [Authorize]
    // [AllowAnonymous]
    public class DataProcessingController : Controller
    {
        private readonly ILogger<DataProcessingController> _logger;

        public DataProcessingController(ILogger<DataProcessingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // List<ProcessModel> processes = ProcessModelData.List("DataProcessing");
            // return View(processes);
            return View();
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

        public IActionResult GetAGSSummary() {
            return View();

        }
        public IActionResult GetPlaxisResults() {
            return View();

        }
       
    }
}
