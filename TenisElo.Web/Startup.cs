using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using TenisElo.Service;

[assembly: OwinStartupAttribute(typeof(TenisElo.Web.Startup))]
namespace TenisElo.Web
{
    public partial class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<IPlayerService, PlayerService>();
        }

        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();
            ConfigureAuth(app);
            ConfigureServices(services);
        }
    }
}
