using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlateSpotter.Startup))]
namespace PlateSpotter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
