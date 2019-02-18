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
            base.OnModelCreating(modelBuilder);

            // DB seed data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Username = "gwen",
                    //Avatar = ""
                },
                new User
                {
                    ID = 2,
                    Username = "dave",
                    //Avatar = ""
                },
                new User
                {
                    ID = 3,
                    Username = "brandon",
                    //Avatar = ""
                },
                new User
                {
                    ID = 4,
                    Username = "alyssa",
                    //Avatar = ""
                },
                new User
                {
                    ID = 5,
                    Username = "madi",
                    //Avatar = ""
                }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    ID = 1,
                    Photo = "https://twaddlegram.blob.core.windows.net/userpics/boots.jpg",
                    Caption = "These boots are rockin'.",
                    UserID = 1
                },
                new Post
                {
                    ID = 2,
                    Photo = "https://twaddlegram.blob.core.windows.net/userpics/dog-duck.jpg",
                    Caption = "Duckdog!",
                    UserID = 2
                },
                new Post
                {
                    ID = 3,
                    Photo = "https://twaddlegram.blob.core.windows.net/userpics/bubblegum.jpg",
                    Caption = "mmm....delish!",
                    UserID = 3
                },
                new Post
                {
                    ID = 4,
                    Photo = "https://twaddlegram.blob.core.windows.net/userpics/cthulhu.jpg",
                    Caption = "grrrr!",
                    UserID = 4
                },
                new Post
                {
                    ID = 5,
                    Photo = "https://twaddlegram.blob.core.windows.net/userpics/sweep.png",
                    Caption = "This child has a future in the domestic arts.",
                    UserID = 5
                }
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    ID = 1,
                    Content = "They're great for swollen toes!",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 2,
                    Content = "Ewww... I don't wanna smell your feet.",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 3,
                    Content = "You could wear them for a pedicure!",
                    PostID = 1,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 4,
                    Content = "Quite possibly the worst thing ever.",
                    PostID = 3,
                    //UserID = 1
                },
                new Comment
                {
                    ID = 5,
                    Content = "Gotta teach them early!",
                    PostID = 5,
                    //UserID = 1
                }
                );

        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }


}
