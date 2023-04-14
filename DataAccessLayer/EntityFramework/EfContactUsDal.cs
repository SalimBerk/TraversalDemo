using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangetoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactByFalse()
        {
            using var c = new Context();
            return c.ContactUses.Where(x=>x.MessageStatus==false).ToList();
            
        }

        public List<ContactUs> GetListContactByTrue()
        {
            using var c = new Context();
            return c.ContactUses.Where(x => x.MessageStatus == true).ToList();
        }
    }
}
