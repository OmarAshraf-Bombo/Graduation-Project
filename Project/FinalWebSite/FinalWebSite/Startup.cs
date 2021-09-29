using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebSite.Startup))]
namespace FinalWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
