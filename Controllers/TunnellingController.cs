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
using Microsoft.AspNetCore.Authorization;

namespace ge_app.Controllers
{
    // [Authorize]
    // [AllowAnonymous]
    public class TunnellingController : Controller
    {
        private readonly ILogger<TunnellingController> _logger;
       private readonly IHostingEnvironment _hostingEnvironment;


        public TunnellingController(ILogger<TunnellingController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
         public IActionResult Index()
        {
            // https://stackoverflow.com/questions/49398965/what-is-the-equivalent-of-server-mappath-in-asp-net-core
            
            // List<ProcessModel> processes = ProcessModelData.List("Tunnelling");
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
    }
}
