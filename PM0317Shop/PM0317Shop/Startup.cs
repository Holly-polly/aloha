using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PM0317Shop.Startup))]
namespace PM0317Shop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
