using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);

        IQueryable<T> GetAll();

        T Get(int d);
    }
}
