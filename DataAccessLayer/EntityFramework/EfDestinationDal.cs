using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Desnination>, IDestinationDal
    {
        public Desnination GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Desninations.Where(x => x.DesninationId == id).Include(x => x.Guide).FirstOrDefault();

            }
        }

        public List<Desnination> GetLastFourDestination()
        {
            using (var c = new Context())
            {
                var values= c.Desninations.Take(4).OrderByDescending(p => p.DesninationId).ToList();
                return values;

            }
        }
    }
}
