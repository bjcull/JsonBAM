using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonBAM.Startup))]
namespace JsonBAM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
