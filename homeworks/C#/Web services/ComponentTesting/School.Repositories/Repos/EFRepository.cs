using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class EFRepository<T> : IRepository<T>
        where T : class
    {

        private DbContext dbContext = null;
        private DbSet<T> Set = null;

        public EFRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Set = this.dbContext.Set<T>();
        }

        public void Add(T item)
        {
            this.Set.Add(item);
            this.dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return this.Set;
        }

        public T Get(int id)
        {
            return this.Set.Find(id);
        }
    }
}
