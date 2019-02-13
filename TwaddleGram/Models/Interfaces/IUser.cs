using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models.Interfaces
{
    interface IUser
    {
        // GetAll
        Task<IEnumerable<User>> GetAllUsers();

        // GetOne
        Task<User> GetOneUser(int id);

        // Create
        Task CreateUser(User user);

        // Edit
        Task EditUser(User user);

        // Delete
        Task DeleteUser(int id);

    }
}
