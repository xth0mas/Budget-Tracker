using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IExpenseService
    {
        Task AddExpenseAsync(string name, decimal amount, bool @const);
        Task DeleteExpenseAsync(int expenseId);
    }
}
