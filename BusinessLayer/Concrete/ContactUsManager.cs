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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public List<ContactUs> GetAll()
        {
            return _contactUsDal.getAll();
          
        }

        public void TAdd(ContactUs entity)
        {
            _contactUsDal.add(entity);
        }

        public void TContactUsStatusChangetoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactByFalse()
        {
            return _contactUsDal.GetListContactByFalse();
        }

        public List<ContactUs> TGetListContactByTrue()
        {
           return _contactUsDal.GetListContactByTrue();
        }

        public void TRemove(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}
