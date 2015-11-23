using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Interfaces
{
    public interface Repository<T>
    {
        void Add(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        T Update(T entity);
        void Delete(T entity);
    }
}
