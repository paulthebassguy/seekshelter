using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shelterme.Startup))]
namespace Shelterme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
