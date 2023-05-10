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
    public class SaleSeeder : ISeeder<Sale>
    {
        public void Seed(EntityTypeBuilder<Sale> builder)
        {
            var id = 1;

            var faker = new Faker<Sale>()
                .RuleFor(e => e.SaleId, f => id++)
                .RuleFor(e => e.Date, f => f.Date.Past())
                .RuleFor(e => e.CustomerId, f => f.Random.Number(1, 10))
                .RuleFor(e => e.ProductId, f => f.Random.Number(1, 10))
                .RuleFor(e => e.StoreId, f => f.Random.Number(1, 10));

            var s = faker.Generate(10);
            builder.HasData(s);
        }
    }
}
