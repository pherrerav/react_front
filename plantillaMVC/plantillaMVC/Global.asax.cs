using System.Web.Mvc;
using System.Web.Optimization;
using AutoMapper;
using System.Web.Routing;
using plantillaMVC.App_Start;

namespace plantillaMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

            IMapper mapper = config.CreateMapper();
        
        }
    }
}
