using System.Web;
using System.Web.Mvc;
using WebApiDemo.Infrastructure.Attributes;

namespace WebApiDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new WebApiModelValidationActionFilterAttribute());
        }
    }
}