using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RasberryPiFinalProject.Startup))]
namespace RasberryPiFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
