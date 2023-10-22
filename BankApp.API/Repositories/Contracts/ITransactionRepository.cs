using BankApp.API.Entities;

namespace BankApp.API.Repositories.Contracts
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetAllTransactions();
        Task<Transaction> GetTransactionById(int id);
        Task<bool> AddTransaction(Transaction transaction);
    
    }
}
