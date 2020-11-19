using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetApp.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Piłka nożna", Price = 23},
            new Product {Name = "Deskorolka", Price = 56},
            new Product {Name = "Buty", Price = 120},
        }.AsQueryable<Product>();

        public Product DelateProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
