using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_project_dotnet.Startup))]
namespace MVC_project_dotnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
