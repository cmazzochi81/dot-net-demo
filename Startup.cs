using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheCorridorGroupMd.Startup))]
namespace TheCorridorGroupMd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
