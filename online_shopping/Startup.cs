using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(online_shopping.Startup))]
namespace online_shopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
