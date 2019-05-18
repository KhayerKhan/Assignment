using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Final.Repository
{
   public interface IRepository <T>
    {
        void Add(T entity);

        void Remove(object id);

        void Remove(T entityToDelete);

        void Remove(Expression<Func<T, bool>> filter);

        void Edit(T entityToUpdate);

        int GetCount(Expression<Func<T, bool>> filter = null);

        IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
    }
}
