using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(urMaps.Startup))]
namespace urMaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
