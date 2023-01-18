using Core.Abstraction.Repository;
using Core.Abstraction.Services;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class ProductServices : IProductServices
    {
        private readonly IProductRepository _repository;

        public ProductServices(IProductRepository productrepository)
        {
            _repository = productrepository;
        }

        public void InsertProducts(Proizvod product)
        {
            
        }
    }
}
