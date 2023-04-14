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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Desnination> GetAll()
        {
            return _destinationDal.getAll();
        }

        public Desnination GetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Desnination> GetLastFourDestination()
        {
            return _destinationDal.GetLastFourDestination();
        }

        public void TAdd(Desnination entity)
        {
            _destinationDal.add(entity);
        }

        public Desnination TGetById(int id)
        {
            return _destinationDal.getById(id);
        }

        public void TRemove(Desnination entity)
        {
           _destinationDal.delete(entity);
        }

        public void TUpdate(Desnination entity)
        {
           _destinationDal.update(entity);
        }
    }
}
