using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finanzas_Personales.Startup))]
namespace Finanzas_Personales
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
