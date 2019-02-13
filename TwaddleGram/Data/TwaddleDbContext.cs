using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Data
{
    public class TwaddleDbContext : DbContext
    {
        public TwaddleDbContext(DbContextOptions<TwaddleDbContext> options) : base(options)
        {

        }
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }

}
