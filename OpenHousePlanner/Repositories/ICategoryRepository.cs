using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAllCategories();
    }
}
