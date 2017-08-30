using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapp_teste.Startup))]
namespace webapp_teste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
