using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(persephone.Startup))]
namespace persephone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
