using BankApp.API.Entities;

namespace BankApp.API.Repositories.Contracts
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientById(int id);
        Task<bool> AddClient(Client client);
        Task<bool> UpdateClient(Client client);
    }
}
