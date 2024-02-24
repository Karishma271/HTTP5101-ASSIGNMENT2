using System.Web;
using System.Web.Mvc;

namespace HTTP5101_ASSIGNMENT2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
