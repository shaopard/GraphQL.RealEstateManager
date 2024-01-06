using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.DataAccess.Repositories;
using GraphQL.Types;
using GraphQL.RealEstateManager.Schema;
using GraphQL.RealEstateManager.Queries;
using GraphQL.RealEstateManager.Types.Payment;
using GraphQL.RealEstateManager.Types.Property;
using GraphQL.RealEstateManager.Mutations;

namespace GraphQL.RealEstateManager.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDITypes(this IServiceCollection services)
        {
            services.AddSingleton<IPaymentRepository, PaymentRepository>()
                .AddSingleton<IPropertyRepository, PropertyRepository>()
                .AddGraphQLTypes();

            return services;
        }

        private static IServiceCollection AddGraphQLTypes(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>()
                .AddSingleton<PropertyQuery>()
                .AddSingleton<PropertyMutation>()
                .AddSingleton<PropertyType>()
                .AddSingleton<PropertyInputType>()
                .AddSingleton<PaymentType>()
                .AddSingleton<ISchema, RealEstateSchema>();

            return services;
        }
    }
}
