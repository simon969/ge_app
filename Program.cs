using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore;
// using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ge_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>  
                    {  
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));  
                    logging.AddConsole();  
                    logging.AddDebug();
                    })  
                .UseStartup<Startup>()
                .UseKestrel(options => {
                    options.Limits.MaxRequestBodySize = null;
                    options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(20);
                   });
    }
    
}
