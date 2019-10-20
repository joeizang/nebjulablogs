using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using blogapi.DomainModels;

namespace blogapi.Abstractions
{
  public interface IDataService<T> where T : BaseEntity
  {
    IQueryable<T> GetAll();

    T GetBy(params Expression<Func<T, object>>[] cond);

    void Add(T entity);

    T Update(T entity);

    void Delete(T entity);
  }
}