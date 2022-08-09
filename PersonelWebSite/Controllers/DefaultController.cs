using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(Contact contact)
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());
            contactManager.TAdd(contact);
            return PartialView();
        }


    }
}
