using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProvaMensal27_09_2017.Startup))]
namespace WebAppProvaMensal27_09_2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
