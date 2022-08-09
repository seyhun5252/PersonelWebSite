using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        public String LinkTwitter { get; set; }
        public String LinkFacebook { get; set; }
        public String LinkLinkedin { get; set; }
        public String LinkInstagram { get; set; }
    }
}
