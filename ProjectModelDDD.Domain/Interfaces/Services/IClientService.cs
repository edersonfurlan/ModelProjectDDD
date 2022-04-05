using ModelProjectDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModelProjectDDD.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);
    }
}
