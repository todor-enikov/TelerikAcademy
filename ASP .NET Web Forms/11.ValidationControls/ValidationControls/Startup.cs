using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidationControls.Startup))]
namespace ValidationControls
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
