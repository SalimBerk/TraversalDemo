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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetAll()
        {
            return _guideDal.getAll();
        }

        public void TAdd(Guide entity)
        {
            _guideDal.add(entity);  
        }

        public Guide TGetById(int id)
        {
            return _guideDal.getById(id);
        }

        public void TRemove(Guide entity)
        {
           _guideDal.delete(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.update(entity);
        }
    }
}
