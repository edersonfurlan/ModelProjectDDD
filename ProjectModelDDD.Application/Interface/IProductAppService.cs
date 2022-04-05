using ModelProjectDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelProjectDDD.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
