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

    public Task<IList<Post>> GetFilteredPost(GetPostSpec spec)
    {
      GetPostSpecFactory.ForgePredicates(x => x.Author.AuthorName == "somename",
                                      x => x.Assets.SingleOrDefault(y => y.AssetPath.Contains("deleAli")).AssetPath != "harrykane");
      var specs = GetPostSpecFactory.CreateSpecs();

      specs.Predicates.ForEach(p =>
      {
        Context.Posts.AsNoTracking().Where(p);
      });
    }
  }
}