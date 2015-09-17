using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_Exercise1.Startup))]
namespace Git_Exercise1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
