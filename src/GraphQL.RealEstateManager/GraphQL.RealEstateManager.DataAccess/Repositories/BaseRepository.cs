using GraphQL.RealEstateManager.Database.Models;

namespace GraphQL.RealEstateManager.DataAccess.Repositories
{
    public class BaseRepository
    {
        internal List<Property> Properties { get; set; }
        internal List<Payment> Payments { get; set; }

        public BaseRepository()
        {
            Properties ??= new List<Property>();
            Payments ??= new List<Payment>();

            if (!Payments.Any())
            {
                var payments = new List<Payment>
                            {
                                new Payment
                                {
                                    Id = 1,
                                    DateCreated = new DateTime(2019, 07, 01),
                                    DateOverdue = new DateTime(2019, 07, 15),
                                    Paid = true,
                                    Value = 1500,
                                    PropertyId = 1,
                                },
                                new Payment
                                {
                                    Id = 2,
                                    DateCreated = new DateTime(2019, 08, 01),
                                    DateOverdue = new DateTime(2019, 08, 15),
                                    Paid = true,
                                    Value = 1500,
                                    PropertyId = 1,
                                },
                                new Payment
                                {
                                    Id = 3,
                                    DateCreated = new DateTime(2019, 09, 01),
                                    DateOverdue = new DateTime(2019, 09, 15),
                                    Paid = false,
                                    Value = 1500,
                                    PropertyId = 1,
                                },
                                new Payment
                                {
                                    Id = 4,
                                    DateCreated = new DateTime(2019, 07, 01),
                                    DateOverdue = new DateTime(2019, 07, 15),
                                    Paid = true,
                                    Value = 3000,
                                    PropertyId = 2,
                                },
                                new Payment
                                {
                                    Id = 5,
                                    DateCreated = new DateTime(2019, 08, 01),
                                    DateOverdue = new DateTime(2019, 08, 15),
                                    Paid = true,
                                    Value = 3000,
                                    PropertyId = 2,
                                },
                                new Payment
                                {
                                    Id = 6,
                                    DateCreated = new DateTime(2019, 09, 01),
                                    DateOverdue = new DateTime(2019, 09, 15),
                                    Paid = false,
                                    Value = 3000,
                                    PropertyId = 2,
                                },
                                new Payment
                                {
                                    Id = 7,
                                    DateCreated = new DateTime(2019, 07, 01),
                                    DateOverdue = new DateTime(2019, 07, 15),
                                    Paid = true,
                                    Value = 800,
                                    PropertyId = 3,
                                },
                                new Payment
                                {
                                    Id = 8,
                                    DateCreated = new DateTime(2019, 08, 01),
                                    DateOverdue = new DateTime(2019, 08, 15),
                                    Paid = true,
                                    Value = 800,
                                    PropertyId = 3,
                                },
                                new Payment
                                {
                                    Id = 9,
                                    DateCreated = new DateTime(2019, 09, 01),
                                    DateOverdue = new DateTime(2019, 09, 15),
                                    Paid = true,
                                    Value = 800,
                                    PropertyId = 3,
                                }
                            };

                Payments.AddRange(payments);
            }

            if (!Properties.Any())
            {
                var properties = new List<Property>
                    {
                        new Property
                        {
                            Id = 1,
                            City = "Katowice",
                            Family = "Smith",
                            Name = "Big house",
                            Street = "Sokolska",
                            Value = 100000,
                            Payments = Payments.Where(payment => payment.PropertyId == 1).ToList()
                        },
                        new Property
                        {
                            Id = 2,
                            City = "Warszawa",
                            Family = "Nowak",
                            Name = "White house",
                            Street = "Wiejska",
                            Value = 300500,
                            Payments = Payments.Where(payment => payment.PropertyId == 2).ToList()
                        },
                        new Property
                        {
                            Id = 3,
                            City = "Gdańska",
                            Family = "Pomorscy",
                            Name = "Sea house",
                            Street = "Gdańska",
                            Value = 51000,
                            Payments = Payments.Where(payment => payment.PropertyId == 3).ToList()
                        }
                    };

                Properties.AddRange(properties);
            }
        }
    }
}
