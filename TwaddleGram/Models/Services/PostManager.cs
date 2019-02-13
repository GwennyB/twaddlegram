using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwaddleGram.Data;
using TwaddleGram.Models.Interfaces;

namespace TwaddleGram.Models.Services
{
    public class PostManager : IPost
    {

        private TwaddleDbContext _context { get; }

        public PostManager(TwaddleDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetOnePost()
        {
            throw new NotImplementedException();
        }

        public Task MakePost()
        {
            throw new NotImplementedException();
        }

        public Task EditPost()
        {
            throw new NotImplementedException();
        }

        public Task DeletePost()
        {
            throw new NotImplementedException();
        }
    }
}
