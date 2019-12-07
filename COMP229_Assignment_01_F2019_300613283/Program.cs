using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace COMP229_Assignment_01_F2019_300613283
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options=>options.ValidateScopes = false) //Disabling Scope Verification
                .Build();
    }
}
