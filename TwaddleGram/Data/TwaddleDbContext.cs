using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwaddleGram.Models;

namespace TwaddleGram.Data
{
    public class TwaddleDbContext : DbContext
    {
        public TwaddleDbContext(DbContextOptions<TwaddleDbContext> options) : base(options)
        {

        }


        /// <summary>
        /// overrides (DbContext virtual) method that builds out basic API structure
        /// maps composite keys
        /// </summary>
        /// <param name="modelBuilder">  </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // DB seed data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Username = "gwen",
                    Avatar = 0
                },
                new User
                {
                    ID = 2,
                    Username = "dave",
                    Avatar = 0
                },
                new User
                {
                    ID = 3,
                    Username = "brandon",
                    Avatar = 0
                },
                new User
                {
                    ID = 4,
                    Username = "alyssa",
                    Avatar = 0
                },
                new User
                {
                    ID = 5,
                    Username = "madi",
                    Avatar = 0
                }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    ID = 1,
                    Photo = 0,
                    Caption = "first post",
                    UserID = 1
                },
                new Post
                {
                    ID = 2,
                    Photo = 0,
                    Caption = "second post",
                    UserID = 1
                },
                new Post
                {
                    ID = 3,
                    Photo = 0,
                    Caption = "third post",
                    UserID = 1
                },
                new Post
                {
                    ID = 4,
                    Photo = 0,
                    Caption = "fourth post",
                    UserID = 1
                },
                new Post
                {
                    ID = 5,
                    Photo = 0,
                    Caption = "fifth post",
                    UserID = 1
                }
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    ID = 1,
                    Content = "first comment",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 2,
                    Content = "second comment",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 3,
                    Content = "third comment",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 4,
                    Content = "fourth comment",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 5,
                    Content = "fifth comment",
                    PostID = 1,
                    //UserID = 1
                }
                );

        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }


}
