using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;

namespace ge_app
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
               services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Allows only http will checking code and connection to http://emi-gis-ps.scottwilson.co.uk/ is without ssl
            // app.UseHttpsRedirection();
          
            app.UseStaticFiles();
            // app.UseStaticFiles(new StaticFileOptions
            //     {
            //         FileProvider = new PhysicalFileProvider(
            //             Path.Combine(env.ContentRootPath, "appdata")),
            //         RequestPath = "/appdata"
            //     });
             app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, "static")),
                    RequestPath = "/static"
                });
                
             app.UseMvc(routes =>
                {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller=Home}/{action=Index}/{id?}");
                });

            // app.UseRouting();

            // app.UseAuthentication());

            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapControllerRoute(
            //         name: "default",
            //         pattern: "{controller=Home}/{action=Index}/{id?}");
            //     endpoints.MapControllerRoute(
            //         name: "BearingResistance",
            //         pattern: "{controller=BearingResistance}/{action=Index}/{id?}");    
            // });

            // setup app's root folders
            AppDomain.CurrentDomain.SetData("ContentRootPath", env.ContentRootPath);
            // AppDomain.CurrentDomain.SetData("WebRootPath", env.WebRootPath);
        }
    }
}
