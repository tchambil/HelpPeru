using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebHelpPeru.Startup))]

namespace WebHelpPeru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}