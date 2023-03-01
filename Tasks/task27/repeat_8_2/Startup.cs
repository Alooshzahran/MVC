using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(repeat_8_2.Startup))]
namespace repeat_8_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
