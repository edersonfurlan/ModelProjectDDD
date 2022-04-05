using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Domain.Interfaces.Repositories;
using ModelProjectDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ModelProjectDDD.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productRepository.GetByName(name);
        }
    }
}
