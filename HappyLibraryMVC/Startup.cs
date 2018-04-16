using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappyLibraryMVC.Startup))]
namespace HappyLibraryMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
