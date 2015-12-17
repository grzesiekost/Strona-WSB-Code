using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strona_WSB_Code.Startup))]
namespace Strona_WSB_Code
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
