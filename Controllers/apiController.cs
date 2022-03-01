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
    public class apiController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private readonly IHostingEnvironment _hostingEnvironment;


        public apiController(ILogger<HomeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public async Task<IActionResult> AllPages()
        {
            var processes = ProcessModelData.items();
            return Ok(processes);
        }
        public async Task<IActionResult> Page(string name)
        {
            var processes = ProcessModelData.item(name);
            return Ok(processes);
        }
    }
}
