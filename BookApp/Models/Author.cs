using System;
using System.Collections.Generic;

namespace BookApp.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
