using BusinessLayer.Abstract.UnitOfWorkService;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UowManager
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal= unitOfWorkDal;
        }

        public void add(Account entity)
        {
            _accountDal.add(entity);
            _unitOfWorkDal.Save();
        }

        public void delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
           return _accountDal.GetById(id);

        }

        public void multiupdate(List<Account> t)
        {
            _accountDal.multiupdate(t);
            _unitOfWorkDal.Save();
        }

        public void update(Account entity)
        {
            _accountDal.update(entity);
            _unitOfWorkDal.Save();
        }
    }
}
