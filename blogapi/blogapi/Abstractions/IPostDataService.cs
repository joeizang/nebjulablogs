using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using blogapi.ApiModels;
using blogapi.DomainModels;

namespace blogapi.Abstractions
{
  public interface IPostDataService : IDataService<Post>
  {
    Task<IEnumerable<PostApiModel>> GetAllPost(Expression<Func<Post, object>> search);
  }
}