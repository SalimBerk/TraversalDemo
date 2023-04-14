using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetAll()
        {
           return _featureDal.getAll();   
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
