using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SMartDataManager.Startup))]

namespace SMartDataManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
