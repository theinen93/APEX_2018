using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdageTracker.Startup))]
namespace AdageTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
