using System;
using System.Collections.Generic;
using System.Text;

namespace BlogOdev.Data.Dto
{
   public class BlogAddDto
    {
        public string Title { get; set; }
        public string  Content { get; set; }

        public int CategoryId { get; set; }
    }
}
