using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.Database;
using GraphQL.RealEstateManager.Database.Models;

namespace GraphQL.RealEstateManager.DataAccess.Repositories
{
    public class PropertyRepository : BaseRepository, IPropertyRepository
    {
        public PropertyRepository()
        {
            
        }

        public IEnumerable<Property> GetAll()
        {
            return Properties;
        }

        public Property? GetById(int id)
        {
            return Properties.SingleOrDefault(x => x.Id == id);
        }

        public Property Add(Property property)
        {
            Properties.Add(property);
            //_db.SaveChanges();
            return property;
        }
    }
}
