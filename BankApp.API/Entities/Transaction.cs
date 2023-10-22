using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.API.Entities
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public int? CreditedAccountId { get; set; }
        public Account? CreditedAccount { get; set; }
        public int? DebitedAccountId { get; set; }
        public Account? DebitedAccount { get; set; }
        public string? TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal? TransactionFee { get; set; }
        public decimal? NewAmount { get; set; }
        public decimal? OldAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
