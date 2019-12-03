using BlogOdev.Data.Abstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogOdev.Data.Models
{
    public class Blog:Entity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        [Required,MinLength(1),MaxLength(250)]
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Content { get; set; }

        public int Hit { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
