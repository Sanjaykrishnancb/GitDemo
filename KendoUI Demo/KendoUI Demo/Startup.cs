using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoUI_Demo.Startup))]
namespace KendoUI_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
