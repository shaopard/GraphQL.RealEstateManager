using GraphQL.RealEstateManager.Mutations;
using GraphQL.RealEstateManager.Queries;

namespace GraphQL.RealEstateManager.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<PropertyQuery>();
            Mutation = provider.GetRequiredService<PropertyMutation>();
        }
    }
}
