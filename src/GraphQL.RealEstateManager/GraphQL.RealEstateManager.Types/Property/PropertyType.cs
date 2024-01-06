using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.Types.Payment;
using GraphQL.Types;

namespace GraphQL.RealEstateManager.Types.Property
{
    public class PropertyType : ObjectGraphType<Database.Models.Property>
    {
        public PropertyType(IPaymentRepository paymentRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Value);
            Field(x => x.City);
            Field(x => x.Family);
            Field(x => x.Street);
            Field<ListGraphType<PaymentType>>("payments")
                .Arguments(new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "last", Description = "Limits the number of payments returned" }
                ))//ii spune lui GraphQL ca acest argument "last" cu numele specificat aici va fi folosit in query pt proprietatea "payments"
                .Resolve(context =>
                {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return lastItemsFilter != null
                        ? paymentRepository.GetAllForProperty(context.Source.Id, lastItemsFilter.Value)
                        : paymentRepository.GetAllForProperty(context.Source.Id);
                });
        }
    }
}
