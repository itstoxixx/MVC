using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finalnatopromise.Startup))]
namespace finalnatopromise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
