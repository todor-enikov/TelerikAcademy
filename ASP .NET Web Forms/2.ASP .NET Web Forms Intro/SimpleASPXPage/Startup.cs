using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleASPXPage.Startup))]
namespace SimpleASPXPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
