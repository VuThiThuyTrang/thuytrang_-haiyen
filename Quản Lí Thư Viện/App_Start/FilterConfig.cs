using System.Web;
using System.Web.Mvc;

namespace Quản_Lí_Thư_Viện
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
