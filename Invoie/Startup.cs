using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Invoie.Startup))]
namespace Invoie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
