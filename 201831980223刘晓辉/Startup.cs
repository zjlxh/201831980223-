using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_201831980223刘晓辉.Startup))]
namespace _201831980223刘晓辉
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
