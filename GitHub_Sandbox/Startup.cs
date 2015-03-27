using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHub_Sandbox.Startup))]
namespace GitHub_Sandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
