using BlogOdev.Data.Abstraction;

namespace BlogOdev.Data.Models
{
    public class Nationality:Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
