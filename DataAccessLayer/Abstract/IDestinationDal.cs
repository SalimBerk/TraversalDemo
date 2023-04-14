using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Desnination>
    {
        Desnination GetDestinationWithGuide(int id);
        public List<Desnination> GetLastFourDestination();
    }
}
