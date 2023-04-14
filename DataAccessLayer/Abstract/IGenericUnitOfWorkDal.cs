using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUnitOfWorkDal<T> where T : class
    {
        void add(T entity);
        void multiupdate(List<T> t);
        void update(T entity);  
        void delete(T entity);
        T GetById(int id);  
    }
}
