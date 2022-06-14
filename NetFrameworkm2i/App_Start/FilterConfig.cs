using System.Web;
using System.Web.Mvc;

namespace NetFrameworkm2i
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
