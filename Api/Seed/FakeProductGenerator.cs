using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Bogus;

namespace Api.Seed
{
    public static class FakeProductGenerator
    {
        public static List<Product> GenerateProductList(int count = 100)
        {
            var categories = new[] {"Категория 1", "Категория 2", "Категория 3",};
            var specialTags = new[] {"Новинка", "Популярный", "Рекомендуемый",};
            return new Faker<Product>("ru")
                .RuleFor(m=> m.Id, f => f.IndexFaker + 1)
                .RuleFor(m => m.Name, f => f.Commerce.ProductName())
                .RuleFor(m=> m.Description, f => f.Lorem.Sentence())
                .RuleFor(m=> m.Category, f => f.PickRandom(categories))
                .RuleFor(m=> m.SpecialTag, f => f.PickRandom(specialTags))
                .RuleFor(m=> m.Price, f=>Math.Round(f.Random.Double(1,1000),2))
                .RuleFor(m=> m.Image, f=>"https://cataas.com/cat?width=100&cat?height=:100")
                .Generate(count);
        }
    }
}