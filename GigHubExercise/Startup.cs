using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubExercise.Startup))]
namespace GigHubExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
