using System;


namespace BlogOdev.Data.Abstraction
{
  public abstract  class Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public bool Deleted { get; set; }
    }
}
