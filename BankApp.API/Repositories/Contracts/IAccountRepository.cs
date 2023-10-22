using BankApp.API.Entities;

namespace BankApp.API.Repositories.Contracts
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAccounts();
        Task<Account> GetAccountById(int id);
        Task<bool> AddAccount(Account account);
    }
}
