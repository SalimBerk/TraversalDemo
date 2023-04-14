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
    public class SubAboutManager : ISubAboutService
    {
        ISubAbout _subAbout;

        public SubAboutManager(ISubAbout subAbout)
        {
            _subAbout = subAbout;
        }

        public List<SubAbout> GetAll()
        {
            return _subAbout.getAll();
        }

        public void TAdd(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
