using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    interface IRepositoryFactory
    {
        IRepository<T> Create<T>(DbContext context);
    }
}
