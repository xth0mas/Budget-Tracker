using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IAsyncRepository<Expense> _expenseRepository;

        public ExpenseService(IAsyncRepository<Expense> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public Task AddExpenseAsync(string name, decimal amount, bool @const)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteExpenseAsync(int expenseId)
        {
            throw new System.NotImplementedException();
        }
    }
}
