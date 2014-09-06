using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Search.HandlersAndModules
{
    public class MyCustomHttpModule : IHttpModule
    {
        private enum RequestEvent
        {
            BeginRequest,
            EndRequest
        }

        //public String ModuleName
        //{
        //    get { return "MyCustomHttpModule"; }
        //}
        
        public void Dispose()
        {
        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += context_BeginRequest;
            application.EndRequest += context_EndRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            HttpContext context = GetHttpContext((HttpApplication)sender);
            HandleRequestForFileExtensions(context, GetFileExtension(context), RequestEvent.BeginRequest);
        }

        private HttpContext GetHttpContext(HttpApplication httpApplication)
        {
            return httpApplication.Context;
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            HttpContext context = GetHttpContext((HttpApplication)sender);
            HandleRequestForFileExtensions(context, GetFileExtension(context), RequestEvent.EndRequest);
        }

        private string GetFileExtension(HttpContext context)
        {
            return
                VirtualPathUtility.GetExtension(
                    context.Request.FilePath);
        }

        private void HandleRequestForFileExtensions(HttpContext context, string fileExtension, RequestEvent requestEvent)
        {
            if (fileExtension.ToLower() == ".aspx")
            {
                switch (requestEvent)
                {
                    case RequestEvent.BeginRequest:
                        context.Response.Write(string.Format("<h1>HttpModule at beginRequest sees that you want a .aspx resource</h1>"));
                        break;
                    case RequestEvent.EndRequest:
                        context.Response.Write(string.Format("<h1>HttpModule at endRequest sees that you want a .aspx resource</h1>"));
                        break;
                }
            }
            else
            {
                context.Response.Write(string.Format("<h1>HttpModule at unknown part of request sees that you want a resource: {0}</h1>", fileExtension));
            }
        }
    }
}