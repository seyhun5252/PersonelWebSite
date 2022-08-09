using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Models
{
    public class UserViewModelRegister
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        
        
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password{ get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar Giriniz")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
