using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceUI.Startup))]
namespace ECommerceUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
