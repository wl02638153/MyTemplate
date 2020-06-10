using Microsoft.EntityFrameworkCore;
using MyTemplate.DAL;
using MyTemplate.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplate.BLL.Service.EntityRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);

        Task Update(T entity);

        Task Delete(long id);

        Task<T> GetById(long id);
        Task<List<T>> Find(Expression<Func<T, bool>> expression, int page, int size);
        Task<List<T>> GetAll();
        Task<List<T>> GetPagin(int page, int size);
        Task<int> GetCount();

        //Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
    }
    
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyTemplateDbContext _context;

        public Repository(MyTemplateDbContext context)
        {
            _context = context;
        }
        public async Task<T> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(long id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> Find(Expression<Func<T, bool>> expression)
        {
           return  await _context.Set<T>().Where(expression).AsNoTracking().ToListAsync<T>();
        }
        public async Task<List<T>> Find(Expression<Func<T, bool>> expression,int page, int size)
        {
            return await _context.Set<T>().Where(expression).Skip((page-1)*size).Take(size).AsNoTracking().ToListAsync<T>();
        }
        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync<T>();
        }
        public async Task<List<T>> GetPagin(int page, int size)
        {
            return await _context.Set<T>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync<T>();
        }
        public async Task<int> GetCount()
        {
            return await _context.Set<T>().AsNoTracking().CountAsync();
        }
        public async Task<T> GetById(long id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
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
