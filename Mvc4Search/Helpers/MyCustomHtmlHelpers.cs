using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Search.Helpers
{
    public static class MyCustomHtmlHelpers
    {
        public static MvcHtmlString helloHelper()
        {
            return new MvcHtmlString("<p>hello from mvc 4 custom html helper!</p>");
        }
    }
}