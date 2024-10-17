using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using var db = new Context(); 
            db.Remove(item);
            db.SaveChanges();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var db = new Context(); 
            return db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var db = new Context(); 
            return db.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var db = new Context(); 
            db.Add(item);
            db.SaveChanges();
        }

        public void Update(T item)
        {
            using var db = new Context(); 
            db.Update(item);
            db.SaveChanges();
        }
    }
}
