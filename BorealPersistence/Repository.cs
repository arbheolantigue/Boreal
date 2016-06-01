using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BorealPersistence
{
    public class Repository<TEntity, TKey>:IRepository<TEntity, TKey>   where TEntity:class     
    {
        private readonly BorealContext _context;

        public Repository()
        {
            _context = new BorealContext();
        }
        public List<TEntity> GetAllBy(Expression<Func<TEntity, bool>> expression)
        {
            var result = _context.Set<TEntity>().Where(expression);
            return result.ToList();
        }

        public List<TEntity> GetAllByUntracked(Expression<Func<TEntity, bool>> expression)
        {
            var result = _context.Set<TEntity>().AsNoTracking().Where(expression);
            return result.ToList();
        }

        public TEntity GetSpecificBy(Expression<Func<TEntity, bool>> expression)
        {
            TEntity result = null;
            var @select = _context.Set<TEntity>().FirstOrDefault(expression);
            result = @select;
            return result;
        }

        public TEntity GetByKey(TKey key)
        {
            var result = _context.Set<TEntity>().Find(key);
            return result;
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity, Expression<Func<TEntity, object>> expression)
        {
            _context.Set<TEntity>().AddOrUpdate(expression, entity);
        }


        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
