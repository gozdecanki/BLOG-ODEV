using BlogOdev.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogOdev.Data.Models
{
   public class Nationality:Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
