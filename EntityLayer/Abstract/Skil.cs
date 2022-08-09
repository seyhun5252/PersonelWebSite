using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Skil
    {
        [Key]
        public int SkilsID { get; set; }
        public String SkilsTitle { get; set; }
        public String SkilsRatio { get; set; }
    }
}
