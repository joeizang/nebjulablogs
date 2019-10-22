using System;
using System.Linq;
using System.Linq.Expressions;
using blogapi.Abstractions;
using blogapi.Context;
using blogapi.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace blogapi.Services
{
  public class DataService<T> : IDataService<T> where T : BaseEntity
  {
    private readonly BlogApiContext _ctx;

    public DataService(BlogApiContext ctx)
    {
      _ctx = ctx;
    }

    public BlogApiContext Context
    {
      get
      {
        return _ctx;
      }
    }

    /// <summary>
    /// Add an entity generally
    /// </summary>
    /// <param name="entity"></param>
    public void Add(T entity)
    {
      _ctx.Set<T>().Add(entity);
    }

    /// <summary>
    /// Perform soft delete of any entity
    /// </summary>
    /// <param name="entity"></param>
    public void Delete(T entity)
    {
      // TODO: implement soft delete of entities

    }

    public IQueryable<T> GetAll()
    {
      return _ctx.Set<T>();
    }

    public T GetBy(params Expression<Func<T, object>>[] cond)
    {
      T entity = null;
      if (!cond.Any())
        GetAll();
      foreach (var c in cond)
      {
        var booleanCondition = c as Func<T, bool>;
        if (booleanCondition != null)
          entity = _ctx.Set<T>().AsNoTracking().Where(booleanCondition).SingleOrDefault();
        else
          entity = _ctx.Set<T>().AsNoTracking().OrderBy(c).ThenBy(c).SingleOrDefault();
      }
      return entity;
    }

    public T Update(T entity)
    {
      _ctx.Set<T>().Update(entity);
      return _ctx.Set<T>().AsNoTracking().SingleOrDefault(t => t.Id == entity.Id);
    }
  }
}