using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspNetMvc.MessageEndSession.Web.Startup))]
namespace aspNetMvc.MessageEndSession.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
