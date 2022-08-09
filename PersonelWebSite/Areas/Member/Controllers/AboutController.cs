using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using PersonelWebSite.Areas.Member.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutDal());


        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.TGetByID(4);
            return View(values);
        }

        [HttpPost]
        public  IActionResult Index(AboutEdit about)
        {
            var about1 = aboutManager.TGetByID(4);
            if (about.Url != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(about.Url.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/aboutImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                about.Url.CopyTo(stream);
                about1.Url = imagename;
            }


            about1.AboutAdress = about.AboutAdress;
            about1.AboutBirthday = about.AboutBirthday;
            about1.AboutDegree = about.AboutDegree;
            about1.AboutDescription = about.AboutDescription;
            about1.AboutEmail = about.AboutEmail;
            about1.AboutExperience = about.AboutExperience;
            about1.AboutName = about.AboutName;
            about1.AboutPhone = about.AboutPhone;
            about1.AboutTitle = about.AboutTitle;




            //var result = await _userManager.UpdateAsync(user);
            aboutManager.TUpdate(about1);
            //if (result2.Succeeded)
            //{
            //    return RedirectToAction("SignIn", "Login");
            //}
            return RedirectToAction("Index", "Profile", new { area = "Member" });
        }
    }
}
