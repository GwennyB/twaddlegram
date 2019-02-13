using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models.Interfaces
{
    interface IPost
    {
        // GetAll
        Task<IEnumerable<Post>> GetAllPosts();

        // GetOne
        Task<Post> GetOnePost();

        // Create
        Task MakePost();

        // Edit
        Task EditPost();

        // Delete
        Task DeletePost();

    }
}
