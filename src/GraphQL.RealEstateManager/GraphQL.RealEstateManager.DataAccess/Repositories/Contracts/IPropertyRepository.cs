using GraphQL.RealEstateManager.Database.Models;

namespace GraphQL.RealEstateManager.DataAccess.Repositories.Contracts
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
        Property? GetById(int id);
        Property Add(Property property);
    }
}
