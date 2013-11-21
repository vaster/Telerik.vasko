using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Repositoy
{
    public class EFRepo<T>
      where T : class
    {
        private DbContext context;
        private DbSet<T> set;

        public EFRepo(DbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.set;
        }
    }
}
