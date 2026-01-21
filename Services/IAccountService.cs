using BankingApp.Models;

namespace BankingApp.Services
{
    // add more operations later like withdrawal, transfer, etc.
    public interface IAccountService
    {
        TransactionResponse Deposit(TransactionRequest request);
    }
}
