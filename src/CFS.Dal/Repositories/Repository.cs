using CFSDDD.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CFSDDD.Dal
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DbSet<T> t;
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
            t = Context.Set<T>();
        }

        public virtual void Add(T obj)
        {
            t.Add(obj);
        }

        public virtual void Add(IEnumerable<T> objs)
        {
            t.AddRange(objs);
        }

        public virtual void Remove(T obj)
        {
            var entry = Context.Entry(obj);
            t.Attach(obj);            
            entry.State = EntityState.Deleted;
        }

        public virtual void Remove(IEnumerable<T> objs)
        {
            var total = objs.Count();
            for (int i = 0; i < total; i++)
            {
                Remove(objs.ElementAt(i));
            }
        }

        public T Get(object id)
        {
            return t.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return t.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return t.Where(predicate);
        }
    }
}
