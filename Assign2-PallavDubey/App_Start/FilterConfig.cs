﻿using System.Web;
using System.Web.Mvc;

namespace Assign2_PallavDubey
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
