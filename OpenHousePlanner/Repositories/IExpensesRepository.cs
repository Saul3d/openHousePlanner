using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface IExpensesRepository
    {
        IEnumerable<Expense> GetAllExpenses();
    }
}
