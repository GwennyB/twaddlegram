using Microsoft.EntityFrameworkCore;
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
        /// <summary>
        /// build local context
        /// </summary>
        private TwaddleDbContext _context { get; }
        public PostManager(TwaddleDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// returns all records in Posts table
        /// </summary>
        /// <returns> IEnumerable collection of posts </returns>
        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var query = await Task.Run(() => _context.Posts.AsEnumerable());
            foreach (var item in query)
            {
                item.Comments = await _context.Comments.Where(m => m.PostID == item.ID).ToListAsync();
                item.User = await _context.Users.FirstOrDefaultAsync(m => m.ID == item.UserID);
            }
            return query;
        }

        /// <summary>
        /// returns all records in Posts table associated with this User
        /// </summary>
        /// <returns> IEnumerable collection of posts </returns>
        public async Task<IEnumerable<Post>> GetUserPosts(int id)
        {
            return await Task.Run(() => _context.Posts.Where(m => m.UserID == id));
        }

        /// <summary>
        /// returns a single post by ID
        /// </summary>
        /// <param name="id"> ID of post to get </param>
        /// <returns> post (if found), or null (if not found) </returns>
        public async Task<Post> GetOnePost(int id)
        {
            if (id == 0)
            {
                return null;
            }
            var query = await _context.Posts.FirstOrDefaultAsync(m => m.ID == id);
            query.Comments = await _context.Comments.Where(m => m.PostID == id).ToListAsync();
            query.User = await _context.Users.FirstOrDefaultAsync(m => m.ID == query.UserID);
            return query;
        }

        /// <summary>
        /// creates a new record in Posts
        /// </summary>
        /// <param name="post"> Post object to add to Posts</param>
        /// <returns> task complete </returns>
        public async Task MakePost(Post post)
        {
            await _context.Posts.AddAsync (post);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// updates an existing post
        /// </summary>
        /// <param name="post"> updated post object to update in Posts table </param>
        /// <returns> task completed </returns>
        public async Task EditPost(Post post)
        {
            var query = 
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();

        }

        /// <summary>
        /// deletes a record from the Posts table
        /// </summary>
        /// <param name="id"> ID of post to delete </param>
        /// <returns> task completed </returns>
        public async Task DeletePost(int id)
        {
            var query = await _context.Posts.FirstOrDefaultAsync(m => m.ID == id);
            if (query != null)
            {
                await Task.Run(() => _context.Remove(query));
                await _context.SaveChangesAsync();
            }
        }

    }
}
