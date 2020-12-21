using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace FethiTekyaygilWebsite.MVC
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; }

        public IConfiguration Configuration { get; }
        public Startup(IHostingEnvironment env, IConfiguration config)
        {
            this.Environment = env;
            this.Configuration = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddResponseCaching();
            services.AddCors();
            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            //services.AddDbContext<GenericDatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MsSQL")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(o =>
            {
                o.LoginPath = "/Admin/LoginPage/";
                o.ExpireTimeSpan = TimeSpan.FromMinutes(120);
            });

            services.AddLocalization(o =>
            {
                o.ResourcesPath = "Resources";
            });

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true; options.Providers.Add<BrotliCompressionProvider>();
            });
            //services.AddResponseCaching();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
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
            app.UseResponseCaching();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            var supportedCultures = new List<CultureInfo>
                    {
                    new CultureInfo("tr-TR"),
                    new CultureInfo("en-US"),
                    };

            var localizationOptions = new RequestLocalizationOptions
            {
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                DefaultRequestCulture = new RequestCulture("tr-TR"),
            };
            var requestProvider = new RouteDataRequestCultureProvider();
            localizationOptions.RequestCultureProviders.Insert(0, requestProvider);


            app.UseRouter(routes =>
            {
                routes.MapMiddlewareRoute("{culture=tr-TR}/{*mvcRoute}", subApp =>
                {
                    subApp.UseRequestLocalization(localizationOptions);

                    subApp.UseMvc(mvcRoutes =>
                    {
                        mvcRoutes.MapRoute(
                            name: "default",
                            template: "{culture=tr-TR}/{controller=Home}/{action=Index}/{id?}");

                        mvcRoutes.MapRoute(
                         name: "default2",
                         template: "{culture=tr-TR}/homepage",
                         defaults: new { controller = "Home", action = "Index" });

                        mvcRoutes.MapRoute(
                            name: "videoDefault",
                            template: "{culture=tr-TR}/videos",
                            defaults: new { controller = "Videos", action = "Index" });

                        mvcRoutes.MapRoute(
                        name: "episodeDefault",
                            template: "{culture=tr-TR}/videos/{id}/{title}",
                            defaults: new { controller = "Videos", action = "Episode" });

                    //mvcRoutes.MapRoute(
                    //       name: "episodeDefault",
                    //       template: "{culture=tr-TR}/episode/{id}",
                    //       defaults: new { controller = "Videos", action = "Episode" });

                        mvcRoutes.MapRoute(
                          name: "allEpisodeDefault",
                          template: "{culture=tr-TR}/videos/all",
                          defaults: new { controller = "Videos", action = "AllVideos" });
                    });
                });
            });
            //app.UseMvc();
        }
    }
}
