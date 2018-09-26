using Bontana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bontana
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("productDetail", "san-pham/{Tag}", new { controller = "Product", action = "ProductDetail", tag = UrlParameter.Optional }, new { controller = "^p.*", action = "^ProductDetail$" });
            routes.MapRoute("ProductList", "{Tag}.html", new { controller = "Product", action = "productList", tag = UrlParameter.Optional }, new { controller = "^p.*", action = "^productList$" });

            routes.MapRoute("producttag", "tag/{Tag}", new { controller = "Product", action = "producttag", tag = UrlParameter.Optional }, new { controller = "^p.*", action = "^producttag$" });

            routes.MapRoute("newsdetail", "tin-tuc/{Tag}", new { controller = "news", action = "newsDetail", tag = UrlParameter.Optional }, new { controller = "^n.*", action = "^newsDetail$" });
            routes.MapRoute("Tagnews", "TagNews/{Tag}", new { controller = "news", action = "tagNews", tag = UrlParameter.Optional }, new { controller = "^n.*", action = "^tagNews$" });
            routes.MapRoute("Newslist", "0/{Tag}", new { controller = "news", action = "listNews", tag = UrlParameter.Optional }, new { controller = "^n.*", action = "^listNews$" });
            routes.MapRoute("Bao-gia", "bao-gia/bao-gia-{Tag}", new { controller = "baogia", action = "index", tag = UrlParameter.Optional }, new { controller = "^b.*", action = "^index$" });
            routes.MapRoute(name: "tim-kiem", url: "tim-kiem", defaults: new { controller = "product", action = "search" });
            routes.MapRoute(name: "Error", url: "Error", defaults: new { controller = "Default", action = "Error" });
            routes.MapRoute(name: "Contact", url: "Lien-he", defaults: new { controller = "contactCustom", action = "Index" });
            routes.MapRoute(name: "SearchProduct", url: "SearchProduct", defaults: new { controller = "Products", action = "SearchProduct" });
            routes.MapRoute(name: "Order", url: "gio-hang", defaults: new { controller = "Order", action = "OrderIndex" });
            routes.MapRoute(name: "Maps", url: "Ban-do", defaults: new { controller = "MapsDisplay", action = "Mapsdetail" });
            routes.MapRoute(name: "Admin", url: "Admin", defaults: new { controller = "Login", action = "LoginIndex" });
//            routes.MapRoute(
//    name: "CmsRoute",
//    url: "{*tag}",
//    defaults: new { controller = "product", action = "productList" },
//    constraints: new { tag = new clsUrlConstraint() }
//);
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new { controller = "Default", action = "Banquyen", id = UrlParameter.Optional }
            );
        }
    }
}
