using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LbtcWebsite.Startup))]
namespace LbtcWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
