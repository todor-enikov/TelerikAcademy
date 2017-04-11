using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumNumbers.Startup))]
namespace SumNumbers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
