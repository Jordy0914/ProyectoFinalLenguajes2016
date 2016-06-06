using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prgGestionDeCompañias.Startup))]
namespace prgGestionDeCompañias
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
