using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EChartDemo.Startup))]
namespace EChartDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
