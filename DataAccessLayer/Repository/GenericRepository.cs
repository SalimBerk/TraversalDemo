using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void add(T entity)
        {
            using var c=new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void delete(T entity)
        {
            using var c=new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> getAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T getById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
