﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.ViewComponents.Default
{
    public class PortfolioPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
