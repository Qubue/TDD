using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUnitTesting.Startup))]
namespace MVCUnitTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
