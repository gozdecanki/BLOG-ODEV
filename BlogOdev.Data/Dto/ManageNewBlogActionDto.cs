using System;
using System.Collections.Generic;
using System.Text;

namespace BlogOdev.Data.Dto
{
    public class ManageNewBlogActionDto
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}