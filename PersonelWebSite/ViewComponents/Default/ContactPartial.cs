using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.ViewComponents.Default
{
    public class ContactPartial : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Contact contact)
        //{
        //    contactManager.TAdd(contact);
        //    return View();
        //}
    }
}
