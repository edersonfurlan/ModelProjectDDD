using ModelProjectDDD.Application.Interface;
using ModelProjectDDD.Domain.Entities;
using ModelProjectDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ModelProjectDDD.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;

        public ClientAppService(IClientService clientService)
            : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            return _clientService.GetSpecialClients(_clientService.GetAll());
        }
    }
}
