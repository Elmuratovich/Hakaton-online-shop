using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project.Models.Services
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
        Task<T> SelectOne (int id);
        Task<T> Find(Expression<Func<T, bool>> filter);
        Task<IList<T>> FindAll(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetAll();
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _applicationContext;
        public GenericRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<int> Delete(T entity)
        {
            _applicationContext.Set<T>().Remove(entity);
            return await _applicationContext.SaveChangesAsync();
        }

        public async Task<T> Find(Expression<Func<T, bool>> filter)
        {
            return await _applicationContext.Set<T>().Where(filter).FirstOrDefaultAsync(filter);
        }

        public async Task<IList<T>> FindAll(Expression<Func<T, bool>> filter)
        {
            return await _applicationContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<IList<T>> GetAll()
        {
            return await _applicationContext.Set<T>().ToListAsync();
        }

        public async Task<T> Insert(T entity)
        {
            var u = await _applicationContext.Set<T>().AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
            return u.Entity;
        }

        public async Task<T> SelectOne(int id)
        {
            return await _applicationContext.Set<T>().FindAsync(id);
        }

        public async Task<int> Update(T entity)
        {
            _applicationContext.Set<T>().Update(entity);
            return await _applicationContext.SaveChangesAsync();
        }
    }
}
