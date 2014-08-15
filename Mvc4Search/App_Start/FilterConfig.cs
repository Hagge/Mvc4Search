using Mvc4Search.Filters;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Search
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new MyCustomActionFilter());
        }
    }
}