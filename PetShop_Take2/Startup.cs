using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetShop_Take2.Startup))]
namespace PetShop_Take2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
