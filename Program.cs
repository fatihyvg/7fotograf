using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace _7fotograf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("https://www.7fotograf.com","http://www.7fotograf.com");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
