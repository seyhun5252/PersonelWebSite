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
    public class EgitimController : Controller
    {
        EducationAndExpericenceManager EducationAnd = new EducationAndExpericenceManager(new EfEducationAndExpericenceDal());


        public IActionResult Index()
        {
            var values = EducationAnd.GetList();
            return View(values);
        }


        
        public IActionResult Delete(int id)
        {
            var values = EducationAnd.GetByID(id);
            EducationAnd.Delete(values);
            return RedirectToAction("Index", "Profile", new { area = "Member" });
        }

        [HttpGet]
        public IActionResult EgitimEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult EgitimEkle(EducationAndExpericence e)
        {
            e.EducationAndExpericenceStatus = Request.Form["title"].ToString();
            EducationAnd.Insert(e);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult EgitimGüncelle(int id)
        {
            EducationAndExpericence educationAnd2 = EducationAnd.GetByID(id);

            return View(educationAnd2);
        }

        [HttpPost]
        public IActionResult EgitimGüncelle(EducationAndExpericence education)
        {
            EducationAndExpericence educationAnd22 = EducationAnd.GetByID(education.EducationAndExpericenceID);

            educationAnd22.EducationAndExpericenceTitle = education.EducationAndExpericenceTitle;
            educationAnd22.EducationAndExpericenceLittleTitle = education.EducationAndExpericenceLittleTitle;
            educationAnd22.EducationAndExpericenceDescription = education.EducationAndExpericenceDescription;
            educationAnd22.EducationAndExpericenceDate = education.EducationAndExpericenceDate;
            educationAnd22.EducationAndExpericenceStatus = Request.Form["title"].ToString();



            EducationAnd.Update(educationAnd22);

            return RedirectToAction("Index", "Profile", new { area = "Member" });
        }
    }
}