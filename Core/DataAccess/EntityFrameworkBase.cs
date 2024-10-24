using Microsoft.EntityFrameworkCore;
using RannaProductProject.Core.Entity;
using System.Linq.Expressions;
using System.Security.Principal;

namespace RannaProductProject.Core.DataAccess
{
    public class EntityFrameworkBase<TEntity, TContext>
            where TEntity : class, IEntity, new()
            where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EntityFrameworkBase(TContext context)
        {
            _context = context;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }
        public void Add(TEntity entity)
        {
            var addedContext = _context.Entry(entity);
            addedContext.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(int id, TEntity updatedEntity) 
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Entity with id {id} not found.");
            }
        }
        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                var deletedContext = _context.Entry(entity);
                deletedContext.State = EntityState.Deleted;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Entity with id {id} not found.");
            }
        }
    }
}

