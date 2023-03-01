using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task_8_2.Startup))]
namespace Task_8_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
