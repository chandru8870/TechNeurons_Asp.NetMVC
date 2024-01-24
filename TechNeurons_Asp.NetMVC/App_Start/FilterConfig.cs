using System.Web;
using System.Web.Mvc;

namespace TechNeurons_Asp.NetMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
