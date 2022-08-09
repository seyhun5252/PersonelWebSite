using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class EducationAndExpericence
    {
        [Key]
        public int EducationAndExpericenceID { get; set; }
        public String EducationAndExpericenceTitle { get; set; }
        public String EducationAndExpericenceLittleTitle { get; set; }
        public String EducationAndExpericenceDate { get; set; }
        public String EducationAndExpericenceDescription { get; set; }
        public String EducationAndExpericenceStatus { get; set; }
    }
}
