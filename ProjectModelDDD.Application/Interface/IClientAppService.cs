using ModelProjectDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelProjectDDD.Application.Interface
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
