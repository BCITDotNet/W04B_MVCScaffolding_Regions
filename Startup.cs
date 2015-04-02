using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w04b2.Startup))]
namespace w04b2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
