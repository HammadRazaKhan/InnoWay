using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InnoWay.Startup))]
namespace InnoWay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
