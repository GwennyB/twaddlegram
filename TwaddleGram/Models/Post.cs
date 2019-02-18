using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Caption { get; set; }
        public string Photo { get; set; } // how to load images?

        public ICollection<Comment> Comments { get; set; }

        // foreign keys
        public int UserID { get; set; }

        // Navigation Properties
        public User User { get; set; }
    }
}
