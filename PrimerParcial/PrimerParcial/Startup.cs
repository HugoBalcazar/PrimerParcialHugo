using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimerParcial.Startup))]
namespace PrimerParcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
