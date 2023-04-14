﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservtionByAccepted(int id);
        List<Reservation> GetListWithReservtionByPrevious(int id);
    }
}
