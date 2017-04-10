using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamensarbeteMatsDrakneid.Startup))]
namespace ExamensarbeteMatsDrakneid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
