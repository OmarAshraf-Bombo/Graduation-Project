using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RasoberryPiWeb.Startup))]
namespace RasoberryPiWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
