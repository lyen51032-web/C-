using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ID.Startup))]
namespace ID
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
