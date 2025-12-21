using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class TransactionRequest
    {
        public int customerId { get; set; }
        public int accountId { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greateer than zero")]
        public decimal amount { get; set; }
    }

    public class TransactionResponse
    {
        public int customerId { get; set; }
        public int accountId { get; set; }
        public decimal balance { get; set; }
        public bool succeeded { get; set; }
    }

}
