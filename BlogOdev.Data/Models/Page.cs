using BlogOdev.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace BlogOdev.Data.Models
{
    public class Page:Entity
    {
        [Required,MinLength(1),MaxLength(150) ]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        public Enums.PageKind PageKind { get; set; }
    }
}
