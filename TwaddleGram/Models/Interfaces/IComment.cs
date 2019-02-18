using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models.Interfaces
{
    public interface IComment
    {
        // GetAll
        Task<IEnumerable<Comment>> GetAllComments();

        //// Get One User's Comments
        //Task<IEnumerable<Comment>> GetUserComments(int id);

        // Get One Post's Comments
        Task<IEnumerable<Comment>> GetPostComments(int id);

        // GetOne
        Task<Comment> GetOneComment(int id);

        // Create
        Task MakeComment(Comment comment);

        // Edit
        Task EditComment(Comment comment);

        // Delete
        Task DeleteComment(int id);
    }
}
