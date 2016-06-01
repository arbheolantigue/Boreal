using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BorealPersistence
{
    public interface IRepository<TEntity, in TKey>
        where TEntity:class
    {
        List<TEntity> GetAllBy(Expression<Func<TEntity, bool>> expression);
        List<TEntity> GetAllByUntracked(Expression<Func<TEntity, bool>> expression);
        TEntity GetSpecificBy(Expression<Func<TEntity, bool>> expression);
        TEntity GetByKey(TKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity,Expression<Func<TEntity,object>> expression);
        void Delete(TEntity entity);
        void SaveChanges();
    }
}
