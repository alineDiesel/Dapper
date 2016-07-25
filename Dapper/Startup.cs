using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dapper.Startup))]
namespace Dapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
