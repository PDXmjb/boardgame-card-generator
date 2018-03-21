using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardGenerator.Startup))]
namespace CardGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
