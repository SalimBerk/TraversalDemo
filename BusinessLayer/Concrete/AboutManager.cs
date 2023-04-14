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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public List<About> GetAll()
        {
            return _aboutDal.getAll();
        }

        public void TAdd(About entity)
        {
            _aboutDal.add(entity);
        }

        public About TGetById(int id)
        {
           return _aboutDal.getById(id);
        }

        public void TRemove(About entity)
        {
            _aboutDal.delete(entity);   
        }

        public void TUpdate(About entity)
        {
            _aboutDal.update(entity);
        }
    }
}
