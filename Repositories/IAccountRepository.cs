namespace BankingApp.Repositories
{
    public interface IAccountRepository
    {
        //methods needed to make a deposit
        decimal GetBalance(int accountId);
        void UpdateBalance(int accountId, decimal balance);
    }
}
