using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelWebSite.Areas.Member.Models
{
    public class AboutEdit
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutName { get; set; }
        public string AboutDegree { get; set; }
        public string AboutPhone { get; set; }
        public string AboutAdress { get; set; }
        public string AboutBirthday { get; set; }
        public string AboutExperience { get; set; }
        public string AboutEmail { get; set; }
        public IFormFile Url { get; set; }
    }
}
