using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetNet.WebApp.Startup))]
namespace PetNet.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
