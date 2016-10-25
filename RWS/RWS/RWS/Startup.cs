using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RWS.Startup))]
namespace RWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
