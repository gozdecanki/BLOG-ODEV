using BlogOdev.Data.Abstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogOdev.Data.Models
{
    public class Category:Entity
    {
        [Required,MinLength(1),MaxLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
