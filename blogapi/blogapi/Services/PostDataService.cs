using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogapi.Abstractions.PostAbstractions;
using blogapi.Context;
using blogapi.DomainModels;
using blogapi.Specs.PostSpecs;
using Microsoft.EntityFrameworkCore;
using static blogapi.Specs.PostSpecs.GetPostSpec;

namespace blogapi.Services
{
  public class PostDataService : DataService<Post>, IPostDataService
  {
    public PostDataService(BlogApiContext ctx) : base(ctx)
    {
    }

    public async Task<IList<Post>> GetAllPost()
    {
      var result = await GetAll().AsNoTracking().OrderBy(p => p.CreatedAt).ToListAsync().ConfigureAwait(false);
      return result;
    }

    public async Task<IList<Post>> GetFilteredPost(GetPostSpec spec)
    {
      var specs = GetPostSpecFactory.CreateSpecs();
      var postsDelayed = Context.Posts.AsNoTracking();

      specs.Predicates.ForEach(p =>
      {
        postsDelayed.Where(p);
      });

      specs.OrderBy.ForEach(o =>
      {
        specs.ThenBy.ForEach(t =>
        {
          var order = postsDelayed.OrderBy(o);
          order.ThenBy(t);
        });
      });
      return await postsDelayed.ToListAsync();
    }
  }
}