using BankingApp.Models;
using BankingApp.Repositories;

namespace BankingApp.Repositories
{
    public class InMemoryAccountRepository: IAccountRepository
    {
        private readonly Dictionary<int, Account> _accounts = new();

        public decimal GetBalance(int accountId)
        {
            var isAccount = _accounts.TryGetValue(accountId, out var account);
            if (isAccount)
            {
                return account.Balance;
            }
            return 0;

        }

        public void UpdateBalance(int accountId, decimal newBalance)
        {
            var isAccount = _accounts.TryGetValue(accountId, out var account);
            if (isAccount)
            {
                account.Balance = newBalance;
            }
        }

        public Account GetAccount(int accountId)
        {
            _accounts.TryGetValue(accountId, out var account);
            return account;
        }

        public void AddAccount(Account account)
        {
            _accounts[account.AccountId] = account;
        }
    }
}
