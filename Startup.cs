using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tk848615_MIS4200.Startup))]
namespace tk848615_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
