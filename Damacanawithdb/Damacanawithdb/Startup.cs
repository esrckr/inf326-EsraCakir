using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Damacanawithdb.Startup))]
namespace Damacanawithdb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
