using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_Web_Controls_and_HTML_Controls.Startup))]
namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
