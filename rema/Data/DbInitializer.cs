using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using rema.Models;

namespace rema.Data
{
    public class DbInitializer
    {
        internal static void Initialize(remaContext context)
        {
            //if (context.Product.Any())
            //{
            //    return;
            //}

            Randomizer.Seed = new Random(1234);

            var productNames = new[] { "Kims Sour Cream & Onion", "Kims Snack chips", "Arla letmælk", "Coca cola" };
            var productDescriptions = new[] { "Skal opbevares i køleskab", "Kan også bruges som gift mod naboens kat", "Allann please add details", "IKKE FOR BØRN", "Hahaha", "pls" };

            var categoryIds = 0;
            var categories = new Faker<Category>()
                .RuleFor(o => o.CategoryID, c => categoryIds++)
                .RuleFor(o => o.Names, c => c.Lorem.Word())
                .RuleFor(o => o.Description, c => c.Lorem.Paragraph());

            var supplierIds = 0;
            var suppliers = new Faker<Supplier>()
                .RuleFor(o => o.SupplierID, s => supplierIds++)
                .RuleFor(o => o.Name, s => s.Lorem.Word())
                .RuleFor(o => o.Address, s => s.Address.FullAddress())
                .RuleFor(o => o.Zip, s => s.Address.ZipCode())
                .RuleFor(o => o.ContactPerson, s => s.Person.FullName)
                .RuleFor(o => o.Email, s => s.Person.Email)
                .RuleFor(o => o.PhoneNumber, s => s.Person.Phone);

            var productIds = 0;
            var products = new Faker<Product>()
                .RuleFor(o => o.ProductID, p => productIds++)
                .RuleFor(o => o.Name, p => p.PickRandom(productNames))
                .RuleFor(o => o.Description, p => p.PickRandom(productDescriptions))
                .RuleFor(o => o.Units, p => p.Random.Double(500, 10000))
                .RuleFor(o => o.Stock, p => p.Random.Int(1, 20))
                .RuleFor(o => o.Price, p => p.Random.Double(4.5, 199.99))
                .RuleFor(o => o.Category, p => categories.Generate(1).First())
                .RuleFor(o => o.Supplier, p => suppliers.Generate(1).First());

            // var product = products.Generate(5);

            //context.AddRange(categories.Generate(5));
            //context.AddRange(suppliers.Generate(5));
            context.AddRange(products.Generate(5));

            context.SaveChanges();
        }
    }
}

