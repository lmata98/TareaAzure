using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bases.Startup))]
namespace bases
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
