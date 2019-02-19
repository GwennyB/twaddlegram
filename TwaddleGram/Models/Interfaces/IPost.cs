using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models.Interfaces
{
    public interface IPost
    {
        // GetAll
        Task<IEnumerable<Post>> GetAllPosts();

        // GetOne
        Task<Post> GetOnePost(int id);

        // Create
        Task MakePost(Post post);

        // Edit
        Task EditPost(Post post);

        // Delete
        Task DeletePost(int id);

    }
}
