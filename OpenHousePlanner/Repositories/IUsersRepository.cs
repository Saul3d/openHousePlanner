using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByEmail(string email);
        IEnumerable<User> AddUsers(NewUsersDTO newUser);
        User UpdateThisUser(int id, User updatesForUser);
        bool Remove(int id, bool isActive);
    }
}
