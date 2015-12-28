using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schizo.Startup))]
namespace Schizo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
