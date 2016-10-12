using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JlaRecruitmentProj.Startup))]
namespace JlaRecruitmentProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
