using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StructureMapDemo.Startup))]
namespace StructureMapDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
