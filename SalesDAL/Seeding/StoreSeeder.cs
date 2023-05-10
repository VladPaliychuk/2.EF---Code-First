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
    public class StoreSeeder : ISeeder<Store>
    {
        public void Seed(EntityTypeBuilder<Store> builder)
        {
            var id = 1;

            var faker = new Faker<Store>()
                .RuleFor(e => e.StoreId, f => id++)
                .RuleFor(e => e.Name, f => f.Company.CompanyName());

            var st = faker.Generate(10);
            builder.HasData(st);
        }
    }
}
