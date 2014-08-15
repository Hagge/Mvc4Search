using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Search.Filters
{
    public class MyCustomActionFilter : ActionFilterAttribute
    {
        public string Msg { get; set; }

        // To pass parameters -> use [MyCustomActionFilter(builtInParameter="value")] and retrieve them in the constructor
        public MyCustomActionFilter()
        {
            this.Msg = "Hello from the MyCustomActionFilter property \"Msg\"!";
        }

        // To pass custom parameters -> simply overload the constructor
        public MyCustomActionFilter(string myCustomParameter)
        {
            this.Msg = myCustomParameter;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Before controller logic
            base.OnActionExecuting(filterContext);

            filterContext.HttpContext.Response.Write(this.Msg);
        }
        
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // After controller logic
            base.OnActionExecuted(filterContext);

            filterContext.HttpContext.Response.Write(this.Msg);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // Before View Rendering logic
            base.OnResultExecuting(filterContext);

            filterContext.HttpContext.Response.Write(this.Msg);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            // After View Rendering logic
            base.OnResultExecuted(filterContext);

            filterContext.HttpContext.Response.Write(this.Msg);
        }
    }
}