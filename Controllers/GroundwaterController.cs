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
    public class GroundwaterController : Controller
    {
        private readonly ILogger<GroundwaterController> _logger;

        public GroundwaterController(ILogger<GroundwaterController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          //  List<ProcessModel> processes = ProcessModelData.List("Groundwater");
          //  return View(processes);
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
        
       // [Authorize]
         public IActionResult MONDResults() {
            // Response.Headers.Add("Content-Security-Policy", "default-src 'self' https://*.okta.com/");
            return View();
        }
    }
}
