using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wave.Web.Startup))]
namespace Wave.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            
        }
    }
}
