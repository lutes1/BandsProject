using System;
using System.Collections.Generic;
using System.Linq;
using Bands.DAL.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL.Repositories
{
    public class DatabaseRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext DbContext;
        public DatabaseRepository(ApplicationDbContext context)
        {
            DbContext = context;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().ToList();
        }
        public virtual IEnumerable<T> FindBy(Func<T, bool> predicate)
        {
            return DbContext.Set<T>().Where(predicate).ToList();
        }
        public void Add(T entity)
        {
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

        public void Update(T entity)
        {
            DbContext.Set<T>().Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}