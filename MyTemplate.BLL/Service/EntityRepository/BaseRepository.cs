using MyTemplate.DAL;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplate.BLL.Service.EntityRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Create(T entity);

        Task Update(T entity);

        Task Delete(string id);

        Task<T> GetById(string id);

        //Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
    }
    
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MyTemplateDbContext _context;

        public BaseRepository(MyTemplateDbContext context)
        {
            _context = context;
        }
        public async Task<T> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetById(string id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        //Task<TKey> IBaseRepository<T, TKey>.Create(T entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
