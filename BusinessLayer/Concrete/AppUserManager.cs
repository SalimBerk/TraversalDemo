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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.getAll();
        }

        public void TAdd(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
