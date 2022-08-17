using System;
using System.Collections.Generic;

namespace BookApp.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public long Isbn { get; set; }
        public string Title { get; set; }
        public short? PubYear { get; set; }
        public DateTime? PurchDate { get; set; }
        public int? PubId { get; set; }

        public virtual Publisher Pub { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
