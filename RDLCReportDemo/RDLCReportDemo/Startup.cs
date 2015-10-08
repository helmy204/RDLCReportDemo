using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RDLCReportDemo.Startup))]
namespace RDLCReportDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
