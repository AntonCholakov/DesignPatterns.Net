using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Models
{
    class Author
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Author(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }
    }
}
