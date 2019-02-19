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

    }
}
