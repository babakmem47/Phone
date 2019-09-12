using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Telephone.Startup))]
namespace Telephone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
