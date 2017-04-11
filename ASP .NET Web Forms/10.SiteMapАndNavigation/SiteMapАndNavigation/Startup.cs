using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMapАndNavigation.Startup))]
namespace SiteMapАndNavigation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
