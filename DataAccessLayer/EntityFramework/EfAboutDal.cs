using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{

    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public List<About> GetListWithReservationsByWaitAprroval()
        {
            using (var context = new Context())
            {
                var values = context.Abouts.Count(p => p.AboutId == p.AboutId);
                List<About> a = (List<About>)context.Abouts.Where(p => p.AboutId == values).ToList();

                return  a;
            }
            
        }
    }
}
