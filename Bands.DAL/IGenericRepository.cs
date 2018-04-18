using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
    public class DatabaseRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext DbContext;
        public DatabaseRepository(DbContext context)
        {
            DbContext = context;
        }
        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>();
        }
        public IEnumerable<T> FindBy(Func<T, bool> predicate)
        {
            return DbContext.Set<T>().Where(predicate);
        }
        public void Add(T entity)
        {
            if (DbContext.Set<T>().Contains(entity))
            {
                throw new ArgumentException($"Cannot add entity that already exists in the DataBase");
            }
            DbContext.Set<T>().Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (!DbContext.Set<T>().Contains(entity))
            {
                throw new ArgumentException($"Cannot remove unnexisting enity from DataBase");
            }
            DbContext.Set<T>().Remove(entity);
            DbContext.SaveChanges();
        }
    }
}
