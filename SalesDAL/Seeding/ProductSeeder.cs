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
    public class ProductSeeder : ISeeder<Product>
    {
        public void Seed(EntityTypeBuilder<Product> builder)
        {
            var id = 1;

            var faker = new Faker<Product>()
                .RuleFor(e => e.ProductId, f => id++)
                .RuleFor(e => e.Name, f => f.Commerce.ProductName())
                .RuleFor(e => e.Quantity, f => f.Random.Number(1, 10))
                .RuleFor(e => e.Price, f => f.Random.Number(100, 3000));

            var p = faker.Generate(10);
            builder.HasData(p);
        }
    }
}
