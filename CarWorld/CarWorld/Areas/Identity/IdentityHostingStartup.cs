using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CarWorld.Areas.Identity.IdentityHostingStartup))]
namespace CarWorld.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}