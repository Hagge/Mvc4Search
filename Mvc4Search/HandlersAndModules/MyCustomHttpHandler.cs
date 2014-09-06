using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Mvc4Search.HandlersAndModules
{
    public class MyCustomHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            response.Write("<html><body><p>HttpHandler says hello!</p></body></html>");
        }
    }

    //public class MyCustomHttpHandlerRouteHandler : IRouteHandler
    //{
    //    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    //    {
    //        return new MyCustomHttpHandler();
    //    }
    //}
}