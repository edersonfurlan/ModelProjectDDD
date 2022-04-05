using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ModelProjectDDD.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return Db.Products.Where(p => p.Name == name);
        }
    }
}
