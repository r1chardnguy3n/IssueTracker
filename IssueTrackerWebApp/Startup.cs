using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IssueTrackerWebApp.Startup))]
namespace IssueTrackerWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
