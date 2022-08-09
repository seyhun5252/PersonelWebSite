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
    public class SkillController : Controller
    {
        SkilManager skilManager = new SkilManager(new EfSkilDal());

        public IActionResult Index()
        {
            var values = skilManager.TGetList();
            return View(values);
        }
        
        public IActionResult Delete(int id)
        {
            var values = skilManager.TGetByID(id);
            skilManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult SkillEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SkillEkle(Skil skil)
        {
            skilManager.TAdd(skil);
            return View();
        }


        [HttpGet]
        public IActionResult SkillGüncelle(int id)
        {
            Skil skil = skilManager.TGetByID(id);

            return View(skil);
        }

        [HttpPost]
        public IActionResult SkillGüncelle(Skil skil)
        {
            Skil skil1 = skilManager.TGetByID(skil.SkilsID);

            skil1.SkilsTitle = skil.SkilsTitle;
            skil1.SkilsRatio = skil.SkilsRatio;




            //var result = await _userManager.UpdateAsync(user);
            skilManager.TUpdate(skil1);
            //if (result2.Succeeded)
            //{
            //    return RedirectToAction("SignIn", "Login");
            //}
            return RedirectToAction("Index", "Profile", new { area = "Member" });
        }

    }
}
