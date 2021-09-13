using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CRUD.Core.Interfaces
{
    public interface IBaseRepo<T> where T:class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> criteria);
        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        T Update(T entity);
        void Delete(T entity);
        void Attach(T entity);
        int Count();
        int Count(Expression<Func<T, bool>> criteria);
    }
}
