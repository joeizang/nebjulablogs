using GraphQL.Types;

namespace blogapi.GraphQL.GraphQLSchema
{
  public class AppSchema : Schema
  {
    public AppSchema(IDependencyResolver resolver) : base(resolver)
    {

    }
  }
}