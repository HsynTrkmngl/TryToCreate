﻿using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_002_RazorViewEngine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
