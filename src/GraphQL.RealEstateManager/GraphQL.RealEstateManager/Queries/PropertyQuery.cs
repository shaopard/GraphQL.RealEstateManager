using GraphQL.RealEstateManager.DataAccess.Repositories;
using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.Types.Payment;
using GraphQL.RealEstateManager.Types.Property;
using GraphQL.Types;

namespace GraphQL.RealEstateManager.Queries
{
    public class PropertyQuery : ObjectGraphType
    {
        public PropertyQuery(IPropertyRepository propertyRepository, IPaymentRepository paymentRepository)
        {
            Field<ListGraphType<PropertyType>>("properties")  // when this property is asked for
                .Resolve(context => propertyRepository.GetAll());   // this method is used for retrieving it
        }
    }
}
