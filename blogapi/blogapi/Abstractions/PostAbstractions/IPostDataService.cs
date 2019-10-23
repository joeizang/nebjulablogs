using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using blogapi.ApiModels;
using blogapi.DomainModels;
using blogapi.Specs.PostSpecs;
using static blogapi.Specs.PostSpecs.GetPostSpec;

namespace blogapi.Abstractions.PostAbstractions
{
  public interface IPostDataService : IDataService<Post>
  {
    Task<IList<Post>> GetAllPost();

    Task<IList<Post>> GetFilteredPost(GetPostSpec type);
  }
}