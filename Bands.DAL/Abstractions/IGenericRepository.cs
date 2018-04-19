using System;
using System.Collections.Generic;

namespace Bands.DAL.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
}
