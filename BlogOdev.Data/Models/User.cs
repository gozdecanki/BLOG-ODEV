using BlogOdev.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogOdev.Data.Models
{
   public class User:Entity
    {
        [Required,MinLength(3),MaxLength(50)]
        public string Username { get; set; }
        [Required,MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public Data.Enums.Gender Gender { get; set; }

        [Required, MinLength(6), MaxLength(320)]
        public string Email { get; set; }

        public int? NationalityId { get; set; }
        
        public Nationality Nationality { get; set; }

        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }
        
        public List<Blog> Blogs { get; set; }
    }
}
