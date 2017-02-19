using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTesting.Startup))]
namespace GitTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
