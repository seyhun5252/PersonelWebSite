using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.ViewComponents.Default
{
    public class SkillPartial : ViewComponent
    {
        SkilManager skilManager = new SkilManager(new EfSkilDal());

        public IViewComponentResult Invoke()
        {
            var values = skilManager.TGetList();
            return View(values);
        }
    }
}
