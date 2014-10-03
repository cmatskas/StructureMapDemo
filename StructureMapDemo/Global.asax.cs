using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace StructureMapDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            IoC.IoC.BuildUp(this);
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}