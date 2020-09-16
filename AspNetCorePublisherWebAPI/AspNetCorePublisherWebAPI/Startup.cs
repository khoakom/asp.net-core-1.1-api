﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCorePublisherWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AspNetCorePublisherWebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped(typeof(IBookstoreRepository), typeof(BookstoreMockRepository));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //    name: "default",
            //    template: "{controller=Home}/{action=Index}/{id?}");
            //});

            //app.Run(async (context) =>
            //{
            //    var message = Configuration["Message"];
            //    await context.Response.WriteAsync(message);
            //});
        }

        private void ConfigureRoutes(IRouteBuilder routeBuildrer)
        {
            routeBuildrer.MapRoute("Default", "{controller=Home}/{action=Index}/{Id?}");
        }
    }
}
