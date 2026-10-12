using DotNetEnv;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
 
namespace WebStorageSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.NoClobber().Load();
            CreateHostBuilder(args).Build().Run();
        }
 
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}