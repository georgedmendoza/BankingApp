using BankingApp.Models;

namespace BankingApp.Repositories
{
    public interface IAccountRepository
    {
        //methods needed to make a deposit
        decimal GetBalance(int accountId);
        void UpdateBalance(int accountId, decimal balance);
        // validate account
        Account GetAccount(int AccountId);
        // adding acct to storage/db and test
        void AddAccount(Account account);
    }
}
