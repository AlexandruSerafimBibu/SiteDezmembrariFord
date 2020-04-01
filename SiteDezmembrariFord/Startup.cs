using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteDezmembrariFord.Startup))]
namespace SiteDezmembrariFord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
