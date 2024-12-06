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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
