using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cattion.Startup))]
namespace Cattion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
