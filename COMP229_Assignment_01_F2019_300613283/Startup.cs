using COMP229_Assignment_01_F2019_300613283.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace COMP229_Assignment_01_F2019_300613283
{
    public class Startup
    {
        // public property
        // This Property store the configuration from appsettings
        public IConfiguration Configuration { get; }

        // Constructor
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup the database connection
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(Configuration["Data:Assignment1Recipes:ConnectionString"]));

            //Everytime time IRecipeRepository is called, it will create the FakeRecipeRepository
            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
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
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Recipe}/{action=List}/{id?}"
                    );
                }
            );
            
            // Send the database to the app
            SeedData.EnsurePopulated(app);

            //app.UseMvcWithDefaultRoute();
        }
    }
}
