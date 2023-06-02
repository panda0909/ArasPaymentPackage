using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using InnoPayApi.Models;

namespace InnoPayApi.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
