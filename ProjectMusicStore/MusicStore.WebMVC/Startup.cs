using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStore.WebMVC.Startup))]
namespace MusicStore.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
