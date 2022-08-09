using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationAndExpericenceManager : IEducationAndExpericenceDal
    {
        IEducationAndExpericenceDal _educationAndExpericenceDal;

        public EducationAndExpericenceManager(IEducationAndExpericenceDal educationAndExpericenceDal)
        {
            _educationAndExpericenceDal = educationAndExpericenceDal;
        }

        public void Delete(EducationAndExpericence t)
        {
            _educationAndExpericenceDal.Delete(t);
        }

        public EducationAndExpericence GetByID(int id)
        {
            return _educationAndExpericenceDal.GetByID(id);
        }

        public List<EducationAndExpericence> GetList()
        {
            return _educationAndExpericenceDal.GetList();
        }

        public void Insert(EducationAndExpericence t)
        {
            _educationAndExpericenceDal.Insert(t);
        }

        public void Update(EducationAndExpericence t)
        {
            _educationAndExpericenceDal.Update(t);
        }
    }
}
