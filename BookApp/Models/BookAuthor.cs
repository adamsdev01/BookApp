using System;
using System.Collections.Generic;

namespace BookApp.Models
{
    public partial class BookAuthor
    {
        public long Isbn { get; set; }
        public int AuthorId { get; set; }
        public byte? AuthorOrd { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book IsbnNavigation { get; set; }
    }
}
