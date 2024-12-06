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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void TAdd(Feature entity)
        {
            _featureDal.Insert(entity);
        }
        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }
        public Feature TGetByID(int id)
        {
            return _featureDal.GetById(id);
        }
        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }
        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
