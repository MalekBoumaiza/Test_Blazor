using BankApp.API.Data;
using BankApp.API.Entities;
using BankApp.API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BankApp.API.Repositories.Implementation
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankAppDbContext _dbContext;
        //protected ILogger _Logger;
        public AccountRepository(BankAppDbContext dbContext)
        {
            _dbContext = dbContext;
            //_Logger = logger;
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            try
            {
                var accounts = await _dbContext.Account.ToListAsync();
                return accounts;
            }
            catch (SystemException ex)
            {
                //_Logger.LogDebug("Erreur GetAllAccounts <::>" + ex.ToString());
                return null;
            }
            
        }

        public async Task<Account> GetAccountById(int id)
        {
            try
            {
                var account = await _dbContext.Account.FindAsync(id);
                if (account is null)
                    return null;

                return account;
            }
            catch (SystemException ex)
            {
                //_Logger.LogDebug("Erreur GetAccountById <::>" + ex.ToString());
                return null;
            }
           
        }


        public async Task<bool> AddAccount(Account account)
        {
            try
            {
                _dbContext.Account.Add(account);
                _dbContext.SaveChangesAsync();

                return true;
            }
            catch (SystemException ex)
            {
                //_Logger.LogDebug("Erreur AddAccount <::>" + ex.ToString());
                return false;
            }
        }

    }
}
