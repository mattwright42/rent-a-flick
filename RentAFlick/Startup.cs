using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentAFlick.Startup))]
namespace RentAFlick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
