using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baitap3.Startup))]
namespace baitap3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
