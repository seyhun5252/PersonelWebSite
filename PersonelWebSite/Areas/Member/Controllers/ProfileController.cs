using EntityLayer.Abstract;
using Microsoft.AspNetCore.Identity;
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
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.SurName;
            userEditViewModel.phoneNumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            userEditViewModel.userName = values.UserName;

            return View(userEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.imageURL != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.imageURL.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.imageURL.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.name;
            user.SurName = p.surname;
            user.UserName = p.userName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
