using blogapi.DomainModels;
using GraphQL.Types;

namespace blogapi.GraphQL.GraphQLTypes
{
  public class CommentType : ObjectGraphType<Comment>
  {
    public CommentType()
    {
      Field(c => c.Id, type: typeof(IdGraphType)).Description("Id property from every comment");
      Field(c => c.CommentAuthor).Description("Author of every comment");
    }
  }
}