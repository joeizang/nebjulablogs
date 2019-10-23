using System.Linq;
using blogapi.Abstractions.PostAbstractions;
using blogapi.DomainModels;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace blogapi.GraphQL.GraphQLTypes
{
  public class PostType : ObjectGraphType<Post>
  {
    public PostType(IPostDataService service)
    {
      Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property for every post");
      Field(x => x.Title).Description("Title property from the post object");
      Field(x => x.CreatedAt, type: typeof(DateTimeOffsetGraphType)).Description("CreatedAt property from the post object");
      Field<ListGraphType<CommentType>>(
          "comments",
          resolve: context => service.GetAll().Include(p => p.Comments)
                                              .Include(p => p.Author)
                                              .Include(p => p.Assets)
                                              .ToList()
      );
    }
  }
}