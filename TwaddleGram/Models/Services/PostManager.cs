﻿using Microsoft.EntityFrameworkCore;
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
            return await _context.Posts.ToListAsync();
        }

        /// <summary>
        /// returns a single post by ID
        /// </summary>
        /// <param name="id"> ID of post to get </param>
        /// <returns> post (if found), or null (if not found) </returns>
        public async Task<Post> GetOnePost(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(m => m.ID == id);
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
            await Task.Run(() => _context.Posts.Update(post));
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