using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AnveanOnion.Util;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;

namespace AnveanOnion
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NinjectModule registration = new NinjectRegistration();
            var kernel = new StandardKernel(registration);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

        }
    }
}
