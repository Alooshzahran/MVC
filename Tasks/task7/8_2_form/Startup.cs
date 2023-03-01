using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_8_2_form.Startup))]
namespace _8_2_form
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
