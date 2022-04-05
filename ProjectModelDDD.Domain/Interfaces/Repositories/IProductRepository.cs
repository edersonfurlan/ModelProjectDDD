using ModelProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjectDDD.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
