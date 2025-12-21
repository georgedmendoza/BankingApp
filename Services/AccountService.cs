using BankingApp.Models;
using BankingApp.Repositories;
using BankingApp.Services;
using System.Transactions;

namespace BankingApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        public AccountService(IAccountRepository repo) => _repo = repo;

        public TransactionResponse Deposit(TransactionRequest request)
        {
            var balance = _repo.GetBalance(request.accountId);
            balance += request.amount;
            _repo.UpdateBalance(request.accountId, balance);
            // show post request
            return new TransactionResponse
            {
                customerId = request.customerId,
                accountId = request.accountId,
                balance = balance,
                succeeded = true,
            };
        }
    }
}
