using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using OktaClients;
using ge_app.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ge_app.Controllers
{
    [Controller]  public class ClientAPIController : Controller
    {
        private readonly ILogger<ClientAPIController> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ITokenService _tokenService;
        private readonly HttpClient _httpClient = new HttpClient();

        public ClientAPIController(ILogger<ClientAPIController> logger, IHostingEnvironment hostingEnvironment, ITokenService tokenService)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            _tokenService = tokenService;
        }
        public async Task<IActionResult> Index() {
                return View();

        }
        public async Task<IActionResult> gINTLocations(int gINTProjectID)
        {
            var token = await _tokenService.GetToken("gINT");
            Response.Headers.Add ("Authorization","Bearer "+ token);
           
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, token);
            var res = await _httpClient.GetAsync($"http://emi-gis-ps.scottwilson.co.uk/ge_gint4/api/project/{gINTProjectID}");
            if (res.IsSuccessStatusCode)
            {
                var content = await res.Content.ReadAsStringAsync();
                // var journalLogs = JsonConvert.DeserializeObject<List<JournalLog>>(content);
                // return journalLogs;
                return Content (content);
            }
            return BadRequest();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

    
  }

}
