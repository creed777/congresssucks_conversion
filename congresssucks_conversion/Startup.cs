using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(congresssucks_conversion.Startup))]
namespace congresssucks_conversion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
