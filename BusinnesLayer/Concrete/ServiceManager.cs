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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
