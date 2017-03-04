using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Models
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> RentedBooks { get; set; }
        public List<Book> Trolley { get; set; }

        public Client(string name, string email)
        {
            this.Name = name;
            this.Email = email;

            this.RentedBooks = new List<Book>();
            this.Trolley = new List<Book>();
        }
    }
}
