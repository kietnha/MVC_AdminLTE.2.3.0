using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.AdminLTE._2._3._0.Startup))]
namespace MVC.AdminLTE._2._3._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
