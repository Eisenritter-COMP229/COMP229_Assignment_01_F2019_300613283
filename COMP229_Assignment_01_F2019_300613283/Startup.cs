using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using COMP229_Assignment_01_F2019_300613283.Models;

namespace COMP229_Assignment_01_F2019_300613283
{
    public class Startup
    {
        // public property
        public IConfiguration Configuration { get; }

        // Constructor
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Dependency Injection
            services.AddTransient<IRecipeRepository, FakeRecipeRepository>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // This page shows the error that is going on
            app.UseStatusCodePages();

            // wwwroot folder to store bootstrap files
            app.UseStaticFiles();

            // Set up the routing of MVC
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Recipe}/{action=List}/{id?}"
            //        );
            //}
            //);

            app.UseMvcWithDefaultRoute();
        }
    }
}
