using Core.Abstraction.Repository;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Proizvod> _products;

        public ProductRepository()
        {
            _products = new List<Proizvod>();
        }
        public void Insert(Proizvod product)
        {
            _products.Add(product);
        }
    }
}
