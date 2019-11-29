using BlogOdev.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogOdev.Data.Context
{
  public  class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<BlogOdev.Data.Models.Blog> Blogs { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Page> Pages { get; set; }
    }
}
