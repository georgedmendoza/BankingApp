using BankingApp.Models;
using BankingApp.Repositories;
using BankingApp.Services;
using System.Transactions;

namespace BankingApp.Services
{
    public class AccountService : IAccountService
    {
        // reference to object IAccountRepository
        private readonly IAccountRepository _repo;
        public AccountService(IAccountRepository repo) => _repo = repo;

        public TransactionResponse Deposit(TransactionRequest request)
        {
            var account = _repo.GetAccount(request.accountId);
            if (account == null)
            {
                throw new Exception("Account does not exist");
            }
            if (account.CustomerId != request.customerId)
            {
                throw new Exception("Account does not match the specified user");
            }

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
