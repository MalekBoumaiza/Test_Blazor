using BankApp.API.Entities;
using BankApp.API.Repositories.Contracts;

namespace BankApp.API.Repositories.Implementation
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<bool> AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransactionById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
