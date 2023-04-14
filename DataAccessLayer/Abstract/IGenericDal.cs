using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void add(T entity); 
        void update(T entity);
        void delete(T entity);
        List<T> getAll();
        T getById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
