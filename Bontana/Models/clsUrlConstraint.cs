using Bontana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
 namespace Bontana.Models
{
    public class clsUrlConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,  RouteValueDictionary values, RouteDirection routeDirection)
        {
            BontanaContext db = new BontanaContext();
             if (values[parameterName] != null)
            {
                var tag = values[parameterName].ToString();
                 return db.TblGroupProduct.Any(p => p.Tag == tag);
            }
            return false;
        }
    }
}