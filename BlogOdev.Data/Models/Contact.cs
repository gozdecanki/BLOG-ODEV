using BlogOdev.Data.Abstraction;

namespace BlogOdev.Data.Models
{
    public class Contact:Entity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Message { get; set; }
    }
}
