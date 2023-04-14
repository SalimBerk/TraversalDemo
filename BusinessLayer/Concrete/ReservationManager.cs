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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.getAll();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public List<Reservation> GetListWithReservtionByAccepted(int id)
        {
            return _reservationDal.GetListWithReservtionByAccepted(id);
        }

        public List<Reservation> GetListWithReservtionByPrevious(int id)
        {
            return _reservationDal.GetListWithReservtionByPrevious(id);
        }

        public void TAdd(Reservation entity)
        {
            _reservationDal.add(entity);    
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
