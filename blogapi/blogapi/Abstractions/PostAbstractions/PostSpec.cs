using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using blogapi.DomainModels;

namespace blogapi.Abstractions.PostAbstractions
{
  public class PostSpec : ISpecification<Post>
  {
    public List<Expression<Func<Post, bool>>> Predicates { get; set; }
    public List<Expression<Func<Post, object>>> OrderBy { get; set; }
    public List<Expression<Func<Post, object>>> ThenBy { get; set; }
  }
}