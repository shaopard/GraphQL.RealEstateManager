using GraphQL.RealEstateManager.DataAccess.Repositories.Contracts;
using GraphQL.RealEstateManager.Database.Models;

namespace GraphQL.RealEstateManager.DataAccess.Repositories
{
    public class PaymentRepository : BaseRepository, IPaymentRepository
    {
        public PaymentRepository()// : base()
        {
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId)
        {
            return Payments.Where(x => x.PropertyId == propertyId);
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount)
        {
            var payments = Payments;
            var paymentsForProperty = payments.Where(x => x.PropertyId == propertyId);
            return paymentsForProperty
                .OrderByDescending(x => x.DateCreated)
                .Take(lastAmount);
        }
    }
}
