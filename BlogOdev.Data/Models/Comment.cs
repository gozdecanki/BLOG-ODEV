using BlogOdev.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace BlogOdev.Data.Models
{
    public class Comment: Entity
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [Required,MinLength(2),MaxLength(500)]
        public string Content { get; set; }


        public int? UserId { get; set; }
        public User User { get; set; }

        [ MinLength(2), MaxLength(50)]
        public string Nickname { get; set; }

        [MinLength(6), MaxLength(320)]
        public string Email { get; set; }

        public int VoteUp { get; set; }

        public int DownUp { get; set; }
    }
}
