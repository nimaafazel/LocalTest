using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalGit.Startup))]
namespace LocalGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
