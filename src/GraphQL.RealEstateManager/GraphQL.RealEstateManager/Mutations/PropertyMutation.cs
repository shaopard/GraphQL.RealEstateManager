using GraphQL.RealEstateManager.DataAccess.Repositories;
using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.Database.Models;
using GraphQL.RealEstateManager.Types.Property;
using GraphQL.Types;

namespace GraphQL.RealEstateManager.Mutations
{
    public class PropertyMutation : ObjectGraphType
    {
        public PropertyMutation(IPropertyRepository propertyRepository)
        {
            Field<PropertyType>("addProperty")
                .Arguments(new QueryArguments(
                    new QueryArgument<NonNullGraphType<PropertyInputType>> { Name = "property" }
                ))
                .Resolve(context =>
                {
                    var property = context.GetArgument<Property>("property");
                    return propertyRepository.Add(property);
                });
        }
    }
}
