using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Areas.Member.Controllers
{

    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class MessageController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IActionResult Index()
        {
            var values = contactManager.TGetList();
            return View(values);
        }

    }
}
