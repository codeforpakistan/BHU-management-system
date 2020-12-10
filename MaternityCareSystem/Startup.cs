using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaternityCareSystem.Startup))]
namespace MaternityCareSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
