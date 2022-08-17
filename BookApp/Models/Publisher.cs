using System;
using System.Collections.Generic;

namespace BookApp.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
