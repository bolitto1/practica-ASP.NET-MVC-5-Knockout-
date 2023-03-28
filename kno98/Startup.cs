using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kno98.Startup))]
namespace kno98
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
