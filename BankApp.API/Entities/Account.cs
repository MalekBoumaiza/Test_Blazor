using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace BankApp.API.Entities
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public int? ClientId { get; set; }
        public Client? Client { get; set; } 
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Rib { get; set; }
        public bool IsActive { get; set; }

        //public ICollection<Transaction> Transactions { get; set; }
    }
}
