using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuyetTienWed.Startup))]
namespace QuyetTienWed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
