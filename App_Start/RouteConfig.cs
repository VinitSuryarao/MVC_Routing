using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Added for Attribute Routing
            routes.MapMvcAttributeRoutes(); 

            //// For Conventional Routing
            //routes.MapRoute(
            //    name: "Client",
            //    url: "Client/{ClientNo}",
            //    defaults: new { controller = "Home", action = "GetClient" }
            //);

            //// Set Default ExNo In Case EX not Passed
            //routes.MapRoute(
            //    name: "Exchange",
            //    url: "Exchange/{ExNo}",
            //    defaults: new { controller = "Home", action = "GetExchange", ExNo = 111 } 
            //);

            //// Constraints added in case for user inpurt wrong data
            //routes.MapRoute(
            //    name: "Broker",
            //    url: "Broker/{BrokerNo}",
            //    defaults: new { controller = "Home", action = "GetBroker" },
            //    constraints : new { BrokerNo = @"\d+"}
            //);

            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           

        }
    }
}
