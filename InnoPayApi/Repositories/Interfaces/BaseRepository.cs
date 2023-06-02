using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InnoPayApi.Models;
using System.Linq.Expressions;

namespace InnoPayApi.Repositories.Interfaces
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected  ArasContext _context { get; set; }

        public BaseRepository(ArasContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll() => _context.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
