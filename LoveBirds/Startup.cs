using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoveBirds.Startup))]
namespace LoveBirds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
