using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portal_Mvc.Startup))]
namespace Portal_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
