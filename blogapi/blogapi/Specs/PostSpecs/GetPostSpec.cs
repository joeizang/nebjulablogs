using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using blogapi.Abstractions;
using blogapi.DomainModels;

namespace blogapi.Specs.PostSpecs
{
  public class GetPostSpec : ISpecification<Post>
  {
    private GetPostSpec()
    {

    }
    public List<Expression<Func<Post, bool>>> Predicates { get; set; }
    public List<Expression<Func<Post, object>>> OrderBy { get; set; }
    public List<Expression<Func<Post, object>>> ThenBy { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int Skip { get; set; }
    public int Take { get; set; }

    public class GetPostSpecFactory
    {
      /// <summary>
      /// Creates an Instance of GetPostSpec in a Valid state.
      /// Call this method Last!!!
      /// </summary>
      /// <returns>GetPostSpec</returns>
      public static GetPostSpec CreateSpecs()
      {
        var spec = new GetPostSpec();

        return spec;
      }

      /// <summary>
      /// Pass in as many predicates as parameters to the method and it takes care of the rest
      /// </summary>
      /// <param name="Expression<Func<Post"></param>
      /// <param name="conditions">predicates</param>
      public static void ForgePredicates(params Expression<Func<Post, bool>>[] conditions)
      {
        var finalconditions = new List<Expression<Func<Post, bool>>>();

        foreach (var c in conditions)
        {
          finalconditions.Add(c);
        }
        CreateSpecs().Predicates.AddRange(finalconditions);
      }

      public static void ArrangeOrderBys(params Expression<Func<Post, object>>[] sortings)
      {
        var sorts = new List<Expression<Func<Post, object>>>();

        foreach (var s in sortings)
        {
          sorts.Add(s);
        }
        CreateSpecs().OrderBy.AddRange(sorts);
      }
    }
  }
}