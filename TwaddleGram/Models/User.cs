using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Avatar { get; set; } // how to hold images?

        //public ICollection<Comment> Comments { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
