using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwaddleGram.Data;
using TwaddleGram.Models.Interfaces;

namespace TwaddleGram.Models.Services
{
    public class UserManager : IUser
    {
        /// <summary>
        /// build local context
        /// </summary>
        private TwaddleDbContext _context { get; }
        public UserManager(TwaddleDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// returns all records in Users table
        /// </summary>
        /// <returns> IEnumerable collection of users </returns>
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await Task.Run(() => _context.Users.AsEnumerable());
        }

        /// <summary>
        /// returns a single user by ID
        /// </summary>
        /// <param name="id"> ID of user to get </param>
        /// <returns> user (if found), or null (if not found) </returns>
        public async Task<User> GetOneUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(m => m.ID == id);
        }

        /// <summary>
        /// creates a new record in Users
        /// </summary>
        /// <param name="post"> User object to add to Users </param>
        /// <returns> task complete </returns>
        public async Task MakeUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// updates an existing user
        /// </summary>
        /// <param name="post"> updated user object to update in Users table </param>
        /// <returns> task completed </returns>
        public async Task EditUser(User user)
        {
            await Task.Run(() => _context.Users.Update(user));
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// deletes a record from the Users table
        /// </summary>
        /// <param name="id"> ID of user to delete </param>
        /// <returns> task completed </returns>
        public async Task DeleteUser(int id)
        {
            var query = await _context.Users.FirstOrDefaultAsync(m => m.ID == id);
            if (query != null)
            {
                await Task.Run(() => _context.Remove(query));
                await _context.SaveChangesAsync();
            }
        }
    }
}
