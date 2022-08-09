using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ServiceController : Controller
    {

        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        public IActionResult ServiceDelete(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult ServiceEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServiceEkle(Service service)
        {
            serviceManager.TAdd(service);
            return View();
        }
    }
}
