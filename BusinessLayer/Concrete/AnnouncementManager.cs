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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.getAll();
        }

        public void TAdd(Announcement entity)
        {
            _announcementDal.add(entity);   
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.getById(id);
        }

        public void TRemove(Announcement entity)
        {
            _announcementDal.delete(entity);
        }

        public void TUpdate(Announcement entity)
        {
            _announcementDal.update(entity);
        }
    }
}
