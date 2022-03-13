using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ge_app.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Okta.AspNetCore;
using OktaClients;

namespace OktaMvcLogin

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
            // For connecting to gINT secure AIP    
           
            services.AddSingleton<ITokenService, TokenService>();
          
            services.Configure<OktaConfigs>(Configuration.GetSection("OktaClients"));
            
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=okta.db"));
        
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddCors(options =>
                    {
                       options.AddDefaultPolicy(
                            builder =>
                            {
                                builder.WithOrigins("http://localhost:5001",
                                                    "http://localhost:5000",
                                                    "localhost:5000",
                                                    "localhost:5001",
                                                    "https://ge-app.azurewebsites.net",
                                                    "http://emi-gis-ps.scottwilson.co.uk",
                                                    "https://dev-312326.okta.com"
                                                    )
                                        .AllowCredentials()
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .SetIsOriginAllowed(_ => true);
                                        
                            });
                    });

            services.AddAuthentication(options =>
            {
            options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = OktaDefaults.MvcAuthenticationScheme;
            })
            .AddCookie()
            .AddOktaMvc(new OktaMvcOptions
                {
                OktaDomain = Configuration["OktaSignIn:Domain"],
                ClientId = Configuration["OktaSignIn:ClientId"],
                ClientSecret = Configuration["OktaSignIn:ClientSecret"]
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext dbContext)
        {
            
            dbContext.Database.EnsureCreated();

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
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseCors();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
