using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Card_generator.Startup))]
namespace Card_generator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
