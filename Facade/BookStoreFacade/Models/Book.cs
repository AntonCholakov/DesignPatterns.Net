using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Models
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public Book(int isbn, string title)
        {
            this.ISBN = isbn;
            this.Title = title;
        }
    }
}
