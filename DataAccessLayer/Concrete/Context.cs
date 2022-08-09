using EntityLayer.Abstract;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\ProjectsV13;database=PersonelDB ;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<EducationAndExpericence> EducationAndExpericences { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Link> Links{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skil> Skils { get; set; }
       
    }
}
