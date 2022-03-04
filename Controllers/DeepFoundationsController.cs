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
    public class DeepFoundationsController : Controller
    {
        private readonly ILogger<DeepFoundationsController> _logger;
       private readonly IHostingEnvironment _hostingEnvironment;


        public DeepFoundationsController(ILogger<DeepFoundationsController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            // https://stackoverflow.com/questions/49398965/what-is-the-equivalent-of-server-mappath-in-asp-net-core
            
            List<ProcessModel> processes = ProcessModelData.List("DeepFoundations");
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
