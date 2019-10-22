using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using blogapi.DomainModels;

namespace blogapi.Abstractions
{
  public interface ISpecification<T> where T : BaseEntity
  {
    List<Expression<Func<T, bool>>> Predicates { get; set; }

    List<Expression<Func<T, object>>> OrderBy { get; set; }

    List<Expression<Func<T, object>>> ThenBy { get; set; }

    public int PageSize { get; set; }

    public int PageNumber { get; set; }

    public int Skip { get; set; }

    public int Take { get; set; }
  }
}