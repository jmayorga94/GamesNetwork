using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GamesNetwork.Domain.Commons
{
    public interface IGenericRepository<TEntity> 
    {
        IEnumerable<TEntity> FindAll();
        TEntity FindById(int id);
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
