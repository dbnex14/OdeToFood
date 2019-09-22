using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using OdeToFood.Web.App_Start;
using System.Web.Optimization;

namespace OdeToFood.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // make sure above line is added before RouteConfig below
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.RegisterContainer(GlobalConfiguration.Configuration);
        }
    }
}
