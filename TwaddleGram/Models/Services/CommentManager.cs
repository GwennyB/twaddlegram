using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwaddleGram.Data;
using TwaddleGram.Models.Interfaces;

namespace TwaddleGram.Models.Services
{
    public class CommentManager : IComment
    {
        /// <summary>
        /// build local context
        /// </summary>
        private TwaddleDbContext _context { get; }
        public CommentManager(TwaddleDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// returns all records in Comments table
        /// </summary>
        /// <returns> IEnumerable collection of comments </returns>
        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            return await Task.Run(() => _context.Comments.AsEnumerable());
        }

        ///// <summary>
        ///// returns all records in Comments table associated with this User
        ///// </summary>
        ///// <returns> IEnumerable collection of comments </returns>
        //public async Task<IEnumerable<Comment>> GetUserComments(int id)
        //{
        //    return await Task.Run(() => _context.Comments.Where(m => m.UserID == id));
        //}

        /// <summary>
        /// returns all records in Comments table associated with this Post
        /// </summary>
        /// <returns> IEnumerable collection of comments </returns>
        public async Task<IEnumerable<Comment>> GetPostComments(int id)
        {
            return await Task.Run(() => _context.Comments.Where(m => m.PostID == id));

        }

        /// <summary>
        /// returns a single comment by ID
        /// </summary>
        /// <param name="id"> ID of comment to get </param>
        /// <returns> comment (if found), or null (if not found) </returns>
        public async Task<Comment> GetOneComment(int id)
        {
            return await _context.Comments.FirstOrDefaultAsync(m => m.ID == id);
        }

        /// <summary>
        /// creates a new record in Comments
        /// </summary>
        /// <param name="comment"> Comment object to add to Comments</param>
        /// <returns> task complete </returns>
        public async Task MakeComment(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// updates an existing comment
        /// </summary>
        /// <param name="comment"> updated comment object to update in Comments table </param>
        /// <returns> task completed </returns>
        public async Task EditComment(Comment comment)
        {
            await Task.Run(() => _context.Comments.Update(comment));
            await _context.SaveChangesAsync();

        }

        /// <summary>
        /// deletes a record from the Comments table
        /// </summary>
        /// <param name="id"> ID of comment to delete </param>
        /// <returns> task completed </returns>
        public async Task DeleteComment(int id)
        {
            var query = await _context.Comments.FirstOrDefaultAsync(m => m.ID == id);
            if (query != null)
            {
                await Task.Run(() => _context.Remove(query));
                await _context.SaveChangesAsync();
            }
        }
    }
}
