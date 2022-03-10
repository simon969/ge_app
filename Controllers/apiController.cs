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
    [Route("api/[controller]")]
    [ApiController]  public class PageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       private readonly IHostingEnvironment _hostingEnvironment;


        public PageController(ILogger<HomeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }
      
        [HttpGet]
        public async Task<IActionResult> Page()
        {
            var processes = ProcessModelData.items();
            return Ok(processes);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Page(string id)
        {
            var processes = ProcessModelData.item(id);
            return Ok(processes);
        }
    }
}
