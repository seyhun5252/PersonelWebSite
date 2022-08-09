using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public String ContactName { get; set; }
        public String ContactEmail { get; set; }
        public String ContactSubject { get; set; }
        public String ContactMessage { get; set; }
    }
}
