using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(remoteFirstFrontDoor.Startup))]
namespace remoteFirstFrontDoor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
