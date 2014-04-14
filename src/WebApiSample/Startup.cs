using System.Web.Http;
using Microsoft.Owin.Extensions;
using Owin;

namespace WebApiSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            app.UseWebApi(config);
            app.UseNancy();
            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}