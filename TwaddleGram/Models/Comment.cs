using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwaddleGram.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }

        // foreign keys
        public int UserID { get; set; }
        public int PostID { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
