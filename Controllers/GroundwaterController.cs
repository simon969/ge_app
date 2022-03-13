using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using ge_app.Models;
using OktaClients;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace ge_app.Controllers
{
    // [Authorize]
    // [AllowAnonymous]
    // [EnableCors("MyPolicy")]
    public class GroundwaterController : Controller
    {
        private readonly ILogger<GroundwaterController> _logger;
  
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ITokenService _tokenService;
        private readonly HttpClient _httpClient = new HttpClient();

        public GroundwaterController(ILogger<GroundwaterController> logger, IHostingEnvironment hostingEnvironment, ITokenService tokenService)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            _tokenService = tokenService;
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
        public async Task<IActionResult> MONDResults() {

            var token = await _tokenService.GetToken("gINT");
            Response.Headers.Add ("Authorization",token);
            // Response.Headers.Add("Content-Security-Policy", "default-src 'self' https://*.okta.com/");
            // Response.Headers.Add ("Authorization",token);
            // Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return View();
        }
    }
}
