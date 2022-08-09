using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Service
    {
        [Key]
        public int ServicesID { get; set; }
        public String ServicesTitle { get; set; }
        public String ServicesDescription { get; set; }
    }
}
