using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class BaseRepository<T> : IDisposable where T : class
    {
        public Context Ct = new Context();

        public T GetById(int id)
        {
            return Ct.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Ct.Set<T>().ToList();
        }
        
        public void Add(T obj)
        {
            Ct.Set<T>().Add(obj);
            Ct.SaveChanges();
        }

        public void Update(T obj)
        {
            Ct.Entry(obj).State = EntityState.Modified;
            Ct.SaveChanges();
        }

        public void Remove(T obj)
        {
            Ct.Set<T>().Remove(obj);
            Ct.SaveChanges();
        }

        public void Dispose()
        {
            Ct.Dispose();
        }
    }
}
