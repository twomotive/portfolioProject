using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinnesLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
