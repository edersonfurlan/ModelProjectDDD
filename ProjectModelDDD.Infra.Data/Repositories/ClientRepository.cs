using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Domain.Interfaces.Repositories;

namespace ModelProjectDDD.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
    }
}
