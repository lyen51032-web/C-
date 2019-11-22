using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDpaw.Startup))]
namespace IDpaw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
