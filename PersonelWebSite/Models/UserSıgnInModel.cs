using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Models
{
    public class UserSıgnInModel
    {
        [Required(ErrorMessage = "Lüften email giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lüften Şifrenizi giriniz")]
        public string password { get; set; }


    }
}
