using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCpgs.Startup))]
namespace MVCpgs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
