using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CFSDDD.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(object id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T x);
        void Add(IEnumerable<T> x);
        void Remove(T x);
        void Remove(IEnumerable<T> x);
    }
}
