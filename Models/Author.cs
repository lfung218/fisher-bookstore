using System;

namespace Fisher.Bookstore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public void PublishBook(Book book)
        {
            //code to publish book goes here
        }

    }
}