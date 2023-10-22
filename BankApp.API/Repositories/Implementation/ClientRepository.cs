using BankApp.API.Entities;
using BankApp.API.Repositories.Contracts;

namespace BankApp.API.Repositories.Implementation
{
    public class ClientRepository : IClientRepository
    {
        public Task<bool> AddClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
