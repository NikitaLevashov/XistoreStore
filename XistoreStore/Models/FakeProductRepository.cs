using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XistoreStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name="Xiaomi Redmi Note Pro 9", Price=739},
            new Product {Name="Xiaomi Redmi Note Pro 8", Price=649},
            new Product {Name="Xiaomi Redmi Note 7", Price=399}
        }.AsQueryable<Product>();
    }
}
