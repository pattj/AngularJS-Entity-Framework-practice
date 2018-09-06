using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartupAttribute(typeof(WebExperience.Test.Startup))]
namespace WebExperience.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
             
            ConfigureAuth(app);
        }
    }
}
