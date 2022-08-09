using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkilManager : ISkilService
    {
        ISkilDal _skilDal;

        public SkilManager(ISkilDal skilDal)
        {
            _skilDal = skilDal;
        }

        public void TAdd(Skil t)
        {
            _skilDal.Insert(t);
        }

        public void TDelete(Skil t)
        {
            _skilDal.Delete(t);
        }

        public Skil TGetByID(int id)
        {
            return _skilDal.GetByID(id);
        }

        public List<Skil> TGetList()
        {
            return _skilDal.GetList();
        }

        public void TUpdate(Skil t)
        {
            _skilDal.Update(t);
        }
    }
}
