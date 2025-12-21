using BankingApp.Models;

namespace BankingApp.Services
{
    public interface IAccountService
    {
        TransactionResponse Deposit(TransactionRequest request);
    }
}
