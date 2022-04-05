using ModelProjectDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelProjectDDD.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
