using Microsoft.AspNetCore;

namespace VacationHireInc.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options => options.AddServerHeader = false)
                .UseWebRoot("core")
                .UseStartup<Startup>();
        }
    }
}
