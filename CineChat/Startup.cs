using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CineChat.Startup))]
[assembly: OwinStartup(typeof(CineChat.Startup))]

namespace CineChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }

}
