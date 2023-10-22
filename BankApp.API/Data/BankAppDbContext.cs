using BankApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.API.Data
{
    public class BankAppDbContext : DbContext
    {
        public BankAppDbContext(DbContextOptions<BankAppDbContext> options) : base(options)
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
