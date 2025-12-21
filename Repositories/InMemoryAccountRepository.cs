using BankingApp.Repositories;

namespace BankingApp.Repositories
{
    public class InMemoryAccountRepository: IAccountRepository
    {
        private readonly Dictionary<int, decimal> _accounts = new();

        public decimal GetBalance(int acccountId)
        {
            _accounts.TryGetValue(acccountId, out var balance);
            return balance;
        }

        public void UpdateBalance(int accountId, decimal newBalance)
        {
            _accounts[accountId] = newBalance;
        }
    }
}
