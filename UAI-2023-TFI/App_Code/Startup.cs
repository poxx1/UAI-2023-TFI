using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UAI_2023_TFI.Startup))]
namespace UAI_2023_TFI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
