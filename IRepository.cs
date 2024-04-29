using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst
{
    public interface IRepository<T> : IQueryable<T>
    {
        void Add(T entity);
        T Get(int id);
        void Remove(T entity);
    }
}
