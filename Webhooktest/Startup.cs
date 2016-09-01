using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webhooktest.Startup))]
namespace Webhooktest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
