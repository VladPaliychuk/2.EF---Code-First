using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDAL.Data.Entities;
using SalesDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDAL.Seeding
{
    public class CustomerSeeder : ISeeder<Customer>
    {
        public void Seed(EntityTypeBuilder<Customer> builder)
        {
            var id = 1;

            var faker = new Faker<Customer>()
                .RuleFor(e => e.CustomerId, f => id++)
                .RuleFor(e => e.Name, f => f.Name.FirstName())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.CreditCardNumber, f => f.Finance.CreditCardNumber());

            var c = faker.Generate(10);
            builder.HasData(c);
        }
    }
}
