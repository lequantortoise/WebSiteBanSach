using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeSiteBanSach.Startup))]
namespace WeSiteBanSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
