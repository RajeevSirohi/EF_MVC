﻿using System.Web;
using System.Web.Mvc;

namespace Rent_a_place
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
