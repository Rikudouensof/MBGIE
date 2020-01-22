using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBGIE.Startup))]
namespace MBGIE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
