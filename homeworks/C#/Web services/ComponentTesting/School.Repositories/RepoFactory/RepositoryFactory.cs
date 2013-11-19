using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories.RepoFactory
{
    public class RepositoryFactory
    {
        public static IRepository<T> Create<T, TRepository>(DbContext context)
            where TRepository : IRepository<T>
        {
            return (TRepository)Activator.CreateInstance(typeof(TRepository), context);
        }
    }
}
