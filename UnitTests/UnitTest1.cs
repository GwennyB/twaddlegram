using System;
using Xunit;
using TwaddleGram.Models;
using TwaddleGram.Data;
using TwaddleGram.Models.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace UnitTests
{
    public class UnitTest1
    {

        /// <summary>
        /// verifies that GetAllUsers returns a list of the correct length
        /// </summary>
        [Fact]
        public async void GetAllUsers_GetsAllUsers()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetAllUsers").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                User one = new User();
                User two = new User();
                User three = new User();
                User four = new User();
                User five = new User();

                await _context.Users.AddAsync(one);
                await _context.Users.AddAsync(two);
                await _context.Users.AddAsync(three);
                await _context.Users.AddAsync(four);
                await _context.Users.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                UserManager service = new UserManager(_context);

                var query = await service.GetAllUsers();
                int count = query.ToList<User>().Count;

                //assert
                Assert.Equal(5, count);
            }

        }


        /// <summary>
        /// verifies that GetAllUsers returns a list with expected User objects
        /// </summary>
        [Fact]
        public async void GetAllUsers_GetsExpectedUserObjects()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetUserObjects").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                User one = new User();
                User two = new User();
                User three = new User();
                User four = new User();
                User five = new User();

                one.Username = "one";
                two.Username = "two";
                three.Username = "three";
                four.Username = "four";
                five.Username = "five";

                await _context.Users.AddAsync(one);
                await _context.Users.AddAsync(two);
                await _context.Users.AddAsync(three);
                await _context.Users.AddAsync(four);
                await _context.Users.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                UserManager service = new UserManager(_context);

                var query = await service.GetAllUsers();
                List<User> queryList = query.ToList<User>();

                //assert
                Assert.Equal("five", queryList[4].Username);
            }
        }




        /// <summary>
        /// verifies that GetAllPosts returns a list of the correct length
        /// </summary>
        [Fact]
        public async void GetAllPosts_GetsAllPosts()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetAllPosts").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                Post one = new Post();
                Post two = new Post();
                Post three = new Post();
                Post four = new Post();
                Post five = new Post();

                await _context.Posts.AddAsync(one);
                await _context.Posts.AddAsync(two);
                await _context.Posts.AddAsync(three);
                await _context.Posts.AddAsync(four);
                await _context.Posts.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                PostManager service = new PostManager(_context);

                var query = await service.GetAllPosts();
                int count = query.ToList<Post>().Count;

                //assert
                Assert.Equal(5, count);
            }

        }



        /// <summary>
        /// verifies that GetAllPosts returns a list with expected User objects
        /// </summary>
        [Fact]
        public async void GetAllPosts_GetsExpectedPostObjects()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetPostObjects").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                Post one = new Post();
                Post two = new Post();
                Post three = new Post();
                Post four = new Post();
                Post five = new Post();

                one.Caption = "one";
                two.Caption = "two";
                three.Caption = "three";
                four.Caption = "four";
                five.Caption = "five";

                await _context.Posts.AddAsync(one);
                await _context.Posts.AddAsync(two);
                await _context.Posts.AddAsync(three);
                await _context.Posts.AddAsync(four);
                await _context.Posts.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                PostManager service = new PostManager(_context);

                var query = await service.GetAllPosts();
                List<Post> queryList = query.ToList<Post>();

                //assert
                Assert.Equal("five", queryList[4].Caption);
            }
        }

        /// <summary>
        /// verifies that GetOnePost returns the correct post
        /// </summary>
        [Fact]
        public async void GetOnePost_ReturnsCorrectPost()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetOnePost").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                Post one = new Post();
                Post two = new Post();
                Post three = new Post();
                Post four = new Post();
                Post five = new Post();

                one.Caption = "one";
                two.Caption = "two";
                three.Caption = "three";
                four.Caption = "four";
                five.Caption = "five";

                await _context.Posts.AddAsync(one);
                await _context.Posts.AddAsync(two);
                await _context.Posts.AddAsync(three);
                await _context.Posts.AddAsync(four);
                await _context.Posts.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                PostManager service = new PostManager(_context);

                var query = await service.GetOnePost(5);

                //assert
                Assert.Equal("five", query.Caption);
            }
        }


        /// <summary>
        /// verifies that GetOnePost returns 'null' if not found
        /// </summary>
        [Fact]
        public async void GetOnePost_ReturnsNull()
        {
            DbContextOptions<TwaddleDbContext> options = new DbContextOptionsBuilder<TwaddleDbContext>().UseInMemoryDatabase("GetNullPost").Options;

            using (TwaddleDbContext _context = new TwaddleDbContext(options))
            {
                //arrange
                Post one = new Post();
                Post two = new Post();
                Post three = new Post();
                Post four = new Post();
                Post five = new Post();

                one.Caption = "one";
                two.Caption = "two";
                three.Caption = "three";
                four.Caption = "four";
                five.Caption = "five";

                await _context.Posts.AddAsync(one);
                await _context.Posts.AddAsync(two);
                await _context.Posts.AddAsync(three);
                await _context.Posts.AddAsync(four);
                await _context.Posts.AddAsync(five);
                await _context.SaveChangesAsync();

                //act
                PostManager service = new PostManager(_context);

                //assert
                Assert.Null(await service.GetOnePost(6));
            }
        }


    }
}

