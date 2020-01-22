using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GestaoDeBlog.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> List(Expression<Func<T, bool>> expression);
    }
}
