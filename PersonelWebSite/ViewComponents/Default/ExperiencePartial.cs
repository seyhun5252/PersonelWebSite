using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.ViewComponents.Default
{
    public class ExperiencePartial : ViewComponent
    {
        EducationAndExpericenceManager expericenceManager = new EducationAndExpericenceManager(new EfEducationAndExpericenceDal());

        public IViewComponentResult Invoke()
        {
            var values = expericenceManager.GetList();
            return View(values);
        }
    }
}
