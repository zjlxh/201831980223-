using System.Web;
using System.Web.Mvc;

namespace _201831980223刘晓辉
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
