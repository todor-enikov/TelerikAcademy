using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewWebFormsApp.Startup))]
namespace NewWebFormsApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
