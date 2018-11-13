using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deportes.Startup))]
namespace Deportes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
