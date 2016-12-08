using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrightIdeas.Startup))]
namespace BrightIdeas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
