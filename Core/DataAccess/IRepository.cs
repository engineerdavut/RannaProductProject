using System.Linq.Expressions;
using System.Security.Principal;
using RannaProductProject.Core.Entity;

namespace RannaProductProject.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(int id,T entity);
        void Delete(int id);

    }
}
