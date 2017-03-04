using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Models
{
    class Store
    {
        public List<Book> Books { get; set; }

        public Store()
        {
            this.Books = new List<Book>();
        }
    }
}
