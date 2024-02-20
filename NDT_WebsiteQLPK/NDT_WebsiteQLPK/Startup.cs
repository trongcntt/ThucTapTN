using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NDT_WebsiteQLPK.Startup))]
namespace NDT_WebsiteQLPK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
