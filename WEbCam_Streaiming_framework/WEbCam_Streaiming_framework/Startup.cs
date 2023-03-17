using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Owin;
using Owin;
using WEbCam_Streaiming_framework.Hubs;

[assembly: OwinStartupAttribute(typeof(WEbCam_Streaiming_framework.Startup))]
namespace WEbCam_Streaiming_framework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.MapSignalR();
            //   app.MapSignalR<MyHub>("/Connections/MyHub");
            

            app.Map("/EnableDetailedErrors", map =>
            {
                var hubConfiguration = new HubConfiguration
                {
                    EnableDetailedErrors = true
                };

                map.MapSignalR(hubConfiguration);
            });
        }
    }
}