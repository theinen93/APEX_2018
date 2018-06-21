using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdageTracker.Web.Startup))]
namespace AdageTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
