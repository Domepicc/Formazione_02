using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppl.Startup))]
namespace WebAppl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
