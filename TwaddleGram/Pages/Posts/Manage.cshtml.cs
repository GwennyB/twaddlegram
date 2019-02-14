using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TwaddleGram.Models;
using TwaddleGram.Models.Interfaces;

namespace TwaddleGram.Pages.Posts
{
    public class ManageModel : PageModel
    {
        /// <summary>
        /// create a local context via Post interface
        /// </summary>
        private readonly IPost _post;
        public ManageModel(IPost post)
        {
            _post = post;
        }

        [FromRoute]
        public int ID { get; set; }

        public Post Post { get; set; }

        /// <summary>
        /// gets the Post with ID from query string and makes it available to page
        /// </summary>
        /// <returns> Post with record primary ID = 'ID' </returns>
        public async Task OnGet()
        {
            Post = await _post.GetOnePost(ID);
        }
    }
}