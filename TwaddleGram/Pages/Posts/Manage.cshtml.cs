using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using TwaddleGram.Models;
using TwaddleGram.Models.Interfaces;
using TwaddleGram.Models.Util;

namespace TwaddleGram.Pages.Posts
{
    public class ManageModel : PageModel
    {
        /// <summary>
        /// create a local context via Post interface
        /// </summary>
        private readonly IPost _post;
        public Blob ImageBlob { get; }
        public ManageModel(IPost post, IConfiguration configuration)
        {
            _post = post;
            // reference Blob Storage Account
            ImageBlob = new Blob(configuration);
        }

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Post Post { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        /// <summary>
        /// gets the Post with ID from query string and makes it available to page
        /// </summary>
        /// <returns> Post with record primary ID = 'ID' </returns>
        public async Task OnGet()
        {
                Post = await _post.GetOnePost(ID.GetValueOrDefault()) ?? new Post();
        }

        public async Task<IActionResult> OnPost()
        {
            Post query = await _post.GetOnePost(ID.GetValueOrDefault());
            if(query == null)
            {
                query = new Post();
                query.UserID = Post.UserID;
            }

            query.Caption = (Post.Caption != null) ? Post.Caption : query.Caption;

            if(Image != null)
            {
                // do all the blob stuff
                // 1. make a filepath
                var filePath = Path.GetTempFileName();
                // 2. open stream
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }
                // 3. get container and blob
                var container = await ImageBlob.GetContainer("userpics");
                CloudBlob blob = await ImageBlob.GetBlob(Image.FileName, container.Name);
                // 4. upload image
                ImageBlob.UploadFile(container,Image.FileName,filePath);
                query.Photo = blob.Uri.ToString();
            }

            if(query.ID == 0)
            {
                await _post.MakePost(query);
            }
            else
            {
                await _post.EditPost(query);
            }

            return RedirectToPage("../Index");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _post.DeletePost(ID.Value);
            return RedirectToPage("../Index");
        }
    }
}



